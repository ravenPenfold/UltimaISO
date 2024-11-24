namespace StringEditor
{
    partial class Form1
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
            fileName = new TextBox();
            saveFile = new Button();
            id = new NumericUpDown();
            label1 = new Label();
            str = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            strUse = new Label();
            ((System.ComponentModel.ISupportInitialize)id).BeginInit();
            SuspendLayout();
            // 
            // fileName
            // 
            fileName.Location = new Point(12, 12);
            fileName.Name = "fileName";
            fileName.ReadOnly = true;
            fileName.Size = new Size(337, 23);
            fileName.TabIndex = 1;
            // 
            // saveFile
            // 
            saveFile.Location = new Point(355, 11);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(75, 23);
            saveFile.TabIndex = 2;
            saveFile.Text = "Save File";
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += saveFile_Click;
            // 
            // id
            // 
            id.Location = new Point(36, 41);
            id.Name = "id";
            id.Size = new Size(161, 23);
            id.TabIndex = 3;
            id.ValueChanged += id_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // str
            // 
            str.Location = new Point(36, 70);
            str.MaxLength = 255;
            str.Multiline = true;
            str.Name = "str";
            str.Size = new Size(394, 105);
            str.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Filter = "Raven String Archive|*.rstr";
            openFileDialog1.ValidateNames = false;
            // 
            // button2
            // 
            button2.Location = new Point(279, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Add String";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(198, 41);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(355, 41);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Save String";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // strUse
            // 
            strUse.AutoSize = true;
            strUse.Location = new Point(36, 178);
            strUse.Name = "strUse";
            strUse.Size = new Size(45, 15);
            strUse.TabIndex = 9;
            strUse.Text = "Usage: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 200);
            Controls.Add(strUse);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(str);
            Controls.Add(label1);
            Controls.Add(id);
            Controls.Add(saveFile);
            Controls.Add(fileName);
            Name = "Form1";
            Text = "String Editor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox fileName;
        private Button saveFile;
        private NumericUpDown id;
        private Label label1;
        private TextBox str;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label strUse;
    }
}
