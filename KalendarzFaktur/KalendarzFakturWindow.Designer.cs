namespace KalendarzFaktur
{
    partial class KalendarzFakturWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kalendarzMiesiac = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFaktureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksprotujFakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FakturyPanel = new System.Windows.Forms.Panel();
            this.kwotaLabel = new System.Windows.Forms.Label();
            this.dataFakturyLabel = new System.Windows.Forms.Label();
            this.nazwaFirmyLabel = new System.Windows.Forms.Label();
            this.TabelaFaktur = new System.Windows.Forms.DataGridView();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EdytujFirme = new System.Windows.Forms.ComboBox();
            this.EdycjaKwotyTextBox = new System.Windows.Forms.TextBox();
            this.AnulujEdycjeButton = new System.Windows.Forms.Button();
            this.ZapiszZmianyButton = new System.Windows.Forms.Button();
            this.EdycjaDatyPicker = new System.Windows.Forms.DateTimePicker();
            this.UsunFaktureButton = new System.Windows.Forms.Button();
            this.EdytujFaktureButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.FakturyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFaktur)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kalendarzMiesiac
            // 
            this.kalendarzMiesiac.Location = new System.Drawing.Point(16, 33);
            this.kalendarzMiesiac.Name = "kalendarzMiesiac";
            this.kalendarzMiesiac.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fakturyToolStripMenuItem,
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.MenuStrip1Click);
            // 
            // fakturyToolStripMenuItem
            // 
            this.fakturyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFaktureToolStripMenuItem,
            this.eksprotujFakturyToolStripMenuItem});
            this.fakturyToolStripMenuItem.Name = "fakturyToolStripMenuItem";
            this.fakturyToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fakturyToolStripMenuItem.Text = "Faktury";
            // 
            // dodajFaktureToolStripMenuItem
            // 
            this.dodajFaktureToolStripMenuItem.Name = "dodajFaktureToolStripMenuItem";
            this.dodajFaktureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajFaktureToolStripMenuItem.Text = "Dodaj fakturę";
            this.dodajFaktureToolStripMenuItem.Click += new System.EventHandler(this.AddEventToolStripMenuItemClick);
            // 
            // eksprotujFakturyToolStripMenuItem
            // 
            this.eksprotujFakturyToolStripMenuItem.Enabled = false;
            this.eksprotujFakturyToolStripMenuItem.Name = "eksprotujFakturyToolStripMenuItem";
            this.eksprotujFakturyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eksprotujFakturyToolStripMenuItem.Text = "Eksportuj faktury";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Enabled = false;
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // FakturyPanel
            // 
            this.FakturyPanel.AutoScroll = true;
            this.FakturyPanel.Controls.Add(this.kwotaLabel);
            this.FakturyPanel.Controls.Add(this.dataFakturyLabel);
            this.FakturyPanel.Controls.Add(this.nazwaFirmyLabel);
            this.FakturyPanel.Controls.Add(this.TabelaFaktur);
            this.FakturyPanel.Location = new System.Drawing.Point(17, 199);
            this.FakturyPanel.Name = "FakturyPanel";
            this.FakturyPanel.Size = new System.Drawing.Size(604, 362);
            this.FakturyPanel.TabIndex = 20;
            this.FakturyPanel.Click += new System.EventHandler(this.ClickPanelaFaktur);
            // 
            // kwotaLabel
            // 
            this.kwotaLabel.AutoSize = true;
            this.kwotaLabel.Location = new System.Drawing.Point(499, 10);
            this.kwotaLabel.Name = "kwotaLabel";
            this.kwotaLabel.Size = new System.Drawing.Size(75, 13);
            this.kwotaLabel.TabIndex = 7;
            this.kwotaLabel.Text = "Kwota faktury:";
            // 
            // dataFakturyLabel
            // 
            this.dataFakturyLabel.AutoSize = true;
            this.dataFakturyLabel.Location = new System.Drawing.Point(398, 10);
            this.dataFakturyLabel.Name = "dataFakturyLabel";
            this.dataFakturyLabel.Size = new System.Drawing.Size(68, 13);
            this.dataFakturyLabel.TabIndex = 6;
            this.dataFakturyLabel.Text = "Data faktury:";
            // 
            // nazwaFirmyLabel
            // 
            this.nazwaFirmyLabel.AutoSize = true;
            this.nazwaFirmyLabel.Location = new System.Drawing.Point(3, 10);
            this.nazwaFirmyLabel.Name = "nazwaFirmyLabel";
            this.nazwaFirmyLabel.Size = new System.Drawing.Size(67, 13);
            this.nazwaFirmyLabel.TabIndex = 5;
            this.nazwaFirmyLabel.Text = "Nazwa firmy:";
            this.nazwaFirmyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TabelaFaktur
            // 
            this.TabelaFaktur.AllowUserToAddRows = false;
            this.TabelaFaktur.AllowUserToDeleteRows = false;
            this.TabelaFaktur.AllowUserToResizeColumns = false;
            this.TabelaFaktur.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TabelaFaktur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaFaktur.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TabelaFaktur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaFaktur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaFaktur.ColumnHeadersVisible = false;
            this.TabelaFaktur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firma,
            this.DataNa,
            this.Kwota});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaFaktur.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaFaktur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TabelaFaktur.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TabelaFaktur.Location = new System.Drawing.Point(2, 26);
            this.TabelaFaktur.MultiSelect = false;
            this.TabelaFaktur.Name = "TabelaFaktur";
            this.TabelaFaktur.ReadOnly = true;
            this.TabelaFaktur.RowHeadersVisible = false;
            this.TabelaFaktur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TabelaFaktur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaFaktur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TabelaFaktur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaFaktur.Size = new System.Drawing.Size(596, 336);
            this.TabelaFaktur.TabIndex = 4;
            this.TabelaFaktur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickWKomorkeTabeliFaktur);
            // 
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firma.HeaderText = "Firma";
            this.Firma.MinimumWidth = 100;
            this.Firma.Name = "Firma";
            this.Firma.ReadOnly = true;
            this.Firma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Firma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataNa
            // 
            this.DataNa.HeaderText = "Data";
            this.DataNa.MinimumWidth = 100;
            this.DataNa.Name = "DataNa";
            this.DataNa.ReadOnly = true;
            this.DataNa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataNa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kwota
            // 
            this.Kwota.HeaderText = "Kwota";
            this.Kwota.MinimumWidth = 100;
            this.Kwota.Name = "Kwota";
            this.Kwota.ReadOnly = true;
            this.Kwota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Kwota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.EdytujFirme);
            this.groupBox1.Controls.Add(this.EdycjaKwotyTextBox);
            this.groupBox1.Controls.Add(this.AnulujEdycjeButton);
            this.groupBox1.Controls.Add(this.ZapiszZmianyButton);
            this.groupBox1.Controls.Add(this.EdycjaDatyPicker);
            this.groupBox1.Controls.Add(this.UsunFaktureButton);
            this.groupBox1.Controls.Add(this.EdytujFaktureButton);
            this.groupBox1.Location = new System.Drawing.Point(291, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 168);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // EdytujFirme
            // 
            this.EdytujFirme.FormattingEnabled = true;
            this.EdytujFirme.Location = new System.Drawing.Point(6, 83);
            this.EdytujFirme.Name = "EdytujFirme";
            this.EdytujFirme.Size = new System.Drawing.Size(318, 21);
            this.EdytujFirme.TabIndex = 8;
            // 
            // EdycjaKwotyTextBox
            // 
            this.EdycjaKwotyTextBox.Location = new System.Drawing.Point(6, 110);
            this.EdycjaKwotyTextBox.Name = "EdycjaKwotyTextBox";
            this.EdycjaKwotyTextBox.Size = new System.Drawing.Size(125, 20);
            this.EdycjaKwotyTextBox.TabIndex = 7;
            // 
            // AnulujEdycjeButton
            // 
            this.AnulujEdycjeButton.Location = new System.Drawing.Point(156, 139);
            this.AnulujEdycjeButton.Name = "AnulujEdycjeButton";
            this.AnulujEdycjeButton.Size = new System.Drawing.Size(75, 23);
            this.AnulujEdycjeButton.TabIndex = 6;
            this.AnulujEdycjeButton.Text = "Anuluj";
            this.AnulujEdycjeButton.UseVisualStyleBackColor = true;
            this.AnulujEdycjeButton.Visible = false;
            this.AnulujEdycjeButton.Click += new System.EventHandler(this.AnulujEdycjeButtonClick);
            // 
            // ZapiszZmianyButton
            // 
            this.ZapiszZmianyButton.Location = new System.Drawing.Point(65, 139);
            this.ZapiszZmianyButton.Name = "ZapiszZmianyButton";
            this.ZapiszZmianyButton.Size = new System.Drawing.Size(85, 23);
            this.ZapiszZmianyButton.TabIndex = 5;
            this.ZapiszZmianyButton.Text = "Zapisz zmiany";
            this.ZapiszZmianyButton.UseVisualStyleBackColor = true;
            this.ZapiszZmianyButton.Visible = false;
            this.ZapiszZmianyButton.Click += new System.EventHandler(this.SaveChangesButtonClick);
            // 
            // EdycjaDatyPicker
            // 
            this.EdycjaDatyPicker.Enabled = false;
            this.EdycjaDatyPicker.Location = new System.Drawing.Point(137, 110);
            this.EdycjaDatyPicker.Name = "EdycjaDatyPicker";
            this.EdycjaDatyPicker.Size = new System.Drawing.Size(187, 20);
            this.EdycjaDatyPicker.TabIndex = 3;
            // 
            // UsunFaktureButton
            // 
            this.UsunFaktureButton.Enabled = false;
            this.UsunFaktureButton.Location = new System.Drawing.Point(237, 139);
            this.UsunFaktureButton.Name = "UsunFaktureButton";
            this.UsunFaktureButton.Size = new System.Drawing.Size(87, 23);
            this.UsunFaktureButton.TabIndex = 1;
            this.UsunFaktureButton.Text = "Usuń";
            this.UsunFaktureButton.UseVisualStyleBackColor = true;
            this.UsunFaktureButton.Click += new System.EventHandler(this.UsunFaktureButtonClick);
            // 
            // EdytujFaktureButton
            // 
            this.EdytujFaktureButton.Enabled = false;
            this.EdytujFaktureButton.Location = new System.Drawing.Point(156, 139);
            this.EdytujFaktureButton.Name = "EdytujFaktureButton";
            this.EdytujFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.EdytujFaktureButton.TabIndex = 2;
            this.EdytujFaktureButton.Text = "Edytuj";
            this.EdytujFaktureButton.UseVisualStyleBackColor = true;
            this.EdytujFaktureButton.Click += new System.EventHandler(this.EdytujFaktureButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KalendarzFaktur.Properties.Resources.paxer;
            this.pictureBox1.Location = new System.Drawing.Point(62, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 60);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // KalendarzFakturWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FakturyPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.kalendarzMiesiac);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KalendarzFakturWindow";
            this.Text = "Kalendarz faktur";
            this.Activated += new System.EventHandler(this.AktywacjaOknaKalendarzaFaktur);
            this.Deactivate += new System.EventHandler(this.DeaktywacjaOknaKalendarzaFaktur);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZamykanieFormKalendarzaFaktur);
            this.Click += new System.EventHandler(this.ClickOknaKalendarzaFaktur);
            this.Resize += new System.EventHandler(this.ResizeOknaKalendarzaFaktur);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FakturyPanel.ResumeLayout(false);
            this.FakturyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFaktur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.MonthCalendar kalendarzMiesiac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFaktureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksprotujFakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.Panel FakturyPanel;
        private System.Windows.Forms.DataGridView TabelaFaktur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
        private System.Windows.Forms.DateTimePicker EdycjaDatyPicker;
        private System.Windows.Forms.Button EdytujFaktureButton;
        private System.Windows.Forms.Button UsunFaktureButton;
        private System.Windows.Forms.Button ZapiszZmianyButton;
        private System.Windows.Forms.Button AnulujEdycjeButton;
        private System.Windows.Forms.TextBox EdycjaKwotyTextBox;
        private System.Windows.Forms.Label nazwaFirmyLabel;
        private System.Windows.Forms.Label kwotaLabel;
        private System.Windows.Forms.Label dataFakturyLabel;
        private System.Windows.Forms.ComboBox EdytujFirme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

