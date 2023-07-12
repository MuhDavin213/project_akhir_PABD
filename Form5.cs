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
    public partial class PengurusKamar : Form
    {
        private string stringConnection = "data source=DKRZ\\MUHDAVIN;" + "database=Puskesmas_super;user ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlDbType idPiket;
        public PengurusKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PengurusKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet6.Jadwal_Pengurus_Kamar' table. You can move, or remove it, as needed.
            this.jadwal_Pengurus_KamarTableAdapter.Fill(this.puskesmas_superDataSet6.Jadwal_Pengurus_Kamar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idJadwal = dataGridView1.SelectedRows[0].Cells["id_piket_harian_dokter"].Value.ToString();
            string hari = textBox1.Text;
            string idPerawat = textBox2.Text;
            string idkamar = textBox3.Text;

            if (idJadwal == "")
            {
                MessageBox.Show("id piket tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hari == "")
            {
                MessageBox.Show("Masukan hari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idPerawat == "")
            {
                MessageBox.Show("Masukan id perawat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idkamar == "")
            {
                MessageBox.Show("Masukan id kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE piket_harian_doktor SET id_piket = @id_piket, id_dokter = @id_dokter, id_jadwal = @id_jadwal , hari = @hari, tugas = @hari, tugas=@tugas";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_jadwal", idJadwal);
                command.Parameters.AddWithValue("@hari", hari);
                command.Parameters.AddWithValue("@id_perawat", idPerawat);
                command.Parameters.AddWithValue("@id_kamar", idkamar);
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
            string idJadwal = textBox1.Text;

            if (idJadwal == "")
            {
                MessageBox.Show("Masukkan ID Jadwal yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.Jadwal_Pengurus_Kamar WHERE Jadwal_Pengurus_kamar = @id_jadwal_pengurus_kamar";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_jadwal_pengurus_kamar", idJadwal));
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
            GetDataFromDatabase();
        }
    }
}
