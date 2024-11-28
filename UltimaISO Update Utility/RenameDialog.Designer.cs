namespace UltimaISO.Dialogs
{
    partial class RenameDialog
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
            tFilename = new TextBox();
            bAccept = new Button();
            bCancel = new Button();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // tFilename
            // 
            tFilename.Location = new Point(12, 12);
            tFilename.Name = "tFilename";
            tFilename.Size = new Size(296, 23);
            tFilename.TabIndex = 0;
            // 
            // bAccept
            // 
            bAccept.Location = new Point(185, 41);
            bAccept.Name = "bAccept";
            bAccept.Size = new Size(75, 23);
            bAccept.TabIndex = 1;
            bAccept.Text = "ok";
            bAccept.UseVisualStyleBackColor = true;
            bAccept.Click += bAccept_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(266, 42);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 2;
            bCancel.Text = "cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 13);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 3;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RenameDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 77);
            Controls.Add(button1);
            Controls.Add(bCancel);
            Controls.Add(bAccept);
            Controls.Add(tFilename);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RenameDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TEMP - Installation Directory";
            Load += RenameDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tFilename;
        private Button bAccept;
        private Button bCancel;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}