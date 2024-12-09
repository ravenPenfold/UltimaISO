namespace UltimaISO.Dialogs
{
    partial class ErrorDialog
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
            text = new Label();
            closeBtn = new Button();
            errorCode = new Label();
            errorLine = new Label();
            linkLabel1 = new LinkLabel();
            vLogFile = new Button();
            reportLink = new Label();
            SuspendLayout();
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(12, 9);
            text.Name = "text";
            text.Size = new Size(225, 15);
            text.TabIndex = 0;
            text.Text = "An fatal error has occurred in UltimaISO...";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(642, 105);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(158, 23);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Close UltimaISO";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // errorCode
            // 
            errorCode.AutoSize = true;
            errorCode.Location = new Point(12, 24);
            errorCode.Name = "errorCode";
            errorCode.Size = new Size(69, 15);
            errorCode.TabIndex = 2;
            errorCode.Text = "Error Code: ";
            // 
            // errorLine
            // 
            errorLine.AutoSize = true;
            errorLine.Location = new Point(12, 39);
            errorLine.Name = "errorLine";
            errorLine.Size = new Size(59, 15);
            errorLine.TabIndex = 3;
            errorLine.Text = "Code File:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 87);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(278, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/ravenPenfold/UltimaISO/issues";
            // 
            // vLogFile
            // 
            vLogFile.Location = new Point(12, 105);
            vLogFile.Name = "vLogFile";
            vLogFile.Size = new Size(158, 23);
            vLogFile.TabIndex = 7;
            vLogFile.Text = "View Log File";
            vLogFile.UseVisualStyleBackColor = true;
            vLogFile.Click += vLogFile_Click;
            // 
            // reportLink
            // 
            reportLink.AutoSize = true;
            reportLink.Location = new Point(12, 69);
            reportLink.Name = "reportLink";
            reportLink.Size = new Size(179, 15);
            reportLink.TabIndex = 5;
            reportLink.Text = "Please report this on our GitHub:";
            // 
            // ErrorDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 140);
            Controls.Add(vLogFile);
            Controls.Add(linkLabel1);
            Controls.Add(reportLink);
            Controls.Add(errorLine);
            Controls.Add(errorCode);
            Controls.Add(closeBtn);
            Controls.Add(text);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "An error has occurred...";
            Load += ErrorDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text;
        private Button closeBtn;
        private Label errorCode;
        private Label errorLine;
        private LinkLabel linkLabel1;
        private Button vLogFile;
        private Label reportLink;
    }
}