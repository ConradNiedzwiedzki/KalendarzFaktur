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
            this.nowaDataFakturyPicker = new System.Windows.Forms.DateTimePicker();
            this.dodajFaktureButton = new System.Windows.Forms.Button();
            this.kwotaTextBox = new System.Windows.Forms.TextBox();
            this.kwotaLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.nazwaFirmyLabel = new System.Windows.Forms.Label();
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nowaDataFakturyPicker
            // 
            this.nowaDataFakturyPicker.Location = new System.Drawing.Point(12, 69);
            this.nowaDataFakturyPicker.Name = "nowaDataFakturyPicker";
            this.nowaDataFakturyPicker.Size = new System.Drawing.Size(200, 20);
            this.nowaDataFakturyPicker.TabIndex = 1;
            // 
            // dodajFaktureButton
            // 
            this.dodajFaktureButton.Location = new System.Drawing.Point(237, 95);
            this.dodajFaktureButton.Name = "dodajFaktureButton";
            this.dodajFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.dodajFaktureButton.TabIndex = 3;
            this.dodajFaktureButton.Text = "Dodaj fakturę";
            this.dodajFaktureButton.UseVisualStyleBackColor = true;
            this.dodajFaktureButton.Click += new System.EventHandler(this.DodajFaktureButtonClicked);
            // 
            // kwotaTextBox
            // 
            this.kwotaTextBox.Location = new System.Drawing.Point(220, 69);
            this.kwotaTextBox.Name = "kwotaTextBox";
            this.kwotaTextBox.Size = new System.Drawing.Size(92, 20);
            this.kwotaTextBox.TabIndex = 4;
            // 
            // kwotaLabel
            // 
            this.kwotaLabel.AutoSize = true;
            this.kwotaLabel.Location = new System.Drawing.Point(217, 53);
            this.kwotaLabel.Name = "kwotaLabel";
            this.kwotaLabel.Size = new System.Drawing.Size(40, 13);
            this.kwotaLabel.TabIndex = 5;
            this.kwotaLabel.Text = "Kwota:";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(9, 53);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(68, 13);
            this.dataLabel.TabIndex = 6;
            this.dataLabel.Text = "Data faktury:";
            // 
            // nazwaFirmyLabel
            // 
            this.nazwaFirmyLabel.AutoSize = true;
            this.nazwaFirmyLabel.Location = new System.Drawing.Point(9, 9);
            this.nazwaFirmyLabel.Name = "nazwaFirmyLabel";
            this.nazwaFirmyLabel.Size = new System.Drawing.Size(117, 13);
            this.nazwaFirmyLabel.TabIndex = 7;
            this.nazwaFirmyLabel.Text = "Nazwa firmy do faktury:";
            // 
            // firmaCombox
            // 
            this.firmaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firmaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(12, 26);
            this.firmaComboBox.Name = "firmaCombox";
            this.firmaComboBox.Size = new System.Drawing.Size(298, 21);
            this.firmaComboBox.TabIndex = 8;
            // 
            // DodajFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.firmaComboBox);
            this.Controls.Add(this.nazwaFirmyLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.kwotaLabel);
            this.Controls.Add(this.kwotaTextBox);
            this.Controls.Add(this.dodajFaktureButton);
            this.Controls.Add(this.nowaDataFakturyPicker);
            this.Name = "DodajFakture";
            this.Text = "Dodaj fakturę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker nowaDataFakturyPicker;
        private System.Windows.Forms.Button dodajFaktureButton;
        private System.Windows.Forms.TextBox kwotaTextBox;
        private System.Windows.Forms.Label kwotaLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label nazwaFirmyLabel;
        private System.Windows.Forms.ComboBox firmaComboBox;
    }
}