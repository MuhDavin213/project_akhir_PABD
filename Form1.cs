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
    public partial class JadwalPraktek : Form
    {
        public JadwalPraktek()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet.jadwal_praktek' table. You can move, or remove it, as needed.
            this.jadwal_praktekTableAdapter.Fill(this.puskesmasDataSet.jadwal_praktek);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
