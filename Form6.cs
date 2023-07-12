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
    public partial class PerawatPasien : Form
    {
        private string stringConnection = "data source=LAPTOP-DLDQQ5G0;" + "database=Puskesmas;user ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        public PerawatPasien()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            button1.Enabled = true;
        }

        private void PerawatPasien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet7.Jadwal_Perawat_Pasien' table. You can move, or remove it, as needed.
            this.jadwal_Perawat_PasienTableAdapter.Fill(this.puskesmas_superDataSet7.Jadwal_Perawat_Pasien);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_jadwal"].Value.ToString();
            string idJadwal = textBox1.Text;
            string Hari = textBox2.Text;
            string Jam_mulai = textBox3.Text;
            string jam_selesai = textBox4.Text;
            string id_perawat = textBox8.Text;
            string id_pasien = textBox7.Text;
            string id_dokter = textBox6.Text;

            if (id == "")
            {
                MessageBox.Show("id Dokter tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idJadwal == "")
            {
                MessageBox.Show("Masukan Id Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Hari == "")
            {
                MessageBox.Show("Masukan Nama dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Jam_mulai == "")
            {
                MessageBox.Show("Masukan Spesialisasinya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jam_selesai == "")
            {
                MessageBox.Show("Masukan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id_perawat == "")
            {
                MessageBox.Show("Masukan Nomor Telepon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id_pasien == "")
            {
                MessageBox.Show("Masukan Jenis Kelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id_dokter == "")
            {
                MessageBox.Show("Masukan Jenis Kelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE Dokter SET id_dokter = @id_dokter, nama_dokter = @nama_dokter, spesialis = @spesialis , alamat = @alamat, no_tlp = @no_tlp, jenis_kelamin=@jenis_kelamin";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_dokter", idJadwal);
                command.Parameters.AddWithValue("@nama_dokter", Hari);
                command.Parameters.AddWithValue("@spesialis", Jam_mulai);
                command.Parameters.AddWithValue("@alamat", jam_selesai);
                command.Parameters.AddWithValue("@no_tlp", id_perawat);
                command.Parameters.AddWithValue("@jenis_kelamin", id_pasien);
                command.Parameters.AddWithValue("@jenis_kelamin", id_dokter);
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
            button2.Enabled = true;
        }
        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select * From dbo.Jadwal_Pengurus_kamar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void GetDataFromDatabase()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.Jadwal_Pengurus_kamar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void DeleteData()
        {
            string IdJadwal = textBox1.Text;

            if (IdJadwal == "")
            {
                MessageBox.Show("Masukkan ID Dokter yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.Jadwal_Perawat_Pasien WHERE Jadwal_Perawat_Pasien = @Jadwal_Perawat_Pasien";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_dokter", IdJadwal));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.Close();
                    dataGridView1_CellContentClick();
                    refreshform();
                }
            }
        }
    }
}
