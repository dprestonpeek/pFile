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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pFile
{
    public partial class Form1 : Form
    {
        string Url1 { get { return webBrowser1.Url.ToString().Substring(8); } set { Url1 = value; } }
        string Url2 { get { return webBrowser2.Url.ToString().Substring(8); } set { Url2 = value; } }

        public ResourceManager ResManager { get; private set; }

        List<string> favorites;
        string favoritesFile = "../pFileFavorites.txt";

        public Form1()
        {
            InitializeComponent();
            GetDrives();
            GetFavorites();
            Panel1Url.Text = Url1;
            Panel2Url.Text = Url2;
            webBrowser1.CanGoBackChanged += EnablePanel1Back;
            webBrowser2.CanGoBackChanged += EnablePanel2Back;
            webBrowser1.CanGoForwardChanged += EnablePanel1Forward;
            webBrowser2.CanGoForwardChanged += EnablePanel2Forward;
            saveFileDialog1.FileOk += SaveFile;
            openFileDialog1.FileOk += OpenFile;
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
            favorites = new List<String>();
            if (!File.Exists(favoritesFile))
            {
                File.Create(favoritesFile);
                favorites.Add(Panel1Url.Text);
                favorites.Add(Panel2Url.Text);
                File.WriteAllLines(favoritesFile, favorites);
            }
            favorites = File.ReadAllLines(favoritesFile).ToList();
            foreach (string fav in favorites)
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
            if (Directory.Exists(Panel1Url.Text))
                webBrowser1.Url = new Uri(Panel1Url.Text);
        }

        private void Panel2Go_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Panel2Url.Text))
                webBrowser2.Url = new Uri(Panel2Url.Text);
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
            saveFileDialog1.ShowDialog();
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

        private void OpenFile(object sender, EventArgs e)
        {
            string[] urls = File.ReadAllLines(openFileDialog1.FileName);
            webBrowser1.Url = new Uri(urls[0]);
            webBrowser2.Url = new Uri(urls[1]);
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
            if (favorites.Contains(Url1))
            {
                Panel1Favorite.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                Panel1Favorite.FlatStyle = FlatStyle.Standard;
            }

            if (favorites.Contains(Url2))
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
            favorites.Add(url);
            File.WriteAllLines(favoritesFile, favorites);

            ToolStripItem newItem1 = Panel1Favorites.DropDownItems.Add(url);
            newItem1.Click += Panel1NavigateTo;
            ToolStripItem newItem2 = Panel2Favorites.DropDownItems.Add(url);
            newItem2.Click += Panel2NavigateTo;
            SetFavoritesButtonDisplayStyle();
        }

        private void RemoveFavorite(string url)
        {
            int index = favorites.IndexOf(url);
            favorites.Remove(url);
            File.WriteAllLines(favoritesFile, favorites);
            Panel1Favorites.DropDownItems.RemoveAt(index);
            Panel2Favorites.DropDownItems.RemoveAt(index);
            SetFavoritesButtonDisplayStyle();
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
    }
}
