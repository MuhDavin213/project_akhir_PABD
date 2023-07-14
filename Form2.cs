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
    public partial class DataPerawat : Form
    { 

        private string stringConnesction = "data source=LAPTOP-DLDQQ5G0;" + "database=Puskesmas;user ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        public DataPerawat()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnesction);
        }

        private void DataPerawat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet4.perawat' table. You can move, or remove it, as needed.
            this.perawatTableAdapter.Fill(this.puskesmasDataSet4.perawat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select * From dbo.Perawat";
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
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string idperawat = textBox1.Text;
            string nama = textBox2.Text;
            string alamat = textBox3.Text;
            string notlp = textBox4.Text;

            if (idperawat == "")
            {
                MessageBox.Show("Masukkan id perawat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Perawat (id_perawat, nama_perawat,alamat, no_tlp) VALUES (@id_perawat, @nama_perawat,@alamat, @no_tlp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_perawat", idperawat));
                cmd.Parameters.Add(new SqlParameter("@nama_perawat", nama));
                cmd.Parameters.Add(new SqlParameter("@alamat", alamat));
                cmd.Parameters.Add(new SqlParameter("@no_tlp", notlp));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();

            }
        }
        private void deletedata()
        {
            string idperawat = textBox1.Text;

            if (idperawat == "")
            {
                MessageBox.Show("Masukkan ID Perawat yang ingin dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    koneksi.Open();
                    string str = "DELETE FROM dbo.Perawat WHERE id_dokter = @id_perawat";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id_dokter", idperawat));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.Close();
                    dataGridView1_CellContentClick();
                    refreshform();
                }
            }
        }
        private void GetDataFromDatabase()
        {
            koneksi.Open();
            string str = "SELECT * FROM dbo.Perawat";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletedata();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idperawat = textBox1.Text;
            string Nama = textBox2.Text;
            string alamat = textBox3.Text;
            string notlp = textBox4.Text;

            if (idperawat == "")
            {
                MessageBox.Show("id perawat tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Nama == "")
            {
                MessageBox.Show("Masukan Nama perawat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (alamat == "")
            {
                MessageBox.Show("Masukan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (notlp == "")
            {
                MessageBox.Show("Masukan Nomor Telepon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE Perawat SET id_perawat = @id_perawat, nama_perawat = @nama_perawat, alamat = @alamat, no_tlp = @no_tlp";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_perawat", idperawat);
                command.Parameters.AddWithValue("@nama_perawat", Nama);
                command.Parameters.AddWithValue("@alamat", alamat);
                command.Parameters.AddWithValue("@no_tlp", notlp);

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
    }
}
