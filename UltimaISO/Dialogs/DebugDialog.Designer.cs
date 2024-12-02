namespace UltimaISO.Dialogs
{
    partial class DebugDialog
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
            groupBox1 = new GroupBox();
            lStrId = new Label();
            lString = new Label();
            stringNo = new NumericUpDown();
            groupBox2 = new GroupBox();
            dialogRun = new Button();
            dialogList = new ComboBox();
            label1 = new Label();
            sAsEditable = new SaveFileDialog();
            sAsCompiled = new SaveFileDialog();
            oEditable = new OpenFileDialog();
            bCvtStrToRlx = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stringNo).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lStrId);
            groupBox1.Controls.Add(lString);
            groupBox1.Controls.Add(stringNo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "String Viewer";
            // 
            // lStrId
            // 
            lStrId.AutoSize = true;
            lStrId.Location = new Point(132, 24);
            lStrId.Name = "lStrId";
            lStrId.Size = new Size(38, 15);
            lStrId.TabIndex = 2;
            lStrId.Text = "label1";
            // 
            // lString
            // 
            lString.AutoSize = true;
            lString.Location = new Point(6, 48);
            lString.Name = "lString";
            lString.Size = new Size(38, 15);
            lString.TabIndex = 1;
            lString.Text = "label1";
            // 
            // stringNo
            // 
            stringNo.Location = new Point(6, 22);
            stringNo.Name = "stringNo";
            stringNo.Size = new Size(120, 23);
            stringNo.TabIndex = 0;
            stringNo.ValueChanged += stringNo_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dialogRun);
            groupBox2.Controls.Add(dialogList);
            groupBox2.Location = new Point(12, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dialog Loader";
            // 
            // dialogRun
            // 
            dialogRun.Location = new Point(176, 21);
            dialogRun.Name = "dialogRun";
            dialogRun.Size = new Size(75, 23);
            dialogRun.TabIndex = 1;
            dialogRun.Text = "Run";
            dialogRun.UseVisualStyleBackColor = true;
            dialogRun.Click += dialogRun_Click;
            // 
            // dialogList
            // 
            dialogList.DropDownStyle = ComboBoxStyle.DropDownList;
            dialogList.FormattingEnabled = true;
            dialogList.Items.AddRange(new object[] { "AboutDialog", "CreateNewDiscImageDialog", "RenameDialog" });
            dialogList.Location = new Point(6, 22);
            dialogList.Name = "dialogList";
            dialogList.Size = new Size(164, 23);
            dialogList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 133);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // sAsEditable
            // 
            sAsEditable.Filter = "Editable Strings|*.txt";
            sAsEditable.FileOk += sAsEditable_FileOk;
            // 
            // sAsCompiled
            // 
            sAsCompiled.Filter = "String Database|*.rlx";
            // 
            // oEditable
            // 
            oEditable.FileName = "openFileDialog1";
            oEditable.Filter = "Editable Strings|*.txt";
            // 
            // bCvtStrToRlx
            // 
            bCvtStrToRlx.Location = new Point(509, 12);
            bCvtStrToRlx.Name = "bCvtStrToRlx";
            bCvtStrToRlx.Size = new Size(109, 23);
            bCvtStrToRlx.TabIndex = 3;
            bCvtStrToRlx.Text = "Compile RSTR";
            bCvtStrToRlx.UseVisualStyleBackColor = true;
            bCvtStrToRlx.Click += bCvtStrToRlx_Click;
            // 
            // DebugDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(bCvtStrToRlx);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DebugDialog";
            Text = "DebugDialog";
            Load += DebugDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stringNo).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lString;
        private NumericUpDown stringNo;
        private GroupBox groupBox2;
        private ComboBox dialogList;
        private Button dialogRun;
        private Label label1;
        private Label lStrId;
        private SaveFileDialog sAsEditable;
        private SaveFileDialog sAsCompiled;
        private OpenFileDialog oEditable;
        private Button bCvtStrToRlx;
    }
}