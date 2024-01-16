namespace DigitalGameStoreDBViewer
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPageUtenti.Controls.Add(this.label1);
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
            this.radioButtonUtentiEmail.Location = new System.Drawing.Point(12, 149);
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
            this.radioButtonUtentiGamertag.Location = new System.Drawing.Point(12, 119);
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
            this.labelUtentiFiltra.Location = new System.Drawing.Point(7, 87);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ricerca";
            // 
            // textBoxUtentiSearch
            // 
            this.textBoxUtentiSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtentiSearch.Location = new System.Drawing.Point(7, 36);
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
            // 
            // tabPageAcquisti
            // 
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageAcquisti.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
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
    }
}

