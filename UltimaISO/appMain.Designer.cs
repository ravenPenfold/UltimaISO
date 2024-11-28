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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appMain));
            menuStrip1 = new MenuStrip();
            fileCtxMenuToolStripMenuItem = new ToolStripMenuItem();
            newImageBtnToolStripMenuItem = new ToolStripMenuItem();
            openImageBtnToolStripMenuItem = new ToolStripMenuItem();
            saveImageBtnToolStripMenuItem = new ToolStripMenuItem();
            saveImageAsBtnToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imagePropertiesBtnToolStripMenuItem = new ToolStripMenuItem();
            exitBtnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileCtxMenuToolStripMenuItem });
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
            openImageBtnToolStripMenuItem.Name = "openImageBtnToolStripMenuItem";
            openImageBtnToolStripMenuItem.Size = new Size(178, 22);
            openImageBtnToolStripMenuItem.Text = "openImageBtn";
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
            // appMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "appMain";
            Text = "appTitle";
            Load += appMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
