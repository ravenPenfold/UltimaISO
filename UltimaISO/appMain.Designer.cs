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
            listView1 = new ListView();
            iIcons = new ImageList(components);
            pMain = new Panel();
            tUrl = new TextBox();
            bMenu = new Button();
            iGuiSmall = new ImageList(components);
            pMenu = new Panel();
            lBuild = new LinkLabel();
            pMenuBottom = new Panel();
            bExit = new Button();
            bSettings = new Button();
            bAbout = new Button();
            bImageProperties = new Button();
            bSaveImageAs = new Button();
            bSaveImage = new Button();
            bOpenImage = new Button();
            bNewImage = new Button();
            tTip = new ToolTip(components);
            pMain.SuspendLayout();
            pMenu.SuspendLayout();
            pMenuBottom.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = iIcons;
            listView1.Location = new Point(0, 100);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(503, 399);
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
            // pMain
            // 
            pMain.BackColor = Color.FromArgb(128, 128, 255);
            pMain.Controls.Add(tUrl);
            pMain.Controls.Add(bMenu);
            pMain.Dock = DockStyle.Top;
            pMain.Location = new Point(0, 0);
            pMain.Name = "pMain";
            pMain.Size = new Size(800, 100);
            pMain.TabIndex = 2;
            // 
            // tUrl
            // 
            tUrl.BackColor = SystemColors.Window;
            tUrl.BorderStyle = BorderStyle.FixedSingle;
            tUrl.Location = new Point(3, 3);
            tUrl.Name = "tUrl";
            tUrl.Size = new Size(701, 23);
            tUrl.TabIndex = 4;
            // 
            // bMenu
            // 
            bMenu.BackColor = Color.FromArgb(128, 128, 255);
            bMenu.Dock = DockStyle.Right;
            bMenu.FlatAppearance.BorderSize = 0;
            bMenu.FlatStyle = FlatStyle.Flat;
            bMenu.ImageIndex = 0;
            bMenu.ImageList = iGuiSmall;
            bMenu.Location = new Point(710, 0);
            bMenu.Name = "bMenu";
            bMenu.Size = new Size(90, 100);
            bMenu.TabIndex = 0;
            bMenu.UseVisualStyleBackColor = false;
            bMenu.Click += bMenu_Click;
            bMenu.MouseHover += bMenu_MouseHover;
            // 
            // iGuiSmall
            // 
            iGuiSmall.ColorDepth = ColorDepth.Depth32Bit;
            iGuiSmall.ImageStream = (ImageListStreamer)resources.GetObject("iGuiSmall.ImageStream");
            iGuiSmall.TransparentColor = Color.Transparent;
            iGuiSmall.Images.SetKeyName(0, "menu_32dp_E8EAED.png");
            iGuiSmall.Images.SetKeyName(1, "info_32dp_E8EAED.png");
            iGuiSmall.Images.SetKeyName(2, "logout_32dp_E8EAED.png");
            iGuiSmall.Images.SetKeyName(3, "settings_32dp_E8EAED.png");
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(128, 128, 255);
            pMenu.Controls.Add(lBuild);
            pMenu.Controls.Add(pMenuBottom);
            pMenu.Controls.Add(bImageProperties);
            pMenu.Controls.Add(bSaveImageAs);
            pMenu.Controls.Add(bSaveImage);
            pMenu.Controls.Add(bOpenImage);
            pMenu.Controls.Add(bNewImage);
            pMenu.Dock = DockStyle.Right;
            pMenu.Location = new Point(503, 100);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(297, 399);
            pMenu.TabIndex = 3;
            pMenu.Visible = false;
            // 
            // lBuild
            // 
            lBuild.AutoSize = true;
            lBuild.Dock = DockStyle.Bottom;
            lBuild.Location = new Point(0, 284);
            lBuild.Name = "lBuild";
            lBuild.Size = new Size(37, 15);
            lBuild.TabIndex = 4;
            lBuild.TabStop = true;
            lBuild.Text = "lBuild";
            lBuild.Visible = false;
            lBuild.LinkClicked += lBuild_LinkClicked;
            // 
            // pMenuBottom
            // 
            pMenuBottom.Controls.Add(bExit);
            pMenuBottom.Controls.Add(bSettings);
            pMenuBottom.Controls.Add(bAbout);
            pMenuBottom.Dock = DockStyle.Bottom;
            pMenuBottom.Location = new Point(0, 299);
            pMenuBottom.Name = "pMenuBottom";
            pMenuBottom.Size = new Size(297, 100);
            pMenuBottom.TabIndex = 6;
            // 
            // bExit
            // 
            bExit.BackColor = Color.FromArgb(128, 128, 255);
            bExit.Dock = DockStyle.Left;
            bExit.FlatAppearance.BorderSize = 0;
            bExit.FlatStyle = FlatStyle.Flat;
            bExit.Font = new Font("Segoe UI", 12F);
            bExit.ImageKey = "logout_32dp_E8EAED.png";
            bExit.ImageList = iGuiSmall;
            bExit.Location = new Point(196, 0);
            bExit.Name = "bExit";
            bExit.Size = new Size(98, 100);
            bExit.TabIndex = 4;
            bExit.TextAlign = ContentAlignment.MiddleRight;
            bExit.UseVisualStyleBackColor = false;
            bExit.Click += bExit_Click;
            // 
            // bSettings
            // 
            bSettings.BackColor = Color.FromArgb(128, 128, 255);
            bSettings.Dock = DockStyle.Left;
            bSettings.FlatAppearance.BorderSize = 0;
            bSettings.FlatStyle = FlatStyle.Flat;
            bSettings.Font = new Font("Segoe UI", 12F);
            bSettings.ImageKey = "settings_32dp_E8EAED.png";
            bSettings.ImageList = iGuiSmall;
            bSettings.Location = new Point(98, 0);
            bSettings.Name = "bSettings";
            bSettings.Size = new Size(98, 100);
            bSettings.TabIndex = 3;
            bSettings.TextAlign = ContentAlignment.MiddleRight;
            bSettings.UseVisualStyleBackColor = false;
            // 
            // bAbout
            // 
            bAbout.BackColor = Color.FromArgb(128, 128, 255);
            bAbout.Dock = DockStyle.Left;
            bAbout.FlatAppearance.BorderSize = 0;
            bAbout.FlatStyle = FlatStyle.Flat;
            bAbout.Font = new Font("Segoe UI", 12F);
            bAbout.ImageIndex = 1;
            bAbout.ImageList = iGuiSmall;
            bAbout.Location = new Point(0, 0);
            bAbout.Name = "bAbout";
            bAbout.Size = new Size(98, 100);
            bAbout.TabIndex = 2;
            bAbout.TextAlign = ContentAlignment.MiddleRight;
            bAbout.UseVisualStyleBackColor = false;
            bAbout.Click += bAbout_Click_1;
            // 
            // bImageProperties
            // 
            bImageProperties.BackColor = Color.FromArgb(128, 128, 255);
            bImageProperties.Dock = DockStyle.Top;
            bImageProperties.FlatAppearance.BorderSize = 0;
            bImageProperties.FlatStyle = FlatStyle.Flat;
            bImageProperties.Font = new Font("Segoe UI", 12F);
            bImageProperties.Location = new Point(0, 216);
            bImageProperties.Name = "bImageProperties";
            bImageProperties.Size = new Size(297, 54);
            bImageProperties.TabIndex = 5;
            bImageProperties.Text = "bImageProperties";
            bImageProperties.TextAlign = ContentAlignment.MiddleRight;
            bImageProperties.UseVisualStyleBackColor = false;
            // 
            // bSaveImageAs
            // 
            bSaveImageAs.BackColor = Color.FromArgb(128, 128, 255);
            bSaveImageAs.Dock = DockStyle.Top;
            bSaveImageAs.FlatAppearance.BorderSize = 0;
            bSaveImageAs.FlatStyle = FlatStyle.Flat;
            bSaveImageAs.Font = new Font("Segoe UI", 12F);
            bSaveImageAs.Location = new Point(0, 162);
            bSaveImageAs.Name = "bSaveImageAs";
            bSaveImageAs.Size = new Size(297, 54);
            bSaveImageAs.TabIndex = 4;
            bSaveImageAs.Text = "bSaveImageAs";
            bSaveImageAs.TextAlign = ContentAlignment.MiddleRight;
            bSaveImageAs.UseVisualStyleBackColor = false;
            // 
            // bSaveImage
            // 
            bSaveImage.BackColor = Color.FromArgb(128, 128, 255);
            bSaveImage.Dock = DockStyle.Top;
            bSaveImage.FlatAppearance.BorderSize = 0;
            bSaveImage.FlatStyle = FlatStyle.Flat;
            bSaveImage.Font = new Font("Segoe UI", 12F);
            bSaveImage.Location = new Point(0, 108);
            bSaveImage.Name = "bSaveImage";
            bSaveImage.Size = new Size(297, 54);
            bSaveImage.TabIndex = 3;
            bSaveImage.Text = "bSaveImage";
            bSaveImage.TextAlign = ContentAlignment.MiddleRight;
            bSaveImage.UseVisualStyleBackColor = false;
            // 
            // bOpenImage
            // 
            bOpenImage.BackColor = Color.FromArgb(128, 128, 255);
            bOpenImage.Dock = DockStyle.Top;
            bOpenImage.FlatAppearance.BorderSize = 0;
            bOpenImage.FlatStyle = FlatStyle.Flat;
            bOpenImage.Font = new Font("Segoe UI", 12F);
            bOpenImage.Location = new Point(0, 54);
            bOpenImage.Name = "bOpenImage";
            bOpenImage.Size = new Size(297, 54);
            bOpenImage.TabIndex = 2;
            bOpenImage.Text = "bOpenImage";
            bOpenImage.TextAlign = ContentAlignment.MiddleRight;
            bOpenImage.UseVisualStyleBackColor = false;
            bOpenImage.Click += bOpenImage_Click;
            bOpenImage.MouseHover += bOpenImage_MouseHover;
            // 
            // bNewImage
            // 
            bNewImage.BackColor = Color.FromArgb(128, 128, 255);
            bNewImage.Dock = DockStyle.Top;
            bNewImage.FlatAppearance.BorderSize = 0;
            bNewImage.FlatStyle = FlatStyle.Flat;
            bNewImage.Font = new Font("Segoe UI", 12F);
            bNewImage.ImageAlign = ContentAlignment.MiddleLeft;
            bNewImage.Location = new Point(0, 0);
            bNewImage.Name = "bNewImage";
            bNewImage.Size = new Size(297, 54);
            bNewImage.TabIndex = 1;
            bNewImage.Text = "bNewImage";
            bNewImage.TextAlign = ContentAlignment.MiddleRight;
            bNewImage.UseVisualStyleBackColor = false;
            bNewImage.Click += bNewImage_Click;
            bNewImage.MouseHover += bNewImage_MouseHover;
            // 
            // appMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(listView1);
            Controls.Add(pMenu);
            Controls.Add(pMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 538);
            Name = "appMain";
            Text = "appTitle";
            Load += appMain_Load;
            pMain.ResumeLayout(false);
            pMain.PerformLayout();
            pMenu.ResumeLayout(false);
            pMenu.PerformLayout();
            pMenuBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private ImageList iIcons;
        private Panel pMain;
        private Panel pMenu;
        private Button bMenu;
        private ToolTip tTip;
        private TextBox tUrl;
        private Button bNewImage;
        private Button bOpenImage;
        private Button bSaveImage;
        private Button bSaveImageAs;
        private Button bImageProperties;
        private Panel pMenuBottom;
        private Button bExit;
        private Button bSettings;
        private Button bAbout;
        private LinkLabel lBuild;
        private ImageList iGuiSmall;
    }
}
