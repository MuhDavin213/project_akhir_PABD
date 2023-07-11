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

namespace project_akhir
{
    public partial class DataDokter : Form
    {
        private string stringConnection = "data source=LAPTOP-DLDQQ5G0;" + "database=Puskesmas;user ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        public DataDokter()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataDokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet1.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.puskesmasDataSet1.Dokter);
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("P");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataFromDatabase();
        }
        private void GetDataFromDatabase()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.Dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select * From dbo.Dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string iddokter = textBox1.Text;
            string namadokter = textBox2.Text;
            string spesialis = textBox3.Text;
            string alamat = textBox4.Text;
            string notlp = textBox5.Text;
            string jk = comboBox1.Text;

            if (iddokter == "")
            {
                MessageBox.Show("Masukkan Semuannya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Dokter (id_dokter, nama_dokter, spesialis, alamat, no_tlp, jenis_kelamin) VALUES (@id_dokter, @nama_dokter, @spesialis, @alamat, @no_tlp, @jenis_kelamin)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_dokter", iddokter));
                cmd.Parameters.Add(new SqlParameter("@nama_dokter", namadokter));
                cmd.Parameters.Add(new SqlParameter("@spesialis", spesialis));
                cmd.Parameters.Add(new SqlParameter("@alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("@no_tlp", notlp));
                cmd.Parameters.Add(new SqlParameter("@jenis_kelamin", jk));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();

            }
        }
        private void refreshform()
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox3.Enabled = true;
            comboBox1.Enabled = false;
            comboBox1.SelectedIndex = -1;
            button6.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button6.Enabled = true;
            button1.Enabled = true;

        }
        private void DeleteData()
        {
            string Iddokter = textBox1.Text;

            if (Iddokter == "")
            {
                MessageBox.Show("Masukkan ID Dokter yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.Dokter WHERE id_dokter = @id_dokter";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_dokter", Iddokter));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus","Sukses",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.Close();
                    dataGridView1_CellContentClick();
                    refreshform();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_dokter"].Value.ToString();
            string idDokter = textBox1.Text;
            string Nama = textBox2.Text;
            string spesial = textBox3.Text;
            string Alamat = textBox4.Text;
            string tlp = textBox5.Text;
            string jkl = comboBox1.Text;

            if (id == "")
            {
                MessageBox.Show("id Dokter tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idDokter == "")
            {
                MessageBox.Show("Masukan Id Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Nama == "")
            {
                MessageBox.Show("Masukan Nama dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (spesial == "")
            {
                MessageBox.Show("Masukan Spesialisasinya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Alamat == "")
            {
                MessageBox.Show("Masukan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tlp=="")
            {
                MessageBox.Show("Masukan Nomor Telepon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jkl == "")
            {
                MessageBox.Show("Masukan Jenis Kelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE Dokter SET id_dokter = @id_dokter, nama_dokter = @nama_dokter, spesialis = @spesialis , alamat = @alamat, no_tlp = @no_tlp, jenis_kelamin=@jenis_kelamin";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_dokter", idDokter);
                command.Parameters.AddWithValue("@nama_dokter", Nama);
                command.Parameters.AddWithValue("@spesialis", spesial);
                command.Parameters.AddWithValue("@alamat", Alamat);
                command.Parameters.AddWithValue("@no_tlp", tlp);
                command.Parameters.AddWithValue("@jenis_kelamin", jkl);
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

        private void button7_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}

