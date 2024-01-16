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
        }
    }
}
