using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace personnalisation_chequiers
{
    public partial class Chéque : Form
    {
       

        public Chéque()
        {
            InitializeComponent();
        }

        private void Chéque_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
        }

      
       
    }
}
