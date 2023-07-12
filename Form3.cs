using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_akhir
{
    public partial class DataKamar : Form
    {
        private string stringConnection = "data source=DKRZ\\MUHDAVIN;" + "database=Puskesmas_super;user ID=sa;Password=123";
        private SqlConnection koneksi;
        public DataKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_kamar"].Value.ToString();
            string idKamar = textBox1.Text;
            string Nokamar = textBox2.Text;
            string Tipe = textBox3.Text;

            if (id == "")
            {
                MessageBox.Show("id kamar tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idKamar == "")
            {
                MessageBox.Show("Masukan Id kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Nokamar == "")
            {
                MessageBox.Show("Masukan no kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Tipe == "")
            {
                MessageBox.Show("Masukan Tipe kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE Dokter SET id_kamar = @id_kamar, no_kamar = @no_kamar, tipe = @tipe";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_dokter", idKamar);
                command.Parameters.AddWithValue("@nama_dokter", Nokamar);
                command.Parameters.AddWithValue("@spesialis", Tipe);
                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data telah update", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        GetDataFromDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void DataKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet4.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.puskesmas_superDataSet4.Kamar);

        }
        private void refreshform()
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox2.Enabled = true;
            textBox3.Text = "";
            textBox3.Enabled = true;
            button1.Enabled = true;
        }
    }
}
