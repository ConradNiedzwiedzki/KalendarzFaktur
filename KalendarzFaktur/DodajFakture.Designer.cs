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
            this.NowaDataFakturyPicker = new System.Windows.Forms.DateTimePicker();
            this.DodajFaktureButton = new System.Windows.Forms.Button();
            this.kwotaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirmaCombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NowaDataFakturyPicker
            // 
            this.NowaDataFakturyPicker.Location = new System.Drawing.Point(12, 69);
            this.NowaDataFakturyPicker.Name = "NowaDataFakturyPicker";
            this.NowaDataFakturyPicker.Size = new System.Drawing.Size(200, 20);
            this.NowaDataFakturyPicker.TabIndex = 1;
            // 
            // DodajFaktureButton
            // 
            this.DodajFaktureButton.Location = new System.Drawing.Point(237, 95);
            this.DodajFaktureButton.Name = "DodajFaktureButton";
            this.DodajFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.DodajFaktureButton.TabIndex = 3;
            this.DodajFaktureButton.Text = "Dodaj fakturę";
            this.DodajFaktureButton.UseVisualStyleBackColor = true;
            this.DodajFaktureButton.Click += new System.EventHandler(this.DodajFaktureButtonClicked);
            // 
            // kwotaTextBox
            // 
            this.kwotaTextBox.Location = new System.Drawing.Point(220, 69);
            this.kwotaTextBox.Name = "kwotaTextBox";
            this.kwotaTextBox.Size = new System.Drawing.Size(92, 20);
            this.kwotaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kwota:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwa firmy do faktury:";
            // 
            // FirmaCombox
            // 
            this.FirmaCombox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FirmaCombox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FirmaCombox.FormattingEnabled = true;
            this.FirmaCombox.Location = new System.Drawing.Point(12, 26);
            this.FirmaCombox.Name = "FirmaCombox";
            this.FirmaCombox.Size = new System.Drawing.Size(298, 21);
            this.FirmaCombox.TabIndex = 8;
            // 
            // DodajFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.FirmaCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kwotaTextBox);
            this.Controls.Add(this.DodajFaktureButton);
            this.Controls.Add(this.NowaDataFakturyPicker);
            this.Name = "DodajFakture";
            this.Text = "Dodaj fakturę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker NowaDataFakturyPicker;
        private System.Windows.Forms.Button DodajFaktureButton;
        private System.Windows.Forms.TextBox kwotaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FirmaCombox;
    }
}