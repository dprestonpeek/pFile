using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pFile
{
    public partial class Form1 : Form
    {

        public Form1 Instance { get { return instance; } set { Instance = instance; } }
        private Form1 instance;
        string Url1 { get { return webBrowser1.Url.ToString().Substring(8); } set { Url1 = value; } }
        string Url2 { get { return webBrowser2.Url.ToString().Substring(8); } set { Url2 = value; } }

        public Form1()
        {
            InitializeComponent();
            instance = this;
            new Prefs();
            if (Prefs.Instance.InitializePrefsFile(Panel1Url.Text, Panel2Url.Text, false))
            {
                Panel1Url.Text = Prefs.Instance.preferences[0];
                Panel2Url.Text = Prefs.Instance.preferences[1];
                Go(webBrowser1, Panel1Url.Text);
                Go(webBrowser2, Panel2Url.Text);
            }
            GetDrives();
            GetFavorites();
            SetFavoritesButtonDisplayStyle();
            OrientationDropdown.SelectedIndex = 1;  //set to vertical split by default
            webBrowser1.CanGoBackChanged += EnablePanel1Back;
            webBrowser2.CanGoBackChanged += EnablePanel2Back;
            webBrowser1.CanGoForwardChanged += EnablePanel1Forward;
            webBrowser2.CanGoForwardChanged += EnablePanel2Forward;
            saveFileDialog1.FileOk += SaveFile;
            openFileDialog1.FileOk += ImportFile;
        }

        private void InitializeBrowsers()
        {
            //var th1 = new Thread(() => {
            //    WebBrowser temp = CopyBrowser(webBrowser1);
            //    //webBrowser1.Dispose();
            //    temp.TabIndex = 0;
            //    Browser1Panel.Controls.Add(temp);
            //    Application.Run();
            //});
            //th1.SetApartmentState(ApartmentState.STA);
            //th1.Start();

            //var th2 = new Thread(() => {
            //    WebBrowser temp = CopyBrowser(webBrowser2);
            //    //webBrowser2.Dispose();
            //    temp.TabIndex = 1;
            //    Browser1Panel.Controls.Add(webBrowser2);
            //    Application.Run();
            //});
            //th2.SetApartmentState(ApartmentState.STA);
            //th2.Start();
        }

        private WebBrowser CopyBrowser(WebBrowser toCopy)
        {
            WebBrowser temp = new WebBrowser();
            temp.Dock = toCopy.Dock;
            temp.Url = toCopy.Url;
            return temp;
        }

        private void GetDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                ToolStripItem newItem1 = Panel1Drives.DropDownItems.Add(drive.Name);
                newItem1.Click += Panel1NavigateTo;
                ToolStripItem newItem2 = Panel2Drives.DropDownItems.Add(drive.Name);
                newItem2.Click += Panel2NavigateTo;
            }
        }

        private void GetFavorites()
        {
            Prefs.Instance.favorites = new List<string>();

            bool tryagain = true;
            do
            {
                try
                {
                    List<string> prefs = File.ReadAllLines(Prefs.Instance.prefsFile).ToList();
                    string[] favs = prefs[0].Split(',');
                    if (!favs.Contains(""))
                    {
                        Prefs.Instance.favorites = favs.ToList();
                    }
                    tryagain = false;
                }
                catch (Exception ex)
                {
                    //try again
                }
            } while (tryagain);
            foreach (string fav in Prefs.Instance.favorites)
            {
                ToolStripItem newItem1 = Panel1Favorites.DropDownItems.Add(fav);
                newItem1.Click += Panel1NavigateTo;
                ToolStripItem newItem2 = Panel2Favorites.DropDownItems.Add(fav);
                newItem2.Click += Panel2NavigateTo;
            }
        }

        private void Panel1NavigateTo(object sender, EventArgs e)
        {
            ToolStripItem theSender = (ToolStripItem)sender;
            string url = theSender.AccessibilityObject.Name;
            webBrowser1.Url = new Uri(url);
        }

        private void Panel2NavigateTo(object sender, EventArgs e)
        {
            ToolStripItem theSender = (ToolStripItem)sender;
            string url = theSender.AccessibilityObject.Name;
            webBrowser2.Url = new Uri(url);
        }

        private void Panel1ThisPC_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:\\");
        }

        private void Panel2ThisPC_Click(object sender, EventArgs e)
        {
            webBrowser2.Url = new Uri("C:\\");
        }

        private void Panel1User_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:\\Users\\" + Environment.UserName);
        }

        private void Panel2User_Click(object sender, EventArgs e)
        {
            webBrowser2.Url = new Uri("C:\\Users\\" + Environment.UserName);
        }

        private void Panel1Back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void Panel2Back_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void Panel1Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Panel2Forward_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Panel1Url.Text = Url1;
            SetFavoritesButtonDisplayStyle();
        }

        private void webBrowser2_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Panel2Url.Text = Url2;
            SetFavoritesButtonDisplayStyle();
        }

        private void EnablePanel1Back(object sender, EventArgs e)
        {
            Panel1Back.Enabled = webBrowser1.CanGoBack;
        }

        private void EnablePanel2Back(object sender, EventArgs e)
        {
            Panel2Back.Enabled = webBrowser2.CanGoBack;
        }

        private void EnablePanel1Forward(object sender, EventArgs e)
        {
            Panel1Forward.Enabled = webBrowser1.CanGoForward;
        }

        private void EnablePanel2Forward(object sender, EventArgs e)
        {
            Panel2Forward.Enabled = webBrowser2.CanGoForward;
        }

        private void Panel1Browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
            {
                webBrowser1.Url = new Uri(folderBrowserDialog1.SelectedPath);
            }
        }

        private void Panel2Browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
            {
                webBrowser2.Url = new Uri(folderBrowserDialog1.SelectedPath);
            }
        }

        private void Panel1Go_Click(object sender, EventArgs e)
        {
            Go(webBrowser1, Panel1Url.Text);
        }

        private void Panel2Go_Click(object sender, EventArgs e)
        {
            Go(webBrowser2, Panel2Url.Text);
        }

        private void Go(WebBrowser browser, string url)
        {
            if (Directory.Exists(url))
                browser.Url = new Uri(url);
        }

        private void Panel1Up_Click(object sender, EventArgs e)
        {
            string url = Directory.GetParent(Url1).FullName;
            webBrowser1.Url = new Uri(url);
        }

        private void Panel2Up_Click(object sender, EventArgs e)
        {
            string url = Directory.GetParent(Url2).FullName;
            webBrowser2.Url = new Uri(url);
        }

        private void Panel1Explorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", webBrowser1.Url.ToString());
        }

        private void Panel2Explorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", webBrowser2.Url.ToString());
        }

        private void Panel1Terminal_Click(object sender, EventArgs e)
        {
            string command = "/k cd " + webBrowser1.Url.AbsoluteUri.Substring(8);
            Process.Start("cmd.exe", command);
        }

        private void Panel2Terminal_Click(object sender, EventArgs e)
        {
            string command = "/k cd " + webBrowser2.Url.AbsoluteUri.Substring(8);
            Process.Start("cmd.exe", command);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prefs.Instance.preferences.Clear();
            Prefs.Instance.preferences.Add(Url1);
            Prefs.Instance.preferences.Add(Url2);
            Prefs.Instance.WritePrefsFile();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            string[] urls = new string[2] { Url1, Url2 };
            File.WriteAllLines(saveFileDialog1.FileName, urls);
        }

        private void openSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void ImportFile(object sender, EventArgs e)
        {
            if (Path.GetExtension(openFileDialog1.FileName) != ".prefs")
            {
                return;
            }
            Prefs.Instance.ImportPrefsFile(openFileDialog1.FileName);
            webBrowser1.Url = new Uri(Prefs.Instance.preferences[0]);
            webBrowser2.Url = new Uri(Prefs.Instance.preferences[1]);
        }

        private void Panel1Favorite_Click(object sender, EventArgs e)
        {
            if (Panel1Favorite.FlatStyle == FlatStyle.Flat)
            {
                RemoveFavorite(Url1);
            }
            else
            {
                AddFavorite(Url1);
            }
        }

        private void Panel2Favorite_Click(object sender, EventArgs e)
        {
            if (Panel2Favorite.FlatStyle == FlatStyle.Flat)
            {
                RemoveFavorite(Url2);
            }
            else
            {
                AddFavorite(Url2);
            }
        }

        private void SetFavoritesButtonDisplayStyle()
        {
            if (Prefs.Instance.favorites.Contains(Url1))
            {
                Panel1Favorite.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                Panel1Favorite.FlatStyle = FlatStyle.Standard;
            }

            if (Prefs.Instance.favorites.Contains(Url2))
            {
                Panel2Favorite.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                Panel2Favorite.FlatStyle = FlatStyle.Standard;
            }
        }

        private void AddFavorite(string url)
        {
            Prefs.Instance.favorites.Add(url);
            ToolStripItem newItem1 = Panel1Favorites.DropDownItems.Add(url);
            newItem1.Click += Panel1NavigateTo;
            ToolStripItem newItem2 = Panel2Favorites.DropDownItems.Add(url);
            newItem2.Click += Panel2NavigateTo;
            SetFavoritesButtonDisplayStyle();
            Prefs.Instance.WritePrefsFile();
        }

        private void RemoveFavorite(string url)
        {
            int index = Prefs.Instance.favorites.IndexOf(url);
            Prefs.Instance.favorites.Remove(url);
            Panel1Favorites.DropDownItems.RemoveAt(index);
            Panel2Favorites.DropDownItems.RemoveAt(index);
            SetFavoritesButtonDisplayStyle();
            Prefs.Instance.WritePrefsFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void performOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(Panel1Url.Text, Panel2Url.Text);
            operation.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("pFile.exe");
        }

        private void OrientationDropdown_DropDownClosed(object sender, EventArgs e)
        {
            splitContainer1.Orientation = (Orientation)OrientationDropdown.SelectedIndex;
            if (splitContainer1.Orientation == Orientation.Vertical)
            {
                splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            }
            else
            {
                splitContainer1.SplitterDistance = splitContainer1.Height / 2;
            }
        }

        private void resetToDefaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prefs.Instance.preferences.Clear();
            Prefs.Instance.InitializePrefsFile("C:/", "C:/Users", true);
            Panel1Url.Text = Prefs.Instance.preferences[0];
            Panel2Url.Text = Prefs.Instance.preferences[1];
            Go(webBrowser1, Panel1Url.Text);
            Go(webBrowser2, Panel2Url.Text);
        }

        private void clearFavoritesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Prefs.Instance.favorites.Count > 0)
            {
                RemoveFavorite(Prefs.Instance.favorites[0]);
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("pFileUpdateRepair.exe");
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
