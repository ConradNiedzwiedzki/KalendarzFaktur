namespace KalendarzFaktur
{
    partial class UsunFirme
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
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.nazwaFirmyLabel = new System.Windows.Forms.Label();
            this.usunFirmeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firmaComboBox
            // 
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(15, 25);
            this.firmaComboBox.Name = "firmaComboBox";
            this.firmaComboBox.Size = new System.Drawing.Size(248, 21);
            this.firmaComboBox.TabIndex = 0;
            // 
            // nazwaFirmyLabel
            // 
            this.nazwaFirmyLabel.AutoSize = true;
            this.nazwaFirmyLabel.Location = new System.Drawing.Point(12, 9);
            this.nazwaFirmyLabel.Name = "nazwaFirmyLabel";
            this.nazwaFirmyLabel.Size = new System.Drawing.Size(101, 13);
            this.nazwaFirmyLabel.TabIndex = 1;
            this.nazwaFirmyLabel.Text = "Wybierz firmę z listy:";
            // 
            // usunFirmeButton
            // 
            this.usunFirmeButton.Location = new System.Drawing.Point(92, 52);
            this.usunFirmeButton.Name = "usunFirmeButton";
            this.usunFirmeButton.Size = new System.Drawing.Size(91, 22);
            this.usunFirmeButton.TabIndex = 2;
            this.usunFirmeButton.Text = "Usuń";
            this.usunFirmeButton.UseVisualStyleBackColor = true;
            this.usunFirmeButton.Click += new System.EventHandler(this.usunFirmeButton_Click);
            // 
            // UsunFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 86);
            this.Controls.Add(this.usunFirmeButton);
            this.Controls.Add(this.nazwaFirmyLabel);
            this.Controls.Add(this.firmaComboBox);
            this.Name = "UsunFirme";
            this.Text = "Usuń firmę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox firmaComboBox;
        private System.Windows.Forms.Label nazwaFirmyLabel;
        private System.Windows.Forms.Button usunFirmeButton;
    }
}