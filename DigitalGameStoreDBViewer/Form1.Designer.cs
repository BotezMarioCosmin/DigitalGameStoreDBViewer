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
            this.tabPageProdotti = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageAcquisti = new System.Windows.Forms.TabPage();
            this.tabPageRecensioni = new System.Windows.Forms.TabPage();
            this.tabPagePromozioni = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageUtenti.SuspendLayout();
            this.tabPageProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAcquisti.SuspendLayout();
            this.tabPageRecensioni.SuspendLayout();
            this.tabPagePromozioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageUtenti
            // 
            this.tabPageUtenti.Controls.Add(this.button1);
            this.tabPageUtenti.Controls.Add(this.dataGridView1);
            this.tabPageUtenti.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtenti.Name = "tabPageUtenti";
            this.tabPageUtenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUtenti.Size = new System.Drawing.Size(768, 400);
            this.tabPageUtenti.TabIndex = 0;
            this.tabPageUtenti.Text = "Utenti";
            this.tabPageUtenti.UseVisualStyleBackColor = true;
            // 
            // tabPageProdotti
            // 
            this.tabPageProdotti.Controls.Add(this.dataGridView2);
            this.tabPageProdotti.Location = new System.Drawing.Point(4, 22);
            this.tabPageProdotti.Name = "tabPageProdotti";
            this.tabPageProdotti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProdotti.Size = new System.Drawing.Size(768, 400);
            this.tabPageProdotti.TabIndex = 1;
            this.tabPageProdotti.Text = "Prodotti";
            this.tabPageProdotti.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(337, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(425, 378);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 378);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabPageAcquisti
            // 
            this.tabPageAcquisti.Controls.Add(this.dataGridView3);
            this.tabPageAcquisti.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcquisti.Name = "tabPageAcquisti";
            this.tabPageAcquisti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcquisti.Size = new System.Drawing.Size(768, 400);
            this.tabPageAcquisti.TabIndex = 2;
            this.tabPageAcquisti.Text = "Acquisti";
            this.tabPageAcquisti.UseVisualStyleBackColor = true;
            // 
            // tabPageRecensioni
            // 
            this.tabPageRecensioni.Controls.Add(this.dataGridView4);
            this.tabPageRecensioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecensioni.Name = "tabPageRecensioni";
            this.tabPageRecensioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecensioni.Size = new System.Drawing.Size(768, 400);
            this.tabPageRecensioni.TabIndex = 3;
            this.tabPageRecensioni.Text = "Recensioni";
            this.tabPageRecensioni.UseVisualStyleBackColor = true;
            // 
            // tabPagePromozioni
            // 
            this.tabPagePromozioni.Controls.Add(this.dataGridView5);
            this.tabPagePromozioni.Location = new System.Drawing.Point(4, 22);
            this.tabPagePromozioni.Name = "tabPagePromozioni";
            this.tabPagePromozioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePromozioni.Size = new System.Drawing.Size(768, 400);
            this.tabPagePromozioni.TabIndex = 4;
            this.tabPagePromozioni.Text = "Promozioni";
            this.tabPagePromozioni.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(337, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(425, 378);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(337, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(425, 378);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(337, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(425, 378);
            this.dataGridView5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "DigitalGameStoreDBViewer";
            this.tabControl.ResumeLayout(false);
            this.tabPageUtenti.ResumeLayout(false);
            this.tabPageProdotti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAcquisti.ResumeLayout(false);
            this.tabPageRecensioni.ResumeLayout(false);
            this.tabPagePromozioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUtenti;
        private System.Windows.Forms.TabPage tabPageProdotti;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageAcquisti;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPageRecensioni;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPagePromozioni;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button1;
    }
}

