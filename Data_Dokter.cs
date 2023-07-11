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
        private string stringConnection = "data source=LAPTOP-DLDQQ5G0;" + "database=Puskesmas`; user ID=sa;Password=mzM160503";
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
            string IdJadwal = textBox1.Text;
            string Hari = textBox2.Text;
            string JamMulai = textBox3.Text;
            string JamSelesai = textBox4.Text;
            string IdDokter = textBox5.Text;

            if (IdDokter == "")
            {
                MessageBox.Show("Masukan ID Dokter !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into db0.Puskesmas (id_jadwal, hari, jam_mulai, jam_selesai, id_dokter) values (@id_jadwal, @hari, @jam_mulai, @jam_selesai, @id_dokter)";
                SqlCommand cmd = new SqlCommand(str);
                cmd.Parameters.Add(new SqlParameter("@id_jadwal", IdJadwal));
                cmd.Parameters.Add(new SqlParameter("@hari", Hari));
                cmd.Parameters.Add(new SqlParameter("@jam_mulai", JamMulai));
                cmd.Parameters.Add(new SqlParameter("@jam_selesai", JamSelesai));
                cmd.Parameters.Add(new SqlParameter("@id_dokter", IdDokter));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}

