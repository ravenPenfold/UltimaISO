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
            lPrototype = new Label();
            SuspendLayout();
            // 
            // bOk
            // 
            bOk.Location = new Point(256, 142);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 0;
            bOk.Text = "Ok";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // lPrototype
            // 
            lPrototype.AutoSize = true;
            lPrototype.Location = new Point(12, 146);
            lPrototype.Name = "lPrototype";
            lPrototype.Size = new Size(145, 15);
            lPrototype.TabIndex = 1;
            lPrototype.Text = "Testing Copy v0.1.1122024";
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 177);
            Controls.Add(lPrototype);
            Controls.Add(bOk);
            MaximizeBox = false;
            MaximumSize = new Size(359, 216);
            MinimizeBox = false;
            MinimumSize = new Size(359, 216);
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
        private Label lPrototype;
    }
}