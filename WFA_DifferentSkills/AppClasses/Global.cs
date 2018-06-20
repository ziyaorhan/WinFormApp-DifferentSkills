using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DifferentSkills.AppClasses
{
    public static class Global
    {
       // public static bool showForm = true;

       public static List<string> openForms=new List<string> ();

       // public static Dictionary<string, bool> openFormControl = new Dictionary<string,bool>();

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
    }
}
