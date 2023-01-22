using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.PresentationLayer
{
    public partial class FrmContracts : Form
    {
        public FrmContracts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewContracts_Click(object sender, EventArgs e)
        {
           // dgrContracts.DataSource = new DataHandler().ViewContracts();
        }

        private void btnContractAvailability_Click(object sender, EventArgs e)
        {
           // dgrContracts.DataSource = new DataHandler().ContractAvailability();
        }

        private void btnContractPerformance_Click(object sender, EventArgs e)
        {
           // dgrContracts.DataSource = new DataHandler().ContractPerformance();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
