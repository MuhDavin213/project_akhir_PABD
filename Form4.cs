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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace project_akhir
{
    public partial class PiketDokter : Form
    {
        private string stringConnection = "data source=DKRZ\\MUHDAVIN;" + "database=Puskesmas_super;user ID=sa;Password=123";
        private SqlConnection koneksi;
        private SqlDbType idPiket;

        public PiketDokter()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void PiketDokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmas_superDataSet5.Piket_Harian_Doktor' table. You can move, or remove it, as needed.
            this.piket_Harian_DoktorTableAdapter.Fill(this.puskesmas_superDataSet5.Piket_Harian_Doktor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_piket_harian_dokter"].Value.ToString();
            string idPiket = textBox1.Text;
            string idDokter = textBox2.Text;
            string idJadwal = textBox3.Text;
            string hari = textBox4.Text;
            string tugas = textBox5.Text;

            if (id == "")
            {
                MessageBox.Show("id piket tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idPiket == "")
            {
                MessageBox.Show("Masukan Id piket", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idDokter == "")
            {
                MessageBox.Show("Masukan id dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idJadwal == "")
            {
                MessageBox.Show("Masukan id jadwal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hari == "")
            {
                MessageBox.Show("Masukan Hari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tugas == "")
            {
                MessageBox.Show("Masukan Tugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE piket_harian_doktor SET id_piket = @id_piket, id_dokter = @id_dokter, id_jadwal = @id_jadwal , hari = @hari, tugas = @hari, tugas=@tugas";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_piket", idPiket);
                command.Parameters.AddWithValue("@id_dokter", idDokter);
                command.Parameters.AddWithValue("@id_jadwal", idJadwal);
                command.Parameters.AddWithValue("@hari", hari);
                command.Parameters.AddWithValue("@tugas", tugas);
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
            textBox5.Text = "";
            textBox5.Enabled = true;
            button2.Enabled = true;
        }
        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select * From dbo.piket_harian_dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void GetDataFromDatabase()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.piket_harian_dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }
        private void DeleteData()
        {
            string IdPiket = textBox1.Text;

            if (IdPiket == "")
            {
                MessageBox.Show("Masukkan ID Piket yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.piket_harian_doktor WHERE id_piket_harian_doktor = @id_piket_harian_doktor";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_piket_harian_doktor", idPiket));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            GetDataFromDatabase();
        }
    }
}
