﻿namespace KalendarzFaktur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalendarzFakturWindow));
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
            this.TabelaFaktur = new System.Windows.Forms.DataGridView();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasNa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnulujEdycjeButton = new System.Windows.Forms.Button();
            this.ZapiszZmianyButton = new System.Windows.Forms.Button();
            this.EdycjaCzasuPicker = new System.Windows.Forms.DateTimePicker();
            this.EdycjaDatyPicker = new System.Windows.Forms.DateTimePicker();
            this.UsunFaktureButton = new System.Windows.Forms.Button();
            this.EdytujFirme = new System.Windows.Forms.TextBox();
            this.EdytujFaktureButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.FakturyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFaktur)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.FakturyPanel.Controls.Add(this.TabelaFaktur);
            this.FakturyPanel.Location = new System.Drawing.Point(17, 199);
            this.FakturyPanel.Name = "FakturyPanel";
            this.FakturyPanel.Size = new System.Drawing.Size(604, 362);
            this.FakturyPanel.TabIndex = 20;
            this.FakturyPanel.Click += new System.EventHandler(this.ClickPanelaFaktur);
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
            this.CzasNa,
            this.CzasDo});
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
            this.TabelaFaktur.Location = new System.Drawing.Point(2, 0);
            this.TabelaFaktur.MultiSelect = false;
            this.TabelaFaktur.Name = "TabelaFaktur";
            this.TabelaFaktur.ReadOnly = true;
            this.TabelaFaktur.RowHeadersVisible = false;
            this.TabelaFaktur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.TabelaFaktur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaFaktur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TabelaFaktur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaFaktur.Size = new System.Drawing.Size(596, 362);
            this.TabelaFaktur.TabIndex = 4;
            this.TabelaFaktur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickWKomorkeTabeliFaktur);
            // 
            // Description
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firma.HeaderText = "Firma";
            this.Firma.MinimumWidth = 220;
            this.Firma.Name = "Firma";
            this.Firma.ReadOnly = true;
            this.Firma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Firma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Data
            // 
            this.DataNa.HeaderText = "Data";
            this.DataNa.MinimumWidth = 70;
            this.DataNa.Name = "DataNa";
            this.DataNa.ReadOnly = true;
            this.DataNa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataNa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataNa.Width = 70;
            // 
            // Czas
            // 
            this.CzasNa.HeaderText = "Czas";
            this.CzasNa.MinimumWidth = 60;
            this.CzasNa.Name = "CzasNa";
            this.CzasNa.ReadOnly = true;
            this.CzasNa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CzasNa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CzasNa.Width = 60;
            // 
            // CzasDo
            // 
            this.CzasDo.HeaderText = "CzasDoKońca";
            this.CzasDo.MinimumWidth = 90;
            this.CzasDo.Name = "CzasDo";
            this.CzasDo.ReadOnly = true;
            this.CzasDo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CzasDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CzasDo.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnulujEdycjeButton);
            this.groupBox1.Controls.Add(this.ZapiszZmianyButton);
            this.groupBox1.Controls.Add(this.EdycjaCzasuPicker);
            this.groupBox1.Controls.Add(this.EdycjaDatyPicker);
            this.groupBox1.Controls.Add(this.UsunFaktureButton);
            this.groupBox1.Controls.Add(this.EdytujFirme);
            this.groupBox1.Controls.Add(this.EdytujFaktureButton);
            this.groupBox1.Location = new System.Drawing.Point(291, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 168);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // AnulujEdycjeButton
            // 
            this.AnulujEdycjeButton.Location = new System.Drawing.Point(156, 95);
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
            this.ZapiszZmianyButton.Location = new System.Drawing.Point(65, 95);
            this.ZapiszZmianyButton.Name = "ZapiszZmianyButton";
            this.ZapiszZmianyButton.Size = new System.Drawing.Size(85, 23);
            this.ZapiszZmianyButton.TabIndex = 5;
            this.ZapiszZmianyButton.Text = "Zapisz zmiany";
            this.ZapiszZmianyButton.UseVisualStyleBackColor = true;
            this.ZapiszZmianyButton.Visible = false;
            this.ZapiszZmianyButton.Click += new System.EventHandler(this.SaveChangesButtonClick);
            // 
            // EdycjaCzasuPicker
            // 
            this.EdycjaCzasuPicker.Enabled = false;
            this.EdycjaCzasuPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EdycjaCzasuPicker.Location = new System.Drawing.Point(6, 65);
            this.EdycjaCzasuPicker.Name = "EdycjaCzasuPicker";
            this.EdycjaCzasuPicker.ShowUpDown = true;
            this.EdycjaCzasuPicker.Size = new System.Drawing.Size(94, 20);
            this.EdycjaCzasuPicker.TabIndex = 4;
            // 
            // EdycjaDatyPicker
            // 
            this.EdycjaDatyPicker.Enabled = false;
            this.EdycjaDatyPicker.Location = new System.Drawing.Point(6, 39);
            this.EdycjaDatyPicker.Name = "EdycjaDatyPicker";
            this.EdycjaDatyPicker.Size = new System.Drawing.Size(200, 20);
            this.EdycjaDatyPicker.TabIndex = 3;
            // 
            // UsunFaktureButton
            // 
            this.UsunFaktureButton.Enabled = false;
            this.UsunFaktureButton.Location = new System.Drawing.Point(237, 95);
            this.UsunFaktureButton.Name = "UsunFaktureButton";
            this.UsunFaktureButton.Size = new System.Drawing.Size(87, 23);
            this.UsunFaktureButton.TabIndex = 1;
            this.UsunFaktureButton.Text = "Usuń";
            this.UsunFaktureButton.UseVisualStyleBackColor = true;
            this.UsunFaktureButton.Click += new System.EventHandler(this.UsunFaktureButtonClick);
            // 
            // EdytujFirme
            // 
            this.EdytujFirme.Enabled = false;
            this.EdytujFirme.Location = new System.Drawing.Point(6, 13);
            this.EdytujFirme.Name = "EdytujFirme";
            this.EdytujFirme.Size = new System.Drawing.Size(306, 20);
            this.EdytujFirme.TabIndex = 0;
            // 
            // EditEventButton
            // 
            this.EdytujFaktureButton.Enabled = false;
            this.EdytujFaktureButton.Location = new System.Drawing.Point(156, 95);
            this.EdytujFaktureButton.Name = "EditEventButton";
            this.EdytujFaktureButton.Size = new System.Drawing.Size(75, 23);
            this.EdytujFaktureButton.TabIndex = 2;
            this.EdytujFaktureButton.Text = "Edytuj";
            this.EdytujFaktureButton.UseVisualStyleBackColor = true;
            this.EdytujFaktureButton.Click += new System.EventHandler(this.EdytujFaktureButtonClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFaktur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasNa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasDo;
        private System.Windows.Forms.DateTimePicker EdycjaCzasuPicker;
        private System.Windows.Forms.DateTimePicker EdycjaDatyPicker;
        private System.Windows.Forms.Button EdytujFaktureButton;
        private System.Windows.Forms.Button UsunFaktureButton;
        private System.Windows.Forms.TextBox EdytujFirme;
        private System.Windows.Forms.Button ZapiszZmianyButton;
        private System.Windows.Forms.Button AnulujEdycjeButton;
    }
}
