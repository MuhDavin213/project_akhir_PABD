using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_akhir
{
    public partial class JadwalPraktek : Form
    {
        private string stringConnection = "data source = LAPTOP-DLDQQ5G0;" +
            "database=Puskesmas;User ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        public JadwalPraktek()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet3.jadwal_praktek' table. You can move, or remove it, as needed.
            this.jadwal_praktekTableAdapter1.Fill(this.puskesmasDataSet3.jadwal_praktek);
            // TODO: This line of code loads data into the 'puskesmasDataSet.jadwal_praktek' table. You can move, or remove it, as needed.
            this.jadwal_praktekTableAdapter.Fill(this.puskesmasDataSet.jadwal_praktek);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select * from dbo.jadwal_praktek";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string IdJadwal = textBox1.Text;
            string Hari = textBox2.Text;
            string JamMulai = textBox3.Text;
            string JamSelesai = textBox4.Text;
            string IdDokter = textBox5.Text;

            if (IdJadwal == "")
            {
                MessageBox.Show("Masukan ID Jadwal !","warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.jadwal_praktek (id_jadwal, hari, jam_mulai, jam_selesai, id_dokter) values (@id_jadwal, @hari, @jam_mulai, @jam_selesai, @id_dokter)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@id_jadwal", IdJadwal));
                cmd.Parameters.Add(new SqlParameter("@hari", Hari));
                cmd.Parameters.Add(new SqlParameter("@jam_mulai", JamMulai));
                cmd.Parameters.Add(new SqlParameter("@jam_selesai", JamSelesai));
                cmd.Parameters.Add(new SqlParameter("@id_dokter",IdDokter));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil disimpan","sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1_CellContentClick();
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void GetDataFromDatabase()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.jadwal_praktek";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }
        private void refreshform()
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox3.Enabled = true;
            textBox4.Text = "";
            textBox4.Enabled = true;
            textBox5.Text = "";
            textBox5.Enabled = true;
            button6.Enabled = false;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Baris yang akan di update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_jadwal"].Value.ToString();
            string idjadwal = textBox1.Text;
            string hari = textBox2.Text;
            string jamM = textBox3.Text;
            string jamS = textBox4.Text;
            string idD = textBox5.Text;

            if (id == "")
            {
                MessageBox.Show("id Dokter tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idjadwal == "")
            {
                MessageBox.Show("Masukan Id jadwal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hari== "")
            {
                MessageBox.Show("Masukan Hari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jamM == "")
            {
                MessageBox.Show("Masukan Jam Mulai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jamS == "")
            {
                MessageBox.Show("Masukan Jam Selesai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idD == "")
            {
                MessageBox.Show("Masukan Id Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE jadwal_praktek SET id_jadwal = @id_jadwal, jam_mulai = @jam_mulai, jam_selesai = @jam_selesai , id_dokter = @id_dokter";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_jadwal", idjadwal);
                command.Parameters.AddWithValue("@hari", hari);
                command.Parameters.AddWithValue("@jam_mulai", jamM);
                command.Parameters.AddWithValue("@jam_selesai", jamS);
                command.Parameters.AddWithValue("@id_dokter", idD);
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
        private void DeleteData()
        {
            string Idjadwal = textBox1.Text;

            if (Idjadwal == "")
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
                    cmd.Parameters.Add(new SqlParameter("@id_dokter", Idjadwal));
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

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            HP.Show();
            this.Hide();
        }
    }
}
