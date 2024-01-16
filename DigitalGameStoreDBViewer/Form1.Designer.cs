﻿namespace DigitalGameStoreDBViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUtenti = new System.Windows.Forms.TabPage();
            this.radioButtonUtentiEmail = new System.Windows.Forms.RadioButton();
            this.radioButtonUtentiGamertag = new System.Windows.Forms.RadioButton();
            this.labelUtentiFiltra = new System.Windows.Forms.Label();
            this.labelUtentiPassword = new System.Windows.Forms.Label();
            this.textBoxUtentiPassword = new System.Windows.Forms.TextBox();
            this.labelUtentiEmail = new System.Windows.Forms.Label();
            this.textBoxUtentiEmail = new System.Windows.Forms.TextBox();
            this.labelUtentiGamertag = new System.Windows.Forms.Label();
            this.labelUtentiRicerca = new System.Windows.Forms.Label();
            this.textBoxUtentiSearch = new System.Windows.Forms.TextBox();
            this.textBoxUtentiGamertag = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageProdotti = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageAcquisti = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageRecensioni = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPagePromozioni = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.radioButtonProdottiNome = new System.Windows.Forms.RadioButton();
            this.labelProdottiFiltra = new System.Windows.Forms.Label();
            this.labelProdottiRicerca = new System.Windows.Forms.Label();
            this.textBoxProdottiSearch = new System.Windows.Forms.TextBox();
            this.radioButtonProdottiCategoria = new System.Windows.Forms.RadioButton();
            this.labelProdottiPrezzo = new System.Windows.Forms.Label();
            this.textBoxProdottiPrezzo = new System.Windows.Forms.TextBox();
            this.labelProdottiNome = new System.Windows.Forms.Label();
            this.textBoxProdottiNome = new System.Windows.Forms.TextBox();
            this.labelProdottiId = new System.Windows.Forms.Label();
            this.textBoxProdottiId = new System.Windows.Forms.TextBox();
            this.labelProdottiCategoria = new System.Windows.Forms.Label();
            this.textBoxProdottiCategoria = new System.Windows.Forms.TextBox();
            this.labelProdottiSviluppatore = new System.Windows.Forms.Label();
            this.textBoxProdottiSviluppatore = new System.Windows.Forms.TextBox();
            this.labelProdottiPubblicatore = new System.Windows.Forms.Label();
            this.textBoxProdottiPubblicatore = new System.Windows.Forms.TextBox();
            this.radioButtonAcquistiStato = new System.Windows.Forms.RadioButton();
            this.radioButtonAcquistiGamertag = new System.Windows.Forms.RadioButton();
            this.labelAcquistiFiltra = new System.Windows.Forms.Label();
            this.labelAcquistiRicerca = new System.Windows.Forms.Label();
            this.textBoxAcquistiSearch = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageUtenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageAcquisti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageRecensioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPagePromozioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUtenti);
            this.tabControl.Controls.Add(this.tabPageProdotti);
            this.tabControl.Controls.Add(this.tabPageAcquisti);
            this.tabControl.Controls.Add(this.tabPageRecensioni);
            this.tabControl.Controls.Add(this.tabPagePromozioni);
            this.tabControl.Location = new System.Drawing.Point(18, 18);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1164, 655);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageUtenti
            // 
            this.tabPageUtenti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUtenti.Controls.Add(this.radioButtonUtentiEmail);
            this.tabPageUtenti.Controls.Add(this.radioButtonUtentiGamertag);
            this.tabPageUtenti.Controls.Add(this.labelUtentiFiltra);
            this.tabPageUtenti.Controls.Add(this.labelUtentiPassword);
            this.tabPageUtenti.Controls.Add(this.textBoxUtentiPassword);
            this.tabPageUtenti.Controls.Add(this.labelUtentiEmail);
            this.tabPageUtenti.Controls.Add(this.textBoxUtentiEmail);
            this.tabPageUtenti.Controls.Add(this.labelUtentiGamertag);
            this.tabPageUtenti.Controls.Add(this.labelUtentiRicerca);
            this.tabPageUtenti.Controls.Add(this.textBoxUtentiSearch);
            this.tabPageUtenti.Controls.Add(this.textBoxUtentiGamertag);
            this.tabPageUtenti.Controls.Add(this.dataGridView1);
            this.tabPageUtenti.Location = new System.Drawing.Point(4, 29);
            this.tabPageUtenti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUtenti.Name = "tabPageUtenti";
            this.tabPageUtenti.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUtenti.Size = new System.Drawing.Size(1156, 622);
            this.tabPageUtenti.TabIndex = 0;
            this.tabPageUtenti.Text = "Utenti";
            // 
            // radioButtonUtentiEmail
            // 
            this.radioButtonUtentiEmail.AutoSize = true;
            this.radioButtonUtentiEmail.Location = new System.Drawing.Point(12, 155);
            this.radioButtonUtentiEmail.Name = "radioButtonUtentiEmail";
            this.radioButtonUtentiEmail.Size = new System.Drawing.Size(73, 24);
            this.radioButtonUtentiEmail.TabIndex = 16;
            this.radioButtonUtentiEmail.Text = "Email";
            this.radioButtonUtentiEmail.UseVisualStyleBackColor = true;
            // 
            // radioButtonUtentiGamertag
            // 
            this.radioButtonUtentiGamertag.AutoSize = true;
            this.radioButtonUtentiGamertag.Checked = true;
            this.radioButtonUtentiGamertag.Location = new System.Drawing.Point(12, 125);
            this.radioButtonUtentiGamertag.Name = "radioButtonUtentiGamertag";
            this.radioButtonUtentiGamertag.Size = new System.Drawing.Size(106, 24);
            this.radioButtonUtentiGamertag.TabIndex = 15;
            this.radioButtonUtentiGamertag.TabStop = true;
            this.radioButtonUtentiGamertag.Text = "Gamertag";
            this.radioButtonUtentiGamertag.UseVisualStyleBackColor = true;
            // 
            // labelUtentiFiltra
            // 
            this.labelUtentiFiltra.AutoSize = true;
            this.labelUtentiFiltra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtentiFiltra.Location = new System.Drawing.Point(7, 93);
            this.labelUtentiFiltra.Name = "labelUtentiFiltra";
            this.labelUtentiFiltra.Size = new System.Drawing.Size(115, 29);
            this.labelUtentiFiltra.TabIndex = 14;
            this.labelUtentiFiltra.Text = "Filtra per:";
            // 
            // labelUtentiPassword
            // 
            this.labelUtentiPassword.AutoSize = true;
            this.labelUtentiPassword.Location = new System.Drawing.Point(7, 364);
            this.labelUtentiPassword.Name = "labelUtentiPassword";
            this.labelUtentiPassword.Size = new System.Drawing.Size(78, 20);
            this.labelUtentiPassword.TabIndex = 11;
            this.labelUtentiPassword.Text = "Password";
            // 
            // textBoxUtentiPassword
            // 
            this.textBoxUtentiPassword.Location = new System.Drawing.Point(11, 387);
            this.textBoxUtentiPassword.Name = "textBoxUtentiPassword";
            this.textBoxUtentiPassword.Size = new System.Drawing.Size(286, 26);
            this.textBoxUtentiPassword.TabIndex = 10;
            // 
            // labelUtentiEmail
            // 
            this.labelUtentiEmail.AutoSize = true;
            this.labelUtentiEmail.Location = new System.Drawing.Point(7, 286);
            this.labelUtentiEmail.Name = "labelUtentiEmail";
            this.labelUtentiEmail.Size = new System.Drawing.Size(48, 20);
            this.labelUtentiEmail.TabIndex = 9;
            this.labelUtentiEmail.Text = "Email";
            // 
            // textBoxUtentiEmail
            // 
            this.textBoxUtentiEmail.Location = new System.Drawing.Point(11, 309);
            this.textBoxUtentiEmail.Name = "textBoxUtentiEmail";
            this.textBoxUtentiEmail.Size = new System.Drawing.Size(286, 26);
            this.textBoxUtentiEmail.TabIndex = 8;
            // 
            // labelUtentiGamertag
            // 
            this.labelUtentiGamertag.AutoSize = true;
            this.labelUtentiGamertag.Location = new System.Drawing.Point(7, 207);
            this.labelUtentiGamertag.Name = "labelUtentiGamertag";
            this.labelUtentiGamertag.Size = new System.Drawing.Size(81, 20);
            this.labelUtentiGamertag.TabIndex = 7;
            this.labelUtentiGamertag.Text = "Gamertag";
            // 
            // labelUtentiRicerca
            // 
            this.labelUtentiRicerca.AutoSize = true;
            this.labelUtentiRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtentiRicerca.Location = new System.Drawing.Point(7, 10);
            this.labelUtentiRicerca.Name = "labelUtentiRicerca";
            this.labelUtentiRicerca.Size = new System.Drawing.Size(95, 29);
            this.labelUtentiRicerca.TabIndex = 6;
            this.labelUtentiRicerca.Text = "Ricerca";
            // 
            // textBoxUtentiSearch
            // 
            this.textBoxUtentiSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtentiSearch.Location = new System.Drawing.Point(7, 42);
            this.textBoxUtentiSearch.Name = "textBoxUtentiSearch";
            this.textBoxUtentiSearch.Size = new System.Drawing.Size(356, 35);
            this.textBoxUtentiSearch.TabIndex = 5;
            this.textBoxUtentiSearch.TextChanged += new System.EventHandler(this.textBoxSearch1_TextChanged);
            // 
            // textBoxUtentiGamertag
            // 
            this.textBoxUtentiGamertag.Location = new System.Drawing.Point(11, 230);
            this.textBoxUtentiGamertag.Name = "textBoxUtentiGamertag";
            this.textBoxUtentiGamertag.Size = new System.Drawing.Size(286, 26);
            this.textBoxUtentiGamertag.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(750, 582);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabPageProdotti
            // 
            this.tabPageProdotti.Controls.Add(this.labelProdottiPubblicatore);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiPubblicatore);
            this.tabPageProdotti.Controls.Add(this.labelProdottiSviluppatore);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiSviluppatore);
            this.tabPageProdotti.Controls.Add(this.labelProdottiCategoria);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiCategoria);
            this.tabPageProdotti.Controls.Add(this.labelProdottiPrezzo);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiPrezzo);
            this.tabPageProdotti.Controls.Add(this.labelProdottiNome);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiNome);
            this.tabPageProdotti.Controls.Add(this.labelProdottiId);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiId);
            this.tabPageProdotti.Controls.Add(this.radioButtonProdottiCategoria);
            this.tabPageProdotti.Controls.Add(this.radioButtonProdottiNome);
            this.tabPageProdotti.Controls.Add(this.labelProdottiFiltra);
            this.tabPageProdotti.Controls.Add(this.labelProdottiRicerca);
            this.tabPageProdotti.Controls.Add(this.textBoxProdottiSearch);
            this.tabPageProdotti.Controls.Add(this.dataGridView2);
            this.tabPageProdotti.Location = new System.Drawing.Point(4, 29);
            this.tabPageProdotti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageProdotti.Name = "tabPageProdotti";
            this.tabPageProdotti.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageProdotti.Size = new System.Drawing.Size(1156, 622);
            this.tabPageProdotti.TabIndex = 1;
            this.tabPageProdotti.Text = "Prodotti";
            this.tabPageProdotti.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(398, 10);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(750, 582);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // tabPageAcquisti
            // 
            this.tabPageAcquisti.Controls.Add(this.radioButtonAcquistiStato);
            this.tabPageAcquisti.Controls.Add(this.radioButtonAcquistiGamertag);
            this.tabPageAcquisti.Controls.Add(this.labelAcquistiFiltra);
            this.tabPageAcquisti.Controls.Add(this.labelAcquistiRicerca);
            this.tabPageAcquisti.Controls.Add(this.textBoxAcquistiSearch);
            this.tabPageAcquisti.Controls.Add(this.dataGridView3);
            this.tabPageAcquisti.Location = new System.Drawing.Point(4, 29);
            this.tabPageAcquisti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAcquisti.Name = "tabPageAcquisti";
            this.tabPageAcquisti.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAcquisti.Size = new System.Drawing.Size(1156, 622);
            this.tabPageAcquisti.TabIndex = 2;
            this.tabPageAcquisti.Text = "Acquisti";
            this.tabPageAcquisti.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(398, 10);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(750, 582);
            this.dataGridView3.TabIndex = 3;
            // 
            // tabPageRecensioni
            // 
            this.tabPageRecensioni.Controls.Add(this.dataGridView4);
            this.tabPageRecensioni.Location = new System.Drawing.Point(4, 29);
            this.tabPageRecensioni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRecensioni.Name = "tabPageRecensioni";
            this.tabPageRecensioni.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRecensioni.Size = new System.Drawing.Size(1156, 622);
            this.tabPageRecensioni.TabIndex = 3;
            this.tabPageRecensioni.Text = "Recensioni";
            this.tabPageRecensioni.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(398, 10);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.Size = new System.Drawing.Size(750, 582);
            this.dataGridView4.TabIndex = 3;
            // 
            // tabPagePromozioni
            // 
            this.tabPagePromozioni.Controls.Add(this.dataGridView5);
            this.tabPagePromozioni.Location = new System.Drawing.Point(4, 29);
            this.tabPagePromozioni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePromozioni.Name = "tabPagePromozioni";
            this.tabPagePromozioni.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPagePromozioni.Size = new System.Drawing.Size(1156, 622);
            this.tabPagePromozioni.TabIndex = 4;
            this.tabPagePromozioni.Text = "Promozioni";
            this.tabPagePromozioni.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(398, 10);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(750, 582);
            this.dataGridView5.TabIndex = 3;
            // 
            // radioButtonProdottiNome
            // 
            this.radioButtonProdottiNome.AutoSize = true;
            this.radioButtonProdottiNome.Checked = true;
            this.radioButtonProdottiNome.Location = new System.Drawing.Point(12, 125);
            this.radioButtonProdottiNome.Name = "radioButtonProdottiNome";
            this.radioButtonProdottiNome.Size = new System.Drawing.Size(76, 24);
            this.radioButtonProdottiNome.TabIndex = 20;
            this.radioButtonProdottiNome.TabStop = true;
            this.radioButtonProdottiNome.Text = "Nome";
            this.radioButtonProdottiNome.UseVisualStyleBackColor = true;
            // 
            // labelProdottiFiltra
            // 
            this.labelProdottiFiltra.AutoSize = true;
            this.labelProdottiFiltra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdottiFiltra.Location = new System.Drawing.Point(7, 93);
            this.labelProdottiFiltra.Name = "labelProdottiFiltra";
            this.labelProdottiFiltra.Size = new System.Drawing.Size(115, 29);
            this.labelProdottiFiltra.TabIndex = 19;
            this.labelProdottiFiltra.Text = "Filtra per:";
            // 
            // labelProdottiRicerca
            // 
            this.labelProdottiRicerca.AutoSize = true;
            this.labelProdottiRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdottiRicerca.Location = new System.Drawing.Point(7, 10);
            this.labelProdottiRicerca.Name = "labelProdottiRicerca";
            this.labelProdottiRicerca.Size = new System.Drawing.Size(95, 29);
            this.labelProdottiRicerca.TabIndex = 18;
            this.labelProdottiRicerca.Text = "Ricerca";
            // 
            // textBoxProdottiSearch
            // 
            this.textBoxProdottiSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdottiSearch.Location = new System.Drawing.Point(7, 42);
            this.textBoxProdottiSearch.Name = "textBoxProdottiSearch";
            this.textBoxProdottiSearch.Size = new System.Drawing.Size(356, 35);
            this.textBoxProdottiSearch.TabIndex = 17;
            this.textBoxProdottiSearch.TextChanged += new System.EventHandler(this.textBoxProdottiSearch_TextChanged);
            // 
            // radioButtonProdottiCategoria
            // 
            this.radioButtonProdottiCategoria.AutoSize = true;
            this.radioButtonProdottiCategoria.Location = new System.Drawing.Point(12, 155);
            this.radioButtonProdottiCategoria.Name = "radioButtonProdottiCategoria";
            this.radioButtonProdottiCategoria.Size = new System.Drawing.Size(103, 24);
            this.radioButtonProdottiCategoria.TabIndex = 22;
            this.radioButtonProdottiCategoria.Text = "Categoria";
            this.radioButtonProdottiCategoria.UseVisualStyleBackColor = true;
            // 
            // labelProdottiPrezzo
            // 
            this.labelProdottiPrezzo.AutoSize = true;
            this.labelProdottiPrezzo.Location = new System.Drawing.Point(8, 336);
            this.labelProdottiPrezzo.Name = "labelProdottiPrezzo";
            this.labelProdottiPrezzo.Size = new System.Drawing.Size(58, 20);
            this.labelProdottiPrezzo.TabIndex = 28;
            this.labelProdottiPrezzo.Text = "Prezzo";
            // 
            // textBoxProdottiPrezzo
            // 
            this.textBoxProdottiPrezzo.Location = new System.Drawing.Point(12, 359);
            this.textBoxProdottiPrezzo.Name = "textBoxProdottiPrezzo";
            this.textBoxProdottiPrezzo.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiPrezzo.TabIndex = 27;
            // 
            // labelProdottiNome
            // 
            this.labelProdottiNome.AutoSize = true;
            this.labelProdottiNome.Location = new System.Drawing.Point(8, 269);
            this.labelProdottiNome.Name = "labelProdottiNome";
            this.labelProdottiNome.Size = new System.Drawing.Size(51, 20);
            this.labelProdottiNome.TabIndex = 26;
            this.labelProdottiNome.Text = "Nome";
            // 
            // textBoxProdottiNome
            // 
            this.textBoxProdottiNome.Location = new System.Drawing.Point(12, 292);
            this.textBoxProdottiNome.Name = "textBoxProdottiNome";
            this.textBoxProdottiNome.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiNome.TabIndex = 25;
            // 
            // labelProdottiId
            // 
            this.labelProdottiId.AutoSize = true;
            this.labelProdottiId.Location = new System.Drawing.Point(8, 203);
            this.labelProdottiId.Name = "labelProdottiId";
            this.labelProdottiId.Size = new System.Drawing.Size(23, 20);
            this.labelProdottiId.TabIndex = 24;
            this.labelProdottiId.Text = "Id";
            // 
            // textBoxProdottiId
            // 
            this.textBoxProdottiId.Location = new System.Drawing.Point(12, 226);
            this.textBoxProdottiId.Name = "textBoxProdottiId";
            this.textBoxProdottiId.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiId.TabIndex = 23;
            // 
            // labelProdottiCategoria
            // 
            this.labelProdottiCategoria.AutoSize = true;
            this.labelProdottiCategoria.Location = new System.Drawing.Point(8, 401);
            this.labelProdottiCategoria.Name = "labelProdottiCategoria";
            this.labelProdottiCategoria.Size = new System.Drawing.Size(78, 20);
            this.labelProdottiCategoria.TabIndex = 30;
            this.labelProdottiCategoria.Text = "Categoria";
            // 
            // textBoxProdottiCategoria
            // 
            this.textBoxProdottiCategoria.Location = new System.Drawing.Point(12, 424);
            this.textBoxProdottiCategoria.Name = "textBoxProdottiCategoria";
            this.textBoxProdottiCategoria.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiCategoria.TabIndex = 29;
            // 
            // labelProdottiSviluppatore
            // 
            this.labelProdottiSviluppatore.AutoSize = true;
            this.labelProdottiSviluppatore.Location = new System.Drawing.Point(8, 465);
            this.labelProdottiSviluppatore.Name = "labelProdottiSviluppatore";
            this.labelProdottiSviluppatore.Size = new System.Drawing.Size(97, 20);
            this.labelProdottiSviluppatore.TabIndex = 32;
            this.labelProdottiSviluppatore.Text = "Sviluppatore";
            // 
            // textBoxProdottiSviluppatore
            // 
            this.textBoxProdottiSviluppatore.Location = new System.Drawing.Point(12, 488);
            this.textBoxProdottiSviluppatore.Name = "textBoxProdottiSviluppatore";
            this.textBoxProdottiSviluppatore.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiSviluppatore.TabIndex = 31;
            // 
            // labelProdottiPubblicatore
            // 
            this.labelProdottiPubblicatore.AutoSize = true;
            this.labelProdottiPubblicatore.Location = new System.Drawing.Point(8, 529);
            this.labelProdottiPubblicatore.Name = "labelProdottiPubblicatore";
            this.labelProdottiPubblicatore.Size = new System.Drawing.Size(97, 20);
            this.labelProdottiPubblicatore.TabIndex = 34;
            this.labelProdottiPubblicatore.Text = "Pubblicatore";
            // 
            // textBoxProdottiPubblicatore
            // 
            this.textBoxProdottiPubblicatore.Location = new System.Drawing.Point(12, 552);
            this.textBoxProdottiPubblicatore.Name = "textBoxProdottiPubblicatore";
            this.textBoxProdottiPubblicatore.Size = new System.Drawing.Size(286, 26);
            this.textBoxProdottiPubblicatore.TabIndex = 33;
            // 
            // radioButtonAcquistiStato
            // 
            this.radioButtonAcquistiStato.AutoSize = true;
            this.radioButtonAcquistiStato.Location = new System.Drawing.Point(12, 155);
            this.radioButtonAcquistiStato.Name = "radioButtonAcquistiStato";
            this.radioButtonAcquistiStato.Size = new System.Drawing.Size(73, 24);
            this.radioButtonAcquistiStato.TabIndex = 21;
            this.radioButtonAcquistiStato.Text = "Email";
            this.radioButtonAcquistiStato.UseVisualStyleBackColor = true;
            // 
            // radioButtonAcquistiGamertag
            // 
            this.radioButtonAcquistiGamertag.AutoSize = true;
            this.radioButtonAcquistiGamertag.Checked = true;
            this.radioButtonAcquistiGamertag.Location = new System.Drawing.Point(12, 125);
            this.radioButtonAcquistiGamertag.Name = "radioButtonAcquistiGamertag";
            this.radioButtonAcquistiGamertag.Size = new System.Drawing.Size(106, 24);
            this.radioButtonAcquistiGamertag.TabIndex = 20;
            this.radioButtonAcquistiGamertag.TabStop = true;
            this.radioButtonAcquistiGamertag.Text = "Gamertag";
            this.radioButtonAcquistiGamertag.UseVisualStyleBackColor = true;
            // 
            // labelAcquistiFiltra
            // 
            this.labelAcquistiFiltra.AutoSize = true;
            this.labelAcquistiFiltra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcquistiFiltra.Location = new System.Drawing.Point(7, 93);
            this.labelAcquistiFiltra.Name = "labelAcquistiFiltra";
            this.labelAcquistiFiltra.Size = new System.Drawing.Size(115, 29);
            this.labelAcquistiFiltra.TabIndex = 19;
            this.labelAcquistiFiltra.Text = "Filtra per:";
            // 
            // labelAcquistiRicerca
            // 
            this.labelAcquistiRicerca.AutoSize = true;
            this.labelAcquistiRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcquistiRicerca.Location = new System.Drawing.Point(7, 10);
            this.labelAcquistiRicerca.Name = "labelAcquistiRicerca";
            this.labelAcquistiRicerca.Size = new System.Drawing.Size(95, 29);
            this.labelAcquistiRicerca.TabIndex = 18;
            this.labelAcquistiRicerca.Text = "Ricerca";
            // 
            // textBoxAcquistiSearch
            // 
            this.textBoxAcquistiSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAcquistiSearch.Location = new System.Drawing.Point(7, 42);
            this.textBoxAcquistiSearch.Name = "textBoxAcquistiSearch";
            this.textBoxAcquistiSearch.Size = new System.Drawing.Size(356, 35);
            this.textBoxAcquistiSearch.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DigitalGameStoreDBViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageUtenti.ResumeLayout(false);
            this.tabPageUtenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageProdotti.ResumeLayout(false);
            this.tabPageProdotti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageAcquisti.ResumeLayout(false);
            this.tabPageAcquisti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageRecensioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPagePromozioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUtenti;
        private System.Windows.Forms.TabPage tabPageProdotti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageAcquisti;
        private System.Windows.Forms.TabPage tabPageRecensioni;
        private System.Windows.Forms.TabPage tabPagePromozioni;
        private System.Windows.Forms.TextBox textBoxUtentiGamertag;
        private System.Windows.Forms.TextBox textBoxUtentiSearch;
        private System.Windows.Forms.Label labelUtentiRicerca;
        private System.Windows.Forms.Label labelUtentiGamertag;
        private System.Windows.Forms.Label labelUtentiPassword;
        private System.Windows.Forms.TextBox textBoxUtentiPassword;
        private System.Windows.Forms.Label labelUtentiEmail;
        private System.Windows.Forms.TextBox textBoxUtentiEmail;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label labelUtentiFiltra;
        private System.Windows.Forms.RadioButton radioButtonUtentiEmail;
        private System.Windows.Forms.RadioButton radioButtonUtentiGamertag;
        private System.Windows.Forms.RadioButton radioButtonProdottiNome;
        private System.Windows.Forms.Label labelProdottiFiltra;
        private System.Windows.Forms.Label labelProdottiRicerca;
        private System.Windows.Forms.TextBox textBoxProdottiSearch;
        private System.Windows.Forms.RadioButton radioButtonProdottiCategoria;
        private System.Windows.Forms.Label labelProdottiPubblicatore;
        private System.Windows.Forms.TextBox textBoxProdottiPubblicatore;
        private System.Windows.Forms.Label labelProdottiSviluppatore;
        private System.Windows.Forms.TextBox textBoxProdottiSviluppatore;
        private System.Windows.Forms.Label labelProdottiCategoria;
        private System.Windows.Forms.TextBox textBoxProdottiCategoria;
        private System.Windows.Forms.Label labelProdottiPrezzo;
        private System.Windows.Forms.TextBox textBoxProdottiPrezzo;
        private System.Windows.Forms.Label labelProdottiNome;
        private System.Windows.Forms.TextBox textBoxProdottiNome;
        private System.Windows.Forms.Label labelProdottiId;
        private System.Windows.Forms.TextBox textBoxProdottiId;
        private System.Windows.Forms.RadioButton radioButtonAcquistiStato;
        private System.Windows.Forms.RadioButton radioButtonAcquistiGamertag;
        private System.Windows.Forms.Label labelAcquistiFiltra;
        private System.Windows.Forms.Label labelAcquistiRicerca;
        private System.Windows.Forms.TextBox textBoxAcquistiSearch;
    }
}

