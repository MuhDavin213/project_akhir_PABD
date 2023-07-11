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
    public partial class DataPerawat : Form
    {
        public DataPerawat()
        {
            InitializeComponent();
        }

        private void DataPerawat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puskesmasDataSet4.perawat' table. You can move, or remove it, as needed.
            this.perawatTableAdapter.Fill(this.puskesmasDataSet4.perawat);

        }
    }
}
