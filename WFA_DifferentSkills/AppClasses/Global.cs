﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DifferentSkills.AppClasses
{
    public static class Global
    {
        /// <summary>
        /// this list keeps open forms 
        /// </summary>
        public static List<string> openForms = new List<string>();
        /// <summary>
        /// This parameter represents the visibility or invisibility for a web browser tool. 
        /// </summary>
        public static bool wbMainVisibility = true;
        /// <summary>
        /// This method fills the webBrowser control in a form.
        /// </summary>
        /// <param name="htmlFileName">This parameter represent the html file in the Files\Descriptions folder. for example: index.html</param>
        /// <param name="wb">This parameter represent WebBrowser control in Windows Form Tools.</param>
        public static void WebBrowserFill(string htmlFileName, WebBrowser wb)
        {
            wb.Visible = true;
            DirectoryInfo projectBinFolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath);
            string descriptionFolderPath = projectBinFolder.Parent.FullName + "\\Files\\Descriptions";
            string descriptionFileUrl = descriptionFolderPath + "\\" + htmlFileName;
            wb.Url = new Uri(descriptionFileUrl);
        }
        /// <summary>
        /// This method converts serialize data to deserialize.
        /// </summary>
        /// <typeparam name="T">This type parameter represent a model or generic list and return them.</typeparam>
        /// <param name="url">This parameter represent the way of serialize json data</param>
        /// <returns></returns>
        public static T GetDeserializeJson<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var jsonData = string.Empty;

                try
                {
                    var webRequest = WebRequest.Create(url) as HttpWebRequest;
                    if (webRequest != null)
                    {
                        webRequest.ContentType = "application/json";
                        webRequest.UserAgent = "Nothing";
                        using (var s = webRequest.GetResponse().GetResponseStream())
                        {
                            using (var sr = new StreamReader(s))
                            {
                                jsonData = sr.ReadToEnd();
                            }
                        }
                    }
                }
                catch { }
                // if the json data is not empty, it is deserialized.
                return !string.IsNullOrEmpty(jsonData) ? Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonData) : new T();
            }
        }

        //private static string sqlConnBuilder(string dataSource = "", string userId = "sa", string password = "123", string initialCatalog = "master")
        //{
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //    builder.PersistSecurityInfo = false;
        //    builder.IntegratedSecurity = false;
        //    if (dataSource == "")
        //        builder.DataSource = Environment.MachineName;
        //    else
        //        builder.DataSource = dataSource;
        //    builder.UserID = userId;
        //    builder.Password = password;
        //    builder.InitialCatalog = initialCatalog;

        //    return builder.ConnectionString;
        //}

        //public static void DBScriptExecutor()
        //{
        //    // read northwind file. 
        //    DirectoryInfo projectBinFolder = Directory.GetParent(Application.StartupPath);
        //    string northwindScriptPath = projectBinFolder.Parent.FullName + "\\Files\\SqlScript\\Northwind.sql";
        //    string northwindFile = File.ReadAllText(northwindScriptPath);
        //    //pattern mean: bir ya da daha fazla boşluk ile başlayan, GO içeren ve bir ya da daha fazla boşluk ile biten yerlerde böl.
        //    string[] northwindCommands = Regex.Split(northwindFile, @"\s*GO\s*", RegexOptions.Multiline | RegexOptions.IgnoreCase);
          
        //    SqlConnection connection = new SqlConnection(sqlConnBuilder("sql6005.site4now.net", "DB_A3E5AB_deneme_admin", "deneme1234", "DB_A3E5AB_deneme"));
        //    connection.Open();
        //    bool result = true;

        //    try
        //    {
        //        string firstCommand = "Create Database Northwind";
        //        new SqlCommand(firstCommand, connection).ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //        MessageBox.Show("Hata! Northwind veri tabanı oluşturulamadı. Exception Message: "+ex.Message);             
        //    }

        //    if (result)
        //    {
        //        foreach (string command in northwindCommands)
        //        {
        //            if (command.Trim() != "")
        //            {
        //                try
        //                {
        //                    new SqlCommand(command, connection).ExecuteNonQuery();
        //                }
        //                catch
        //                {
        //                    break;
        //                }
        //            }
        //        } 
        //    }         
        //    connection.Close();
        //}
    }
}
