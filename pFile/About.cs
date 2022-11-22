using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pFile
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(treeView1.SelectedNode.Name)
            {
                case "NewWindowNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.FileNewWindow;
                    break;
                case "ImportConfigNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.FileImportConfig;
                    break;
                case "DefaultConfigNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.FileSaveConfig;
                    break;
                case "ExitNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.FileExit;
                    break;
                case "PerformOpNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.EditPerformOp;
                    break;
                case "ResetDefaultStartupNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.EditResetDefaultStartup;
                    break;
                case "ClearFavsNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.EditClearFavorites;
                    break;
                case "OrientationNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.ViewOrientation;
                    break;
                case "AlwaysOnTopNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.ViewAlwaysTop;
                    break;
                case "AboutNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.HelpAbout;
                    break;
                case "OpenExplorerNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.OpenExplorer;
                    break;
                case "OpenTerminalNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.OpenTerminal;
                    break;
                case "DrivesNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Drives;
                    break;
                case "FavoritesNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Favorites;
                    break;
                case "CNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.C__;
                    break;
                case "UserNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.User;
                    break;
                case "BrowseNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Browse;
                    break;
                case "FavoriteNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Favorite;
                    break;
                case "GoNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Go;
                    break;
                case "BackNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.LeftBack;
                    break;
                case "ForwardNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.RightForward;
                    break;
                case "UpNode":
                    AbtDescription.Text = treeView1.SelectedNode.Text + "\n\n" + Properties.Resources.Up;
                    break;
            }
        }
    }
}
