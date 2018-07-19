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
            this.menuGlowne = new System.Windows.Forms.MenuStrip();
            this.fakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFaktureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksprotujFakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturyPanel = new System.Windows.Forms.Panel();
            this.kwotaLabel = new System.Windows.Forms.Label();
            this.dataFakturyLabel = new System.Windows.Forms.Label();
            this.nazwaFirmyLabel = new System.Windows.Forms.Label();
            this.tabelaFaktur = new System.Windows.Forms.DataGridView();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edytujFirme = new System.Windows.Forms.TextBox();
            this.edycjaKwotyTextBox = new System.Windows.Forms.TextBox();
            this.anulujEdycjeButton = new System.Windows.Forms.Button();
            this.zapiszZmianyButton = new System.Windows.Forms.Button();
            this.edycjaDatyPicker = new System.Windows.Forms.DateTimePicker();
            this.usunFaktureButton = new System.Windows.Forms.Button();
            this.edytujFaktureButton = new System.Windows.Forms.Button();
            this.firmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlowne.SuspendLayout();
            this.fakturyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFaktur)).BeginInit();
            this.groupBox.SuspendLayout();
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
            this.menuGlowne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fakturyToolStripMenuItem,
            this.firmyToolStripMenuItem});
            this.menuGlowne.Location = new System.Drawing.Point(0, 0);
            this.menuGlowne.Name = "menuGlowne";
            this.menuGlowne.Size = new System.Drawing.Size(633, 24);
            this.menuGlowne.TabIndex = 19;
            this.menuGlowne.Text = "menuGlowne";
            this.menuGlowne.Click += new System.EventHandler(this.MenuStrip1Click);
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
            this.dodajFaktureToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.dodajFaktureToolStripMenuItem.Text = "Dodaj fakturę";
            this.dodajFaktureToolStripMenuItem.Click += new System.EventHandler(this.dodajFaktureToolStripMenuItemClick);
            // 
            // eksprotujFakturyToolStripMenuItem
            // 
            this.eksprotujFakturyToolStripMenuItem.Name = "eksprotujFakturyToolStripMenuItem";
            this.eksprotujFakturyToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.eksprotujFakturyToolStripMenuItem.Text = "Eksportuj wszystkie faktury";
            this.eksprotujFakturyToolStripMenuItem.Click += new System.EventHandler(this.eksprotujFakturyToolStripMenuItem_Click);
            // 
            // FakturyPanel
            // 
            this.fakturyPanel.AutoScroll = true;
            this.fakturyPanel.Controls.Add(this.kwotaLabel);
            this.fakturyPanel.Controls.Add(this.dataFakturyLabel);
            this.fakturyPanel.Controls.Add(this.nazwaFirmyLabel);
            this.fakturyPanel.Controls.Add(this.tabelaFaktur);
            this.fakturyPanel.Location = new System.Drawing.Point(17, 199);
            this.fakturyPanel.Name = "FakturyPanel";
            this.fakturyPanel.Size = new System.Drawing.Size(604, 362);
            this.fakturyPanel.TabIndex = 20;
            this.fakturyPanel.Click += new System.EventHandler(this.ClickPanelaFaktur);
            // 
            // kwotaLabel
            // 
            this.kwotaLabel.AutoSize = true;
            this.kwotaLabel.Location = new System.Drawing.Point(499, 10);
            this.kwotaLabel.Name = "kwotaLabel";
            this.kwotaLabel.Size = new System.Drawing.Size(93, 13);
            this.kwotaLabel.TabIndex = 7;
            this.kwotaLabel.Text = "Kwota faktury (zł):";
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
            // 
            // TabelaFaktur
            // 
            this.tabelaFaktur.AllowUserToAddRows = false;
            this.tabelaFaktur.AllowUserToDeleteRows = false;
            this.tabelaFaktur.AllowUserToResizeColumns = false;
            this.tabelaFaktur.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tabelaFaktur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaFaktur.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabelaFaktur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaFaktur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFaktur.ColumnHeadersVisible = false;
            this.tabelaFaktur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firma,
            this.dataNa,
            this.kwota});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaFaktur.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaFaktur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tabelaFaktur.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabelaFaktur.Location = new System.Drawing.Point(2, 26);
            this.tabelaFaktur.MultiSelect = false;
            this.tabelaFaktur.Name = "TabelaFaktur";
            this.tabelaFaktur.ReadOnly = true;
            this.tabelaFaktur.RowHeadersVisible = false;
            this.tabelaFaktur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tabelaFaktur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelaFaktur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tabelaFaktur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaFaktur.Size = new System.Drawing.Size(596, 336);
            this.tabelaFaktur.TabIndex = 4;
            this.tabelaFaktur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickWKomorkeTabeliFaktur);
            // 
            // Firma
            // 
            this.firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firma.HeaderText = "Firma";
            this.firma.MinimumWidth = 100;
            this.firma.Name = "Firma";
            this.firma.ReadOnly = true;
            this.firma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataNa
            // 
            this.dataNa.HeaderText = "Data";
            this.dataNa.MinimumWidth = 100;
            this.dataNa.Name = "DataNa";
            this.dataNa.ReadOnly = true;
            this.dataNa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kwota
            // 
            this.kwota.HeaderText = "Kwota";
            this.kwota.MinimumWidth = 100;
            this.kwota.Name = "Kwota";
            this.kwota.ReadOnly = true;
            this.kwota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kwota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Controls.Add(this.edytujFirme);
            this.groupBox.Controls.Add(this.edycjaKwotyTextBox);
            this.groupBox.Controls.Add(this.anulujEdycjeButton);
            this.groupBox.Controls.Add(this.zapiszZmianyButton);
            this.groupBox.Controls.Add(this.edycjaDatyPicker);
            this.groupBox.Controls.Add(this.usunFaktureButton);
            this.groupBox.Controls.Add(this.edytujFaktureButton);
            this.groupBox.Location = new System.Drawing.Point(291, 27);
            this.groupBox.Name = "groupBox1";
            this.groupBox.Size = new System.Drawing.Size(330, 168);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
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
            // EdytujFirme
            // 
            this.edytujFirme.Location = new System.Drawing.Point(6, 83);
            this.edytujFirme.Name = "EdytujFirme";
            this.edytujFirme.Size = new System.Drawing.Size(318, 21);
            this.edytujFirme.TabIndex = 8;
            // 
            // EdycjaKwotyTextBox
            // 
            this.edycjaKwotyTextBox.Location = new System.Drawing.Point(6, 110);
            this.edycjaKwotyTextBox.Name = "EdycjaKwotyTextBox";
            this.edycjaKwotyTextBox.Size = new System.Drawing.Size(125, 20);
            this.edycjaKwotyTextBox.TabIndex = 7;
            // 
            // AnulujEdycjeButton
            // 
            this.anulujEdycjeButton.Location = new System.Drawing.Point(156, 139);
            this.anulujEdycjeButton.Name = "AnulujEdycjeButton";
            this.anulujEdycjeButton.Size = new System.Drawing.Size(75, 23);
            this.anulujEdycjeButton.TabIndex = 6;
            this.anulujEdycjeButton.Text = "Anuluj";
            this.anulujEdycjeButton.UseVisualStyleBackColor = true;
            this.anulujEdycjeButton.Visible = false;
            this.anulujEdycjeButton.Click += new System.EventHandler(this.AnulujEdycjeButtonClick);
            // 
            // ZapiszZmianyButton
            // 
            this.zapiszZmianyButton.Location = new System.Drawing.Point(65, 139);
            this.zapiszZmianyButton.Name = "ZapiszZmianyButton";
            this.zapiszZmianyButton.Size = new System.Drawing.Size(85, 23);
            this.zapiszZmianyButton.TabIndex = 5;
            this.zapiszZmianyButton.Text = "Zapisz zmiany";
            this.zapiszZmianyButton.UseVisualStyleBackColor = true;
            this.zapiszZmianyButton.Visible = false;
            this.zapiszZmianyButton.Click += new System.EventHandler(this.ZapiszZmianyButtonClick);
            // 
            // EdycjaDatyPicker
            // 
            this.edycjaDatyPicker.Enabled = false;
            this.edycjaDatyPicker.Location = new System.Drawing.Point(137, 110);
            this.edycjaDatyPicker.Name = "EdycjaDatyPicker";
            this.edycjaDatyPicker.Size = new System.Drawing.Size(187, 20);
            this.edycjaDatyPicker.TabIndex = 3;
            // 
            // UsunFaktureButton
            // 
            this.usunFaktureButton.Enabled = false;
            this.usunFaktureButton.Location = new System.Drawing.Point(237, 139);
            this.usunFaktureButton.Name = "UsunFaktureButton";
            this.usunFaktureButton.Size = new System.Drawing.Size(87, 23);
            this.usunFaktureButton.TabIndex = 1;
            this.usunFaktureButton.Text = "Usuń";
            this.usunFaktureButton.UseVisualStyleBackColor = true;
            this.usunFaktureButton.Click += new System.EventHandler(this.UsunFaktureButtonClick);
            // 
            // EdytujFaktureButton
            // 
            this.edytujFaktureButton.Enabled = false;
            this.edytujFaktureButton.Location = new System.Drawing.Point(156, 139);
            this.edytujFaktureButton.Name = "EdytujFaktureButton";
            this.edytujFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.edytujFaktureButton.TabIndex = 2;
            this.edytujFaktureButton.Text = "Edytuj";
            this.edytujFaktureButton.UseVisualStyleBackColor = true;
            this.edytujFaktureButton.Click += new System.EventHandler(this.EdytujFaktureButtonClick);
            // 
            // firmyToolStripMenuItem
            // 
            this.firmyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem});
            this.firmyToolStripMenuItem.Name = "firmyToolStripMenuItem";
            this.firmyToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmyToolStripMenuItem.Text = "Firmy";
            // 
            // usuńFirmęZBazyPodpowiedziToolStripMenuItem
            // 
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem.Name = "usuńFirmęZBazyPodpowiedziToolStripMenuItem";
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem.Text = "Usuń firmę z bazy podpowiedzi";
            this.usunFirmeZBazyPodpowiedziToolStripMenuItem.Click += new System.EventHandler(this.usuńFirmęZBazyPodpowiedziToolStripMenuItem_Click);
            // 
            // KalendarzFakturWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 573);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.fakturyPanel);
            this.Controls.Add(this.menuGlowne);
            this.Controls.Add(this.kalendarzMiesiac);
            this.MainMenuStrip = this.menuGlowne;
            this.Name = "KalendarzFakturWindow";
            this.Text = "Kalendarz faktur";
            this.Activated += new System.EventHandler(this.AktywacjaOknaKalendarzaFaktur);
            this.Deactivate += new System.EventHandler(this.DeaktywacjaOknaKalendarzaFaktur);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZamykanieFormKalendarzaFaktur);
            this.Click += new System.EventHandler(this.ClickOknaKalendarzaFaktur);
            this.Resize += new System.EventHandler(this.ResizeOknaKalendarzaFaktur);
            this.menuGlowne.ResumeLayout(false);
            this.menuGlowne.PerformLayout();
            this.fakturyPanel.ResumeLayout(false);
            this.fakturyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFaktur)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.MonthCalendar kalendarzMiesiac;
        private System.Windows.Forms.MenuStrip menuGlowne;
        private System.Windows.Forms.ToolStripMenuItem fakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFaktureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksprotujFakturyToolStripMenuItem;
        private System.Windows.Forms.Panel fakturyPanel;
        private System.Windows.Forms.DataGridView tabelaFaktur;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwota;
        private System.Windows.Forms.DateTimePicker edycjaDatyPicker;
        private System.Windows.Forms.Button edytujFaktureButton;
        private System.Windows.Forms.Button usunFaktureButton;
        private System.Windows.Forms.Button zapiszZmianyButton;
        private System.Windows.Forms.Button anulujEdycjeButton;
        private System.Windows.Forms.TextBox edycjaKwotyTextBox;
        private System.Windows.Forms.Label nazwaFirmyLabel;
        private System.Windows.Forms.Label kwotaLabel;
        private System.Windows.Forms.Label dataFakturyLabel;
        private System.Windows.Forms.TextBox edytujFirme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem firmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunFirmeZBazyPodpowiedziToolStripMenuItem;
    }
}

