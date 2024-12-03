namespace UltimaISO.Dialogs
{
    partial class AboutDialog
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
            bOk = new Button();
            lTitle = new Label();
            lCopyright = new Label();
            lLicenseTag = new Label();
            richTextBox1 = new RichTextBox();
            lAcknowledgements = new Label();
            richTextBox2 = new RichTextBox();
            lVersionInfo = new Label();
            SuspendLayout();
            // 
            // bOk
            // 
            bOk.Location = new Point(256, 326);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 0;
            bOk.Text = "Ok";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // lTitle
            // 
            lTitle.AutoSize = true;
            lTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lTitle.Location = new Point(12, 9);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(70, 32);
            lTitle.TabIndex = 1;
            lTitle.Text = "label";
            // 
            // lCopyright
            // 
            lCopyright.AutoSize = true;
            lCopyright.Location = new Point(12, 330);
            lCopyright.Name = "lCopyright";
            lCopyright.Size = new Size(38, 15);
            lCopyright.TabIndex = 3;
            lCopyright.Text = "label1";
            // 
            // lLicenseTag
            // 
            lLicenseTag.AutoSize = true;
            lLicenseTag.Location = new Point(12, 198);
            lLicenseTag.Name = "lLicenseTag";
            lLicenseTag.Size = new Size(38, 15);
            lLicenseTag.TabIndex = 4;
            lLicenseTag.Text = "label1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 104);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // lAcknowledgements
            // 
            lAcknowledgements.AutoSize = true;
            lAcknowledgements.Location = new Point(12, 56);
            lAcknowledgements.Name = "lAcknowledgements";
            lAcknowledgements.Size = new Size(38, 15);
            lAcknowledgements.TabIndex = 6;
            lAcknowledgements.Text = "label2";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 216);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(319, 104);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // lVersionInfo
            // 
            lVersionInfo.AutoSize = true;
            lVersionInfo.Location = new Point(12, 41);
            lVersionInfo.Name = "lVersionInfo";
            lVersionInfo.Size = new Size(38, 15);
            lVersionInfo.TabIndex = 2;
            lVersionInfo.Text = "label1";
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 361);
            Controls.Add(richTextBox2);
            Controls.Add(lAcknowledgements);
            Controls.Add(richTextBox1);
            Controls.Add(lLicenseTag);
            Controls.Add(lCopyright);
            Controls.Add(lVersionInfo);
            Controls.Add(lTitle);
            Controls.Add(bOk);
            MaximizeBox = false;
            MaximumSize = new Size(359, 400);
            MinimizeBox = false;
            MinimumSize = new Size(359, 400);
            Name = "AboutDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About UltimaISO";
            Load += AboutDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bOk;
        private Label lTitle;
        private Label lCopyright;
        private Label lLicenseTag;
        private RichTextBox richTextBox1;
        private Label lAcknowledgements;
        private RichTextBox richTextBox2;
        private Label lVersionInfo;
    }
}