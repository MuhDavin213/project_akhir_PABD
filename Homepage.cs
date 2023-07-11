using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form_1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pnlDataDokter.Height = PnlbuttonDataDokter.Height;
            pnlDataDokter.Top = PnlbuttonDataDokter.Top;
            pnlDataDokter.Visible = true;
            PnlDataPasien.Visible = false;
            PnlRawatInap.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlRawatInap.Height = BtnRawatInap.Height;
            PnlRawatInap.Top = BtnRawatInap.Top;
            pnlDataDokter.Visible = false;
            PnlDataPasien.Visible = false;
            PnlRawatInap.Visible = true;

        }

        private void BtnDataPasien_Click(object sender, EventArgs e)
        {
            PnlDataPasien.Height = BtnDataPasien.Height;
            PnlDataPasien.Top = BtnDataPasien.Top;
            pnlDataDokter.Visible = false;
            PnlDataPasien.Visible = true;
            PnlRawatInap.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
