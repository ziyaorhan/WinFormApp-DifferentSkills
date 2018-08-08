using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WFA_DifferentSkills.AppClasses
{
    public static class DatabaseOperations
    {

        public static string SqlConnStrBuilder(string dataSource = "localhost", string userId = "sa", string password = "123", string initialCatalog = "WFASkillsDB")
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.PersistSecurityInfo = false;
            builder.IntegratedSecurity = false;
            builder.DataSource = dataSource;
            builder.UserID = userId;
            builder.Password = password;
            builder.InitialCatalog = initialCatalog;
            return builder.ConnectionString;
        }

        public static string SqlConnStrBuilder(string initialCatalog = "WFASkillsDB")
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.PersistSecurityInfo = false;
            builder.IntegratedSecurity = true;
            builder.DataSource = "localhost";
            builder.InitialCatalog = initialCatalog;
            return builder.ConnectionString;
        }
        
        public static string GetConnStrFromAppConfig()
        {
            string returnValue = null;
            DirectoryInfo projectBinFolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath);
            string appConfigFilePath = projectBinFolder.Parent.FullName + "\\App.config";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(appConfigFilePath);
            foreach (XmlNode rootNode in xDoc.ChildNodes)// 1-xml ve 2-configuration
            {
                if (rootNode.Name == "configuration")
                {
                    foreach (XmlNode subNode in rootNode.ChildNodes)
                    {
                        if (subNode.Name == "connectionStrings")
                        {
                            foreach (XmlNode childNode in subNode.ChildNodes)
                            {
                                if (childNode.Name == "add" && childNode.Attributes["name"].Value == "DatabaseContext")
                                {
                                    returnValue = childNode.Attributes["connectionString"].Value;
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }

        public static bool UpdateConnStrInAppConfig(string modifyConnStr)
        {
            bool status = false;
            DirectoryInfo projectBinFolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath);
            string appConfigFilePath = projectBinFolder.Parent.FullName + "\\App.config";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(appConfigFilePath);
            foreach (XmlNode rootNode in xDoc.ChildNodes)// 1-xml ve 2-configuration
            {
                if (rootNode.Name == "configuration")
                {
                    foreach (XmlNode subNode in rootNode.ChildNodes)
                    {
                        if (subNode.Name == "connectionStrings")
                        {
                            foreach (XmlNode childNode in subNode.ChildNodes)
                            {
                                if (childNode.Name == "add" && childNode.Attributes["name"].Value == "DatabaseContext")
                                {
                                    childNode.Attributes["connectionString"].Value = modifyConnStr;
                                }
                            }
                        }
                    }
                }
            }
            xDoc.PreserveWhitespace = true;
            xDoc.Save(appConfigFilePath);
            status = true;
            return status;
        }
        // for localhost
        public static bool IsThereADbInLocal(string databaseName)
        {
            int result = 0;
            string connStr = SqlConnStrBuilder(initialCatalog: "master");
            SqlConnection conn = new SqlConnection(connStr);
            string commandText = "SELECT Count(name) FROM master.dbo.sysdatabases WHERE name=@prmDbName";
            SqlCommand cmd = new SqlCommand(commandText, conn);
            cmd.Parameters.AddWithValue("@prmDbName", (object)databaseName.Trim());
            conn.Open();
            result = Convert.ToInt32(cmd.ExecuteScalar());
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // for localhost
        public static bool CreateDbToLocalHost(string databaseName)
        {
            bool returnValue = false;
            try
            {
                string connStr = SqlConnStrBuilder(initialCatalog: "master");
                SqlConnection conn = new SqlConnection(connStr);
                string commandText = "Create Database " + databaseName;
                SqlCommand cmd = new SqlCommand(commandText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                returnValue = true;
            }
            catch
            {
                returnValue = false;
            }
            return returnValue;
        }

        public static bool IsThereAConnection(string connStr)
        {
            bool returnValue = false;
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                returnValue = true;
                conn.Close();
            }
            catch
            {
                returnValue = false;
            }

            return returnValue;
        }

        public static StatusOfExecutedSqlCmd DBExecutorFromSqlFile(string connStr, string sqlFileNameWithoutExtension, string createdDbName)
        {
            try
            {
                string setupStatusStr = "";

                //read  sql file.
                DirectoryInfo projectBinFolder = Directory.GetParent(Application.StartupPath);
                string sqlFilePath = projectBinFolder.Parent.FullName + "\\Files\\SqlScript\\" + sqlFileNameWithoutExtension.Trim() + ".sql";
                string sqlFileAllText = File.ReadAllText(sqlFilePath);
                //sqlFileAllText input value for Regex.Spit()
                //@"^\s*GO\s*$" ----> patern for Regex.Spit()
                string[] originalCommands = Regex.Split(sqlFileAllText, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                List<string> commands = new List<string>();//ready to execute commands
                                                           //"USE" line chance
                string useLineNewCmd = "USE [" + createdDbName + "]";
                commands.Add(useLineNewCmd);
                for (int i = 1; i < originalCommands.Length; i++)//adding, after the "USE" command line
                {
                    commands.Add(originalCommands[i]);
                }
                List<ProblematicSqlCommand> prbSqlCmdLst = new List<ProblematicSqlCommand>();
                int allCmdCount = commands.Count;
                int unexecutedCmdCount = 0;
                int executedCmdCount = allCmdCount - unexecutedCmdCount;
                SqlConnection connection = new SqlConnection(connStr);
                connection.Open();
                for (int i = 0; i < allCmdCount; i++)
                {
                    try
                    {
                        if (!String.IsNullOrEmpty(commands[i].ToString().Trim()))
                        {
                            new SqlCommand(commands[i], connection).ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        ProblematicSqlCommand problemCmd = new ProblematicSqlCommand();
                        problemCmd.LineNoByPaternOrder = i;
                        if (!String.IsNullOrWhiteSpace(commands[i].ToString()))
                            problemCmd.SqlExpression = commands[i];
                        else
                            problemCmd.SqlExpression = ex.Message.ToString();
                        prbSqlCmdLst.Add(problemCmd);
                        unexecutedCmdCount++;
                        break;
                    }
                }
                connection.Close();
                if (unexecutedCmdCount != 0)
                    setupStatusStr = "Problemli satırlar var.";
                else
                    setupStatusStr = "Başarılı.";
                StatusOfExecutedSqlCmd status = new StatusOfExecutedSqlCmd();
                status.PrbSqlCmdLst = prbSqlCmdLst;
                status.SetupStatusStr = setupStatusStr;
                status.AllCmdCount = commands.Count;
                status.UnexecutedCmdCount = unexecutedCmdCount;
                status.ExecutedCmdCount = executedCmdCount;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! Veritabanı execute işlemi sırasında bağlantı sağlanamadı." + Environment.NewLine + "Exception: " + ex.Message.ToString());
                return null;
            }
        }
    }
    public class ProblematicSqlCommand
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public int LineNoByPaternOrder { get; set; }
        public string SqlExpression { get; set; }
    }
    //return parameter
    public class StatusOfExecutedSqlCmd
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public List<ProblematicSqlCommand> PrbSqlCmdLst { get; set; }
        public int MyProperty { get; set; }
        public int AllCmdCount { get; set; }
        public int ExecutedCmdCount { get; set; }
        public int UnexecutedCmdCount { get; set; }
        public string SetupStatusStr { get; set; }
    }
    
}
