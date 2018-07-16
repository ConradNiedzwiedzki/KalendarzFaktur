namespace KalendarzFaktur
{
    partial class DodajFakture
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
            this.FirmaTextBox = new System.Windows.Forms.TextBox();
            this.NowaDataFakturyPicker = new System.Windows.Forms.DateTimePicker();
            this.NowyCzasFakturyPicker = new System.Windows.Forms.DateTimePicker();
            this.DodajFaktureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirmaTextBox
            // 
            this.FirmaTextBox.Location = new System.Drawing.Point(12, 12);
            this.FirmaTextBox.Name = "FirmaTextBox";
            this.FirmaTextBox.Size = new System.Drawing.Size(300, 20);
            this.FirmaTextBox.TabIndex = 0;
            this.FirmaTextBox.TextChanged += new System.EventHandler(this.TextBoxFirmyTextChanged);
            this.FirmaTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBoxFirmyMouseDown);
            // 
            // NowaDataFakturyPicker
            // 
            this.NowaDataFakturyPicker.Location = new System.Drawing.Point(12, 38);
            this.NowaDataFakturyPicker.Name = "NowaDataFakturyPicker";
            this.NowaDataFakturyPicker.Size = new System.Drawing.Size(200, 20);
            this.NowaDataFakturyPicker.TabIndex = 1;
            // 
            // NowyCzasFakturyPicker
            // 
            this.NowyCzasFakturyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NowyCzasFakturyPicker.Location = new System.Drawing.Point(218, 38);
            this.NowyCzasFakturyPicker.Name = "NowyCzasFakturyPicker";
            this.NowyCzasFakturyPicker.ShowUpDown = true;
            this.NowyCzasFakturyPicker.Size = new System.Drawing.Size(94, 20);
            this.NowyCzasFakturyPicker.TabIndex = 2;
            // 
            // DodajFaktureButton
            // 
            this.DodajFaktureButton.Location = new System.Drawing.Point(237, 64);
            this.DodajFaktureButton.Name = "DodajFaktureButton";
            this.DodajFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.DodajFaktureButton.TabIndex = 3;
            this.DodajFaktureButton.Text = "Dodaj fakturę";
            this.DodajFaktureButton.UseVisualStyleBackColor = true;
            this.DodajFaktureButton.Click += new System.EventHandler(this.DodajFaktureButtonClicked);
            // 
            // DodajFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 100);
            this.Controls.Add(this.DodajFaktureButton);
            this.Controls.Add(this.NowyCzasFakturyPicker);
            this.Controls.Add(this.NowaDataFakturyPicker);
            this.Controls.Add(this.FirmaTextBox);
            this.Name = "DodajFakture";
            this.Text = "Dodaj fakturę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirmaTextBox;
        private System.Windows.Forms.DateTimePicker NowaDataFakturyPicker;
        private System.Windows.Forms.DateTimePicker NowyCzasFakturyPicker;
        private System.Windows.Forms.Button DodajFaktureButton;
    }
}