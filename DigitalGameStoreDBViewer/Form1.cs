using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalGameStoreDBViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDataIntoGridView()
        {
            try
            {
                String ConnectionString = "server=127.0.0.1;uid=programma;pwd=12345;database=digitalgamestore";
                MySqlConnection conn = new MySqlConnection(ConnectionString);

                conn.Open();

                String sql1 = "select * from utenti;";

                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd1;
                DataTable dati = new DataTable();
                MyAdapter.Fill(dati);
                dataGridView1.DataSource = dati;
                conn.Close();

                //////

                conn.Open();

                sql1 = "select * from prodotti;";

                cmd1 = new MySqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd1;
                dati = new DataTable();
                MyAdapter.Fill(dati);
                dataGridView2.DataSource = dati;
                conn.Close();

                //////

                conn.Open();

                sql1 = "select * from acquisti;";

                cmd1 = new MySqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd1;
                dati = new DataTable();
                MyAdapter.Fill(dati);
                dataGridView3.DataSource = dati;
                conn.Close();

                //////
               
                conn.Open();

                sql1 = "select * from recensioni;";

                cmd1 = new MySqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd1;
                dati = new DataTable();
                MyAdapter.Fill(dati);
                dataGridView4.DataSource = dati;
                conn.Close();

                //////

                conn.Open();

                sql1 = "select * from promozioni;";

                cmd1 = new MySqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd1;
                dati = new DataTable();
                MyAdapter.Fill(dati);
                dataGridView5.DataSource = dati;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabControl.SelectedIndex = 0;

            LoadDataIntoGridView();

            textBoxUtentiSearch.Select();
            textBoxProdottiSearch.Select();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selezionati = dataGridView1.SelectedRows.Count;
            if (selezionati > 0)
            {
                textBoxUtentiGamertag.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxUtentiEmail.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxUtentiPassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void textBoxSearch1_TextChanged(object sender, EventArgs e)
        {
            //qundo cambia testo barra ricerca
            string searchKeyword = textBoxUtentiSearch.Text.Trim();

            //filtro campi
            FilterData(searchKeyword, dataGridView1);
        }


        private void FilterData(string keyword, DataGridView dataGridView)
        {
 
            DataTable originalDataTable = (DataTable)dataGridView.Tag;

            if (originalDataTable == null)
            {
                originalDataTable = (DataTable)dataGridView.DataSource;
                dataGridView.Tag = originalDataTable;
            }

            if (string.IsNullOrWhiteSpace(keyword))
            {
                //se barra di ricerca null allora gridview torna come prima
                dataGridView.DataSource = originalDataTable;
            }
            else
            {
                if (dataGridView.Name == "dataGridView1")
                {
                    if (radioButtonUtentiGamertag.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"gamertag LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                    else if (radioButtonUtentiEmail.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"email LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }

                }
                else if (dataGridView.Name == "dataGridView2")
                {
                    if (radioButtonProdottiNome.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"nome LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                    else if (radioButtonProdottiCategoria.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"categoria LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                }
                else if (dataGridView.Name == "dataGridView3")
                {
                    if (radioButtonAcquistiGamertag.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"gamertag LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                    else if (radioButtonAcquistiStato.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"statoordine LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                }
                else if (dataGridView.Name == "dataGridView4")
                {
                    if (radioButtonRecensioniGamertag.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"gamertag LIKE '{keyword}%'";
                        dataGridView.DataSource = dv.ToTable();
                    }
                    else if (radioButtonRecensioniValutazione.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"valutazione = {Convert.ToInt32(keyword)}";
                        dataGridView.DataSource = dv.ToTable();
                    }
                }
                else if (dataGridView.Name == "dataGridView5")
                {
                    if (radioButtonPromozioniSconto.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"sconto = {Convert.ToInt32(keyword)}";
                        dataGridView.DataSource = dv.ToTable();
                    }
                    else if (radioButtonPromozioniProdottoId.Checked)
                    {
                        DataView dv = new DataView(originalDataTable);
                        dv.RowFilter = $"prodottoid = {Convert.ToInt32(keyword)}";
                        dataGridView.DataSource = dv.ToTable();
                    }
                }
            }
        }
        private void textBoxProdottiSearch_TextChanged(object sender, EventArgs e)
        {
            //qundo cambia testo barra ricerca
            string searchKeyword = textBoxProdottiSearch.Text.Trim();

            //filtro campi
            FilterData(searchKeyword, dataGridView2);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int selezionati = dataGridView2.SelectedRows.Count;
            if (selezionati > 0)
            {
                textBoxProdottiId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBoxProdottiNome.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBoxProdottiPrezzo.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBoxProdottiCategoria.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBoxProdottiSviluppatore.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBoxProdottiPubblicatore.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            int selezionati = dataGridView3.SelectedRows.Count;
            if (selezionati > 0)
            {
                textBoxAcquistiId.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                textBoxAcquistiGamertag.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                textBoxAcquistiProdottoId.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                textBoxAcquistiImporto.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                textBoxAcquistiDataOrdine.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                textBoxAcquistiStato.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void textBoxAcquistiSearch_TextChanged(object sender, EventArgs e)
        {
            //qundo cambia testo barra ricerca
            string searchKeyword = textBoxAcquistiSearch.Text.Trim();

            //filtro campi
            FilterData(searchKeyword, dataGridView3);
        }

        private void textBoxRecensioniSearch_TextChanged(object sender, EventArgs e)
        {
            //qundo cambia testo barra ricerca
            string searchKeyword = textBoxRecensioniSearch.Text.Trim();

            //filtro campi
            FilterData(searchKeyword, dataGridView4);
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            int selezionati = dataGridView4.SelectedRows.Count;
            if (selezionati > 0)
            {
                textBoxRecensioniId.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                textBoxRecensioniGamertag.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                textBoxRecensioniProdottoId.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
                textBoxRecensioniValutazione.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
                textBoxRecensioniCommento.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
                textBoxRecensioniData.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            int selezionati = dataGridView5.SelectedRows.Count;
            if (selezionati > 0)
            {
                textBoxPromozioniId.Text = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPromozioniProdottoId.Text = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPromozioniSconto.Text = dataGridView5.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPromozioniDataInizio.Text = dataGridView5.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPromozioniDataFine.Text = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
               
            }
        }

        private void textBoxPromozioniSearch_TextChanged(object sender, EventArgs e)
        {
            //qundo cambia testo barra ricerca
            string searchKeyword = textBoxPromozioniSearch.Text.Trim();

            //filtro campi
            FilterData(searchKeyword, dataGridView5);
        }
    }
}
