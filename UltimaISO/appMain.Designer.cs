namespace UltimaISO
{
    partial class appMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appMain));
            menuStrip1 = new MenuStrip();
            fileCtxMenuToolStripMenuItem = new ToolStripMenuItem();
            newImageBtnToolStripMenuItem = new ToolStripMenuItem();
            openImageBtnToolStripMenuItem = new ToolStripMenuItem();
            openDiscImageisoToolStripMenuItem = new ToolStripMenuItem();
            saveImageBtnToolStripMenuItem = new ToolStripMenuItem();
            saveImageAsBtnToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imagePropertiesBtnToolStripMenuItem = new ToolStripMenuItem();
            exitBtnToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            iIcons = new ImageList(components);
            openIso = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            bUpOneFolder = new ToolStripButton();
            tCurrentDir = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileCtxMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileCtxMenuToolStripMenuItem
            // 
            fileCtxMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newImageBtnToolStripMenuItem, openImageBtnToolStripMenuItem, saveImageBtnToolStripMenuItem, saveImageAsBtnToolStripMenuItem, toolStripSeparator1, imagePropertiesBtnToolStripMenuItem, exitBtnToolStripMenuItem });
            fileCtxMenuToolStripMenuItem.Name = "fileCtxMenuToolStripMenuItem";
            fileCtxMenuToolStripMenuItem.Size = new Size(102, 24);
            fileCtxMenuToolStripMenuItem.Text = "fileCtxMenu";
            // 
            // newImageBtnToolStripMenuItem
            // 
            newImageBtnToolStripMenuItem.Name = "newImageBtnToolStripMenuItem";
            newImageBtnToolStripMenuItem.Size = new Size(223, 26);
            newImageBtnToolStripMenuItem.Text = "newImageBtn";
            newImageBtnToolStripMenuItem.Click += newImageBtnToolStripMenuItem_Click;
            // 
            // openImageBtnToolStripMenuItem
            // 
            openImageBtnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDiscImageisoToolStripMenuItem });
            openImageBtnToolStripMenuItem.Name = "openImageBtnToolStripMenuItem";
            openImageBtnToolStripMenuItem.Size = new Size(223, 26);
            openImageBtnToolStripMenuItem.Text = "openImageBtn";
            // 
            // openDiscImageisoToolStripMenuItem
            // 
            openDiscImageisoToolStripMenuItem.Name = "openDiscImageisoToolStripMenuItem";
            openDiscImageisoToolStripMenuItem.Size = new Size(248, 26);
            openDiscImageisoToolStripMenuItem.Text = "Open Disc Image (*.iso)";
            openDiscImageisoToolStripMenuItem.Click += openDiscImageisoToolStripMenuItem_Click;
            // 
            // saveImageBtnToolStripMenuItem
            // 
            saveImageBtnToolStripMenuItem.Name = "saveImageBtnToolStripMenuItem";
            saveImageBtnToolStripMenuItem.Size = new Size(223, 26);
            saveImageBtnToolStripMenuItem.Text = "saveImageBtn";
            // 
            // saveImageAsBtnToolStripMenuItem
            // 
            saveImageAsBtnToolStripMenuItem.Name = "saveImageAsBtnToolStripMenuItem";
            saveImageAsBtnToolStripMenuItem.Size = new Size(223, 26);
            saveImageAsBtnToolStripMenuItem.Text = "saveImageAsBtn";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(220, 6);
            // 
            // imagePropertiesBtnToolStripMenuItem
            // 
            imagePropertiesBtnToolStripMenuItem.Name = "imagePropertiesBtnToolStripMenuItem";
            imagePropertiesBtnToolStripMenuItem.Size = new Size(223, 26);
            imagePropertiesBtnToolStripMenuItem.Text = "imagePropertiesBtn";
            // 
            // exitBtnToolStripMenuItem
            // 
            exitBtnToolStripMenuItem.Name = "exitBtnToolStripMenuItem";
            exitBtnToolStripMenuItem.Size = new Size(223, 26);
            exitBtnToolStripMenuItem.Text = "exitBtn";
            exitBtnToolStripMenuItem.Click += exitBtnToolStripMenuItem_Click;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = iIcons;
            listView1.Location = new Point(0, 57);
            listView1.Name = "listView1";
            listView1.Size = new Size(914, 543);
            listView1.StateImageList = iIcons;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.MouseDoubleClick += listView1_DoubleClick;
            // 
            // iIcons
            // 
            iIcons.ColorDepth = ColorDepth.Depth32Bit;
            iIcons.ImageStream = (ImageListStreamer)resources.GetObject("iIcons.ImageStream");
            iIcons.TransparentColor = Color.Transparent;
            iIcons.Images.SetKeyName(0, "shell32.dll_14_4.ico");
            iIcons.Images.SetKeyName(1, "shell32.dll_14_1.ico");
            // 
            // openIso
            // 
            openIso.Filter = "ISO Disk Image|*.iso";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { bUpOneFolder, tCurrentDir });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // bUpOneFolder
            // 
            bUpOneFolder.Image = (Image)resources.GetObject("bUpOneFolder.Image");
            bUpOneFolder.ImageTransparentColor = Color.Magenta;
            bUpOneFolder.Name = "bUpOneFolder";
            bUpOneFolder.Size = new Size(64, 24);
            bUpOneFolder.Text = "Back";
            bUpOneFolder.Click += bUpOneFolder_Click;
            // 
            // tCurrentDir
            // 
            tCurrentDir.Name = "tCurrentDir";
            tCurrentDir.Size = new Size(500, 27);
            // 
            // appMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "appMain";
            Text = "appTitle";
            Load += appMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileCtxMenuToolStripMenuItem;
        private ToolStripMenuItem newImageBtnToolStripMenuItem;
        private ToolStripMenuItem openImageBtnToolStripMenuItem;
        private ToolStripMenuItem saveImageBtnToolStripMenuItem;
        private ToolStripMenuItem saveImageAsBtnToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imagePropertiesBtnToolStripMenuItem;
        private ToolStripMenuItem exitBtnToolStripMenuItem;
        private ListView listView1;
        private ToolStripMenuItem openDiscImageisoToolStripMenuItem;
        private OpenFileDialog openIso;
        private ImageList iIcons;
        private ToolStrip toolStrip1;
        private ToolStripButton bUpOneFolder;
        private ToolStripTextBox tCurrentDir;
    }
}
