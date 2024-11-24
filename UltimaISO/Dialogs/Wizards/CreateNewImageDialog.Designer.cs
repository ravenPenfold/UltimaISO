namespace UltimaISO.Dialogs.Wizards
{
    partial class CreateNewImageDialog
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
            alwaysShowing = new Panel();
            gMainImageProps = new GroupBox();
            lImageName = new Label();
            tImageName = new TextBox();
            cImageType = new ComboBox();
            lImageType = new Label();
            bFilename = new Button();
            lFilename = new Label();
            lDescription = new Label();
            btnCancel = new Button();
            btnFinish = new Button();
            lHeader = new Label();
            alwaysShowing.SuspendLayout();
            gMainImageProps.SuspendLayout();
            SuspendLayout();
            // 
            // alwaysShowing
            // 
            alwaysShowing.BackColor = SystemColors.ControlLight;
            alwaysShowing.Controls.Add(gMainImageProps);
            alwaysShowing.Controls.Add(lDescription);
            alwaysShowing.Controls.Add(btnCancel);
            alwaysShowing.Controls.Add(btnFinish);
            alwaysShowing.Controls.Add(lHeader);
            alwaysShowing.Dock = DockStyle.Left;
            alwaysShowing.Location = new Point(0, 0);
            alwaysShowing.Name = "alwaysShowing";
            alwaysShowing.Size = new Size(325, 450);
            alwaysShowing.TabIndex = 0;
            // 
            // gMainImageProps
            // 
            gMainImageProps.Controls.Add(lImageName);
            gMainImageProps.Controls.Add(tImageName);
            gMainImageProps.Controls.Add(cImageType);
            gMainImageProps.Controls.Add(lImageType);
            gMainImageProps.Controls.Add(bFilename);
            gMainImageProps.Controls.Add(lFilename);
            gMainImageProps.Location = new Point(12, 108);
            gMainImageProps.Name = "gMainImageProps";
            gMainImageProps.Size = new Size(301, 272);
            gMainImageProps.TabIndex = 4;
            gMainImageProps.TabStop = false;
            gMainImageProps.Text = "cMainImageProperties";
            // 
            // lImageName
            // 
            lImageName.AutoSize = true;
            lImageName.Location = new Point(6, 85);
            lImageName.Name = "lImageName";
            lImageName.Size = new Size(78, 15);
            lImageName.TabIndex = 5;
            lImageName.Text = "cImageName";
            // 
            // tImageName
            // 
            tImageName.Location = new Point(90, 82);
            tImageName.Name = "tImageName";
            tImageName.Size = new Size(205, 23);
            tImageName.TabIndex = 4;
            tImageName.Text = "IMAGE_NAME";
            // 
            // cImageType
            // 
            cImageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cImageType.FormattingEnabled = true;
            cImageType.Location = new Point(90, 53);
            cImageType.Name = "cImageType";
            cImageType.Size = new Size(205, 23);
            cImageType.TabIndex = 3;
            // 
            // lImageType
            // 
            lImageType.AutoSize = true;
            lImageType.Location = new Point(6, 56);
            lImageType.Name = "lImageType";
            lImageType.Size = new Size(71, 15);
            lImageType.TabIndex = 2;
            lImageType.Text = "cImageType";
            // 
            // bFilename
            // 
            bFilename.Location = new Point(90, 24);
            bFilename.Name = "bFilename";
            bFilename.Size = new Size(205, 23);
            bFilename.TabIndex = 1;
            bFilename.Text = "defaultFilename";
            bFilename.UseVisualStyleBackColor = true;
            // 
            // lFilename
            // 
            lFilename.AutoSize = true;
            lFilename.Location = new Point(6, 28);
            lFilename.Name = "lFilename";
            lFilename.Size = new Size(61, 15);
            lFilename.TabIndex = 0;
            lFilename.Text = "cFilename";
            // 
            // lDescription
            // 
            lDescription.AutoSize = true;
            lDescription.Location = new Point(12, 50);
            lDescription.Name = "lDescription";
            lDescription.Size = new Size(128, 15);
            lDescription.TabIndex = 3;
            lDescription.Text = "newDiscImageWizDesc";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(301, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(12, 415);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(301, 23);
            btnFinish.TabIndex = 1;
            btnFinish.Text = "btnFinish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // lHeader
            // 
            lHeader.AutoSize = true;
            lHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lHeader.Location = new Point(12, 9);
            lHeader.Name = "lHeader";
            lHeader.Size = new Size(301, 32);
            lHeader.TabIndex = 0;
            lHeader.Text = "newDiscImageWizHeader";
            // 
            // CreateNewImageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(alwaysShowing);
            Name = "CreateNewImageDialog";
            Text = "newDiscImageWizHeader";
            Load += CreateNewImageDialog_Load;
            alwaysShowing.ResumeLayout(false);
            alwaysShowing.PerformLayout();
            gMainImageProps.ResumeLayout(false);
            gMainImageProps.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel alwaysShowing;
        private Label lHeader;
        private Button btnCancel;
        private Button btnFinish;
        private Label lDescription;
        private GroupBox gMainImageProps;
        private Button bFilename;
        private Label lFilename;
        private ComboBox cImageType;
        private Label lImageType;
        private Label lImageName;
        private TextBox tImageName;
    }
}