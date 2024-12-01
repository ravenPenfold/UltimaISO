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
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutUltimaISOToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            iIcons = new ImageList(components);
            openIso = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            bUpOneFolder = new ToolStripButton();
            tCurrentDir = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            pBar = new ToolStripProgressBar();
            lStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileCtxMenuToolStripMenuItem, helpToolStripMenuItem, debugToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileCtxMenuToolStripMenuItem
            // 
            fileCtxMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newImageBtnToolStripMenuItem, openImageBtnToolStripMenuItem, saveImageBtnToolStripMenuItem, saveImageAsBtnToolStripMenuItem, toolStripSeparator1, imagePropertiesBtnToolStripMenuItem, exitBtnToolStripMenuItem });
            fileCtxMenuToolStripMenuItem.Name = "fileCtxMenuToolStripMenuItem";
            fileCtxMenuToolStripMenuItem.Size = new Size(83, 20);
            fileCtxMenuToolStripMenuItem.Text = "fileCtxMenu";
            // 
            // newImageBtnToolStripMenuItem
            // 
            newImageBtnToolStripMenuItem.Name = "newImageBtnToolStripMenuItem";
            newImageBtnToolStripMenuItem.Size = new Size(178, 22);
            newImageBtnToolStripMenuItem.Text = "newImageBtn";
            newImageBtnToolStripMenuItem.Click += newImageBtnToolStripMenuItem_Click;
            // 
            // openImageBtnToolStripMenuItem
            // 
            openImageBtnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDiscImageisoToolStripMenuItem });
            openImageBtnToolStripMenuItem.Name = "openImageBtnToolStripMenuItem";
            openImageBtnToolStripMenuItem.Size = new Size(178, 22);
            openImageBtnToolStripMenuItem.Text = "openImageBtn";
            // 
            // openDiscImageisoToolStripMenuItem
            // 
            openDiscImageisoToolStripMenuItem.Name = "openDiscImageisoToolStripMenuItem";
            openDiscImageisoToolStripMenuItem.Size = new Size(198, 22);
            openDiscImageisoToolStripMenuItem.Text = "Open Disc Image (*.iso)";
            openDiscImageisoToolStripMenuItem.Click += openDiscImageisoToolStripMenuItem_Click;
            // 
            // saveImageBtnToolStripMenuItem
            // 
            saveImageBtnToolStripMenuItem.Name = "saveImageBtnToolStripMenuItem";
            saveImageBtnToolStripMenuItem.Size = new Size(178, 22);
            saveImageBtnToolStripMenuItem.Text = "saveImageBtn";
            // 
            // saveImageAsBtnToolStripMenuItem
            // 
            saveImageAsBtnToolStripMenuItem.Name = "saveImageAsBtnToolStripMenuItem";
            saveImageAsBtnToolStripMenuItem.Size = new Size(178, 22);
            saveImageAsBtnToolStripMenuItem.Text = "saveImageAsBtn";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(175, 6);
            // 
            // imagePropertiesBtnToolStripMenuItem
            // 
            imagePropertiesBtnToolStripMenuItem.Name = "imagePropertiesBtnToolStripMenuItem";
            imagePropertiesBtnToolStripMenuItem.Size = new Size(178, 22);
            imagePropertiesBtnToolStripMenuItem.Text = "imagePropertiesBtn";
            // 
            // exitBtnToolStripMenuItem
            // 
            exitBtnToolStripMenuItem.Name = "exitBtnToolStripMenuItem";
            exitBtnToolStripMenuItem.Size = new Size(178, 22);
            exitBtnToolStripMenuItem.Text = "exitBtn";
            exitBtnToolStripMenuItem.Click += exitBtnToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUltimaISOToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUltimaISOToolStripMenuItem
            // 
            aboutUltimaISOToolStripMenuItem.Name = "aboutUltimaISOToolStripMenuItem";
            aboutUltimaISOToolStripMenuItem.Size = new Size(163, 22);
            aboutUltimaISOToolStripMenuItem.Text = "About UltimaISO";
            aboutUltimaISOToolStripMenuItem.Click += aboutUltimaISOToolStripMenuItem_Click;
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new Size(54, 20);
            debugToolStripMenuItem.Text = "Debug";
            debugToolStripMenuItem.Click += debugToolStripMenuItem_Click;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = iIcons;
            listView1.Location = new Point(0, 51);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 377);
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
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // bUpOneFolder
            // 
            bUpOneFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bUpOneFolder.Image = (Image)resources.GetObject("bUpOneFolder.Image");
            bUpOneFolder.ImageTransparentColor = Color.Magenta;
            bUpOneFolder.Name = "bUpOneFolder";
            bUpOneFolder.Size = new Size(24, 24);
            bUpOneFolder.Text = "Up One Folder";
            bUpOneFolder.Click += bUpOneFolder_Click;
            // 
            // tCurrentDir
            // 
            tCurrentDir.Name = "tCurrentDir";
            tCurrentDir.Size = new Size(438, 27);
            tCurrentDir.KeyDown += tCurrentDir_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { pBar, lStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // pBar
            // 
            pBar.Name = "pBar";
            pBar.Size = new Size(88, 16);
            // 
            // lStatus
            // 
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(118, 17);
            lStatus.Text = "toolStripStatusLabel1";
            // 
            // appMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "appMain";
            Text = "appTitle";
            Load += appMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lStatus;
        private ToolStripProgressBar pBar;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUltimaISOToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
    }
}
