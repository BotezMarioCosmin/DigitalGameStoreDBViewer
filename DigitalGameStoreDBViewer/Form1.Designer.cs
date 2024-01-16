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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageProdotti = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageAcquisti = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageRecensioni = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPagePromozioni = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabPageUtenti.Controls.Add(this.textBox1);
            this.tabPageUtenti.Controls.Add(this.dataGridView1);
            this.tabPageUtenti.Location = new System.Drawing.Point(4, 29);
            this.tabPageUtenti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUtenti.Name = "tabPageUtenti";
            this.tabPageUtenti.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUtenti.Size = new System.Drawing.Size(1156, 622);
            this.tabPageUtenti.TabIndex = 0;
            this.tabPageUtenti.Text = "Utenti";
            this.tabPageUtenti.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(638, 582);
            this.dataGridView1.TabIndex = 2;
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
            this.dataGridView2.Location = new System.Drawing.Point(506, 9);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(638, 582);
            this.dataGridView2.TabIndex = 1;
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
            this.dataGridView3.Location = new System.Drawing.Point(506, 9);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(638, 582);
            this.dataGridView3.TabIndex = 2;
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
            this.dataGridView4.Location = new System.Drawing.Point(506, 9);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.Size = new System.Drawing.Size(638, 582);
            this.dataGridView4.TabIndex = 2;
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
            this.dataGridView5.Location = new System.Drawing.Point(506, 9);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.Size = new System.Drawing.Size(638, 582);
            this.dataGridView5.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageAcquisti;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPageRecensioni;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tabPagePromozioni;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

