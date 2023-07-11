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

namespace project_akhir
{
    public partial class JadwalPraktek : Form
    {
        private string stringConnection = "data source = LAPTOP-DLDQQ5G0;" +
            "database=Puskesmas;User ID=sa;Password=mzM160503";
        private SqlConnection koneksi;
        private SqlCommand cmd;
        public JadwalPraktek()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet.jadwal_praktek' table. You can move, or remove it, as needed.
            this.jadwal_praktekTableAdapter.Fill(this.puskesmasDataSet.jadwal_praktek);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView()
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

            if (IdDokter == "")
            {
                MessageBox.Show("Masukan ID Dokter !","warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.jadwal_praktek (id_jadwal, hari, jam_mulai, jam_selesai, id_dokter) values (@id_jadwal, @hari, @jam_mulai, @jam_selesai, @id_dokter)";
                SqlCommand cmd = new SqlCommand(str);
                cmd.Parameters.Add(new SqlParameter("@id_jadwal", IdJadwal));
                cmd.Parameters.Add(new SqlParameter("@hari", Hari));
                cmd.Parameters.Add(new SqlParameter("@jam_mulai", JamMulai));
                cmd.Parameters.Add(new SqlParameter("@jam_selesai", JamSelesai));
                cmd.Parameters.Add(new SqlParameter("@id_dokter",IdDokter));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil disimpan","sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView();
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
