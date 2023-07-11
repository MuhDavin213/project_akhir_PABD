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
    public partial class Data_Pasien : Form
    {
        private string stringConnection = "data source=LAPTOP-DLDQQ5G0;" + "database=Puskesmas;user ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        public Data_Pasien()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void Data_Pasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet5.pasien' table. You can move, or remove it, as needed.
            this.pasienTableAdapter.Fill(this.puskesmasDataSet5.pasien);
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("P");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void refreshform()
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox2.Enabled = true;
            textBox3.Text = "";
            textBox3.Enabled = true;
            textBox4.Text = "";
            textBox4.Enabled = true;
            comboBox1.Enabled = false;
            comboBox1.SelectedIndex = -1;
            button6.Enabled = false;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string idPAS = textBox1.Text;
            string namaPAS = textBox2.Text;
            string alamat = textBox3.Text;
            string notlp = textBox4.Text;
            string jk = comboBox1.Text;

            if (idPAS == "")
            {
                MessageBox.Show("Masukkan id dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.pasien (id_pasien nama_pasien,alamat, no_tlp, jenis_kelamin) VALUES (@id_pasien, @nama_pasien,@alamat, @no_tlp, @jenis_kelamin)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_dokter", idPAS));
                cmd.Parameters.Add(new SqlParameter("@nama_dokter", namaPAS));
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
        private void deletedata()
        {
            string Idpas = textBox1.Text;

            if (Iddokter == "")
            {
                MessageBox.Show("Masukkan ID pasien yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.perawat WHERE id_dokter = @id_perawat";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_perawat", Idpas));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.Close();
                    dataGridView1_CellContentClick();
                    refreshform();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletedata();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_perawat"].Value.ToString();
            string idpas = textBox1.Text;
            string Namapas = textBox2.Text;
            string Alamat = textBox3.Text;
            string tlp = textBox4.Text;
            string jkl = comboBox1.Text;

            if (id == "")
            {
                MessageBox.Show("id Dokter tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idpas == "")
            {
                MessageBox.Show("Masukan Id pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Namapas == "")
            {
                MessageBox.Show("Masukan Nama pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Alamat == "")
            {
                MessageBox.Show("Masukan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tlp == "")
            {
                MessageBox.Show("Masukan Nomor Telepon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jkl == "")
            {
                MessageBox.Show("Masukan Jenis Kelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE pasien SET id_pasien = @id_pasien, nama_pasien = @nama_pasien, alamat = @alamat, no_tlp = @no_tlp, jenis_kelamin=@jenis_kelamin";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_pasien", idpas);
                command.Parameters.AddWithValue("@nama_pasien", Namapas);
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

        private void button5_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage;
            hp.Show();
            this.Hide();

        }
    }
}
