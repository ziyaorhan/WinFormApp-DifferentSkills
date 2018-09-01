using System;
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
            string descriptionFolderPath = Global.GetPath("\\Files\\Descriptions");
            string descriptionFileUrl = descriptionFolderPath + "\\" + htmlFileName;
            wb.Url = new Uri(descriptionFileUrl);
        }
        /// <summary>
        /// This method converts serialize data to deserialize.
        /// </summary>
        /// <typeparam name="T">This type parameter represent a model or generic list and return them.</typeparam>
        /// <param name="webUrl">This parameter represent the way of serialize json data</param>
        /// <returns></returns>
        public static T GetDeserializeJson<T>(string webUrl) where T : new()
        {
            using (var w = new WebClient())
            {
                var jsonData = string.Empty;

                try
                {
                    var webRequest = WebRequest.Create(webUrl) as HttpWebRequest;
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
        /// <summary>
        /// this method returns the file or folder path
        /// </summary>
        /// <param name="subPath">this parameter represent a file or folder path in the project folder </param>
        /// <returns></returns>
        public static string GetPath(string subPath )
        {
            DirectoryInfo projectBinFolder = Directory.GetParent(Application.StartupPath);
            string projectFolderName = projectBinFolder.Parent.FullName;
            string returnPath = projectFolderName + subPath;
            return returnPath;
        }    
    }
}
