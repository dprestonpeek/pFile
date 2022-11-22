
namespace pFile
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New Window");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Import Config");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Save Config as Default");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Exit");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("File", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Perform Operation");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Reset Default Startup Locations");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Clear Favorites");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Reset Config", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Edit", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Panel Orientation");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Always On Top");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("View", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("About");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Help", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Open in Explorer");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Open in Terminal");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Open", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Drives");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Favorites");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("C:/");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Browse");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Favorite");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Go");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("← (Back)");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("→ (Forward)");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("↑ (Parent Directory)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AbtDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "pFile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by D. Preston Peek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version 11.22.22";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbtDescription
            // 
            this.AbtDescription.AutoSize = true;
            this.AbtDescription.Location = new System.Drawing.Point(4, 8);
            this.AbtDescription.MaximumSize = new System.Drawing.Size(275, 95);
            this.AbtDescription.Name = "AbtDescription";
            this.AbtDescription.Size = new System.Drawing.Size(0, 13);
            this.AbtDescription.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AbtDescription);
            this.panel1.Location = new System.Drawing.Point(12, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 108);
            this.panel1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 114);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NewWindowNode";
            treeNode1.Text = "New Window";
            treeNode2.Name = "ImportConfigNode";
            treeNode2.Text = "Import Config";
            treeNode3.Name = "DefaultConfigNode";
            treeNode3.Text = "Save Config as Default";
            treeNode4.Name = "ExitNode";
            treeNode4.Text = "Exit";
            treeNode5.Name = "FileNode";
            treeNode5.Text = "File";
            treeNode6.Name = "PerformOpNode";
            treeNode6.Text = "Perform Operation";
            treeNode7.Name = "ResetDefaultStartupNode";
            treeNode7.Text = "Reset Default Startup Locations";
            treeNode8.Name = "ClearFavsNode";
            treeNode8.Text = "Clear Favorites";
            treeNode9.Name = "ResetConfigNode";
            treeNode9.Text = "Reset Config";
            treeNode10.Name = "EditNode";
            treeNode10.Text = "Edit";
            treeNode11.Name = "OrientationNode";
            treeNode11.Text = "Panel Orientation";
            treeNode12.Name = "AlwaysOnTopNode";
            treeNode12.Text = "Always On Top";
            treeNode13.Name = "ViewNode";
            treeNode13.Text = "View";
            treeNode14.Name = "AboutNode";
            treeNode14.Text = "About";
            treeNode15.Name = "HelpNode";
            treeNode15.Text = "Help";
            treeNode16.Name = "OpenExplorerNode";
            treeNode16.Text = "Open in Explorer";
            treeNode17.Name = "OpenTerminalNode";
            treeNode17.Text = "Open in Terminal";
            treeNode18.Name = "OpenNode";
            treeNode18.Text = "Open";
            treeNode19.Name = "DrivesNode";
            treeNode19.Text = "Drives";
            treeNode20.Name = "FavoritesNode";
            treeNode20.Text = "Favorites";
            treeNode21.Name = "CNode";
            treeNode21.Text = "C:/";
            treeNode22.Name = "UserNode";
            treeNode22.Text = "User";
            treeNode23.Name = "BrowseNode";
            treeNode23.Text = "Browse";
            treeNode24.Name = "FavoriteNode";
            treeNode24.Text = "Favorite";
            treeNode25.Name = "GoNode";
            treeNode25.Text = "Go";
            treeNode26.Name = "BackNode";
            treeNode26.Text = "← (Back)";
            treeNode27.Name = "ForwardNode";
            treeNode27.Text = "→ (Forward)";
            treeNode28.Name = "UpNode";
            treeNode28.Text = "↑ (Parent Directory)";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode13,
            treeNode15,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(279, 146);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select a feature to learn more";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AbtDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
    }
}