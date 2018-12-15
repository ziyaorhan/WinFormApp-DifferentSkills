using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_DifferentSkills.AppClasses;
using HtmlAgilityPack;
using System.Net;

namespace WFA_DifferentSkills.AppForms
{
    public partial class frmHtmlParse : Form
    {
        public frmHtmlParse(frmMain parent)
        {
            InitializeComponent();
            //for initial
            this.MdiParent = parent;
            this.Text = "HTML PARSE";
            Global.WebBrowserFill("frmHtmlParse.html", this.wbDescription);
        }

        #region initial methods
        private void frmHtmlParse_Load(object sender, EventArgs e)
        {
            if (Validation.IsOpenForm(this))
                this.Close();
        }

        private void frmHtmlParse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.wbMainVisibility = true;
            Global.openForms.Remove(this.Name.ToString());
        }
        #endregion

        public HtmlAgilityPack.HtmlDocument GetHtmlDocument(string accountName)
        {
            HtmlAgilityPack.HtmlDocument returnValue;
            try
            {
                Uri url = new Uri("https://twitter.com/" + accountName);
                WebClient client = new WebClient();
                string html = client.DownloadString(url); // download html code.
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(html); // HtmlDocument object
                returnValue = document;
            }
            catch (Exception ex)
            {
                returnValue = null;
                MessageBox.Show("There was a problem during the connection." + Environment.NewLine + "Exception: " + ex.Message);
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel1.BackColor = SystemColors.Control;
            }
            return returnValue;
        }

        public string TrimeIfNotNull(string property)
        {
            if (property != null)
            {
                return property.Trim();
            }
            else
            {
                return property;
            }
        }

        public string ConvertToUtf8(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            string utf8String = Encoding.UTF8.GetString(bytes);
            return utf8String;
        }

        private string twitterAccountName = "verimetrik";

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (twitterAccountName != String.Empty)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    toolStripStatusLabel1.Text = "Please wait...";
                    toolStripStatusLabel1.BackColor = Color.LightBlue;
                    HtmlAgilityPack.HtmlDocument document = GetHtmlDocument(twitterAccountName);
                    if (document != null)
                    {
                        TwitterHtmlParse newAccount = new TwitterHtmlParse(document);
                        pbPicture.Load(newAccount.PictureUrl);
                        lblName.Text = ConvertToUtf8(TrimeIfNotNull(newAccount.Name));
                        lblLocation.Text = ConvertToUtf8(TrimeIfNotNull(newAccount.Location));
                        lblLink.Text = TrimeIfNotNull(newAccount.Link);
                        lblTweets.Text = newAccount.Tweets;
                        lblFollowers.Text = newAccount.Followers;
                        lblFollowing.Text = newAccount.Following;
                        lblLike.Text = newAccount.Like;
                        string htmlBody = "<!DOCTYPE html><html><head><style>body {font-family:verdana;}h2 {color: gray;}p {color:black;font-size:14px;border:1px dotted gray;padding: 5px;}</style></head><body><h2>";
                        htmlBody += TrimeIfNotNull(newAccount.Name);
                        htmlBody += "-Tweets</h2>";
                        foreach (string content in newAccount.TweetContent)
                        {
                            htmlBody += "<p>" + content + "</p>";
                        }
                        htmlBody += "</body></html>";
                        wbTweets.DocumentText = htmlBody;
                        Cursor.Current = Cursors.Default;
                        toolStripStatusLabel1.Text = "Success :)";
                        toolStripStatusLabel1.BackColor = Color.LightGreen;
                    }
                }
                else
                {
                    MessageBox.Show("Warning! Please enter a username.");
                }
            }
            catch (Exception)
            {
               //MessageBox.Show("There was a problem." + Environment.NewLine + "Exception: " + ex.Message);
                toolStripStatusLabel1.Text = "An unexpected error has occurred. please try again!";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            twitterAccountName = txtSearch.Text;
            if (twitterAccountName.Length != 0)
            {
                char enteredChar = Convert.ToChar(twitterAccountName.Substring(twitterAccountName.Length - 1));

                if (!Char.IsLetterOrDigit(enteredChar))
                {
                    txtSearch.BackColor = Color.Red;
                }
                else
                {
                    txtSearch.BackColor = Color.White;
                }
            }
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.BackColor = SystemColors.Control;
        }
    }

    public class TwitterHtmlParse
    {
        public TwitterHtmlParse(HtmlAgilityPack.HtmlDocument document)
        {
            //PictureUrl
            HtmlNode nodeForPicture = document.DocumentNode.SelectSingleNode("//a[@class='ProfileAvatar-container u-block js-tooltip profile-picture']");
            if (nodeForPicture != null)
            {
                PictureUrl = nodeForPicture.Attributes["data-url"].Value.ToString();
            }

            //Name
            HtmlNode nodeForName = document.DocumentNode.SelectSingleNode("//a[@class='ProfileHeaderCard-nameLink u-textInheritColor js-nav']");
            if (nodeForName != null)
            {
                Name = nodeForName.InnerText.ToString();
            }

            //Location
            HtmlNode nodeForLocation = document.DocumentNode.SelectSingleNode("//div[@class='ProfileHeaderCard-location ']");
            if (nodeForLocation != null)
            {
                HtmlNodeCollection childNodesForeLocations = nodeForLocation.ChildNodes;
                foreach (var node in childNodesForeLocations)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        if (node.Attributes["class"].Value.ToString() == "ProfileHeaderCard-locationText u-dir")
                        {
                            HtmlNode a = node.ChildNodes["a"];
                            if (a != null)
                            {
                                Location = a.InnerText;
                            }
                            String text = node.InnerText;
                            Location = text;
                        }
                    }
                }
            }

            //Link 
            HtmlNode nodeForLink = document.DocumentNode.SelectSingleNode("//div[@class='ProfileHeaderCard-url ']");
            if (nodeForLink != null)
            {
                HtmlNodeCollection childNodesForeLink = nodeForLink.ChildNodes;
                foreach (var node in childNodesForeLink)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        if (node.Attributes["class"].Value.ToString() == "ProfileHeaderCard-urlText u-dir")
                        {
                            Link = node.Element("a").Attributes["title"].Value.ToString();
                        }
                    }
                }
            }

            //
            HtmlNode nodeForProfileNavList = document.DocumentNode.SelectSingleNode("//ul[@class='ProfileNav-list']");
            string xPathForProfileNavList = nodeForProfileNavList.XPath;

            //Tweets
            HtmlNode nodeForTweets = nodeForProfileNavList.SelectSingleNode(xPathForProfileNavList + "/li[@class='ProfileNav-item ProfileNav-item--tweets is-active']/a[1]/span[3]");
            if (nodeForTweets != null)
                Tweets = nodeForTweets.Attributes["data-count"].Value.ToString();

            //Following
            HtmlNode nodeForFollowing = nodeForProfileNavList.SelectSingleNode(xPathForProfileNavList + "/li[@class='ProfileNav-item ProfileNav-item--following']/a[1]/span[3]");
            if (nodeForFollowing != null)
                Following = nodeForFollowing.Attributes["data-count"].Value.ToString();

            //Followers
            HtmlNode nodeForFollowers = nodeForProfileNavList.SelectSingleNode(xPathForProfileNavList + "/li[@class='ProfileNav-item ProfileNav-item--followers']/a[1]/span[3]");
            if (nodeForFollowers != null)
                Followers = nodeForFollowers.Attributes["data-count"].Value.ToString();

            //Like
            HtmlNode nodeForLike = nodeForProfileNavList.SelectSingleNode(xPathForProfileNavList + "/li[@class='ProfileNav-item ProfileNav-item--favorites']/a[1]/span[3]");
            if (nodeForLike != null)
                Like = nodeForLike.Attributes["data-count"].Value.ToString();

            //TweetContent
            HtmlNodeCollection nodsForContent = document.DocumentNode.SelectNodes("//div[@class='js-tweet-text-container']/p[1]");
            List<string> utf8Contents = new List<string>();
            foreach (HtmlNode node in nodsForContent)
            {
                string htmlContent = node.InnerHtml.ToString();
                byte[] bytes = Encoding.Default.GetBytes(htmlContent);
                string utf8String = Encoding.UTF8.GetString(bytes);
                utf8Contents.Add(utf8String);
            }
            TweetContent = utf8Contents;
        }
        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public string Tweets { get; set; }
        public string Following { get; set; }
        public string Followers { get; set; }
        public string Like { get; set; }
        public List<string> TweetContent { get; set; }
    }
}
