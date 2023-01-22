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
    public partial class FrmViewServices : Form
    {
        public FrmViewServices()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }

        private void BtnViewServices_Click(object sender, EventArgs e)
        {
            //dgrViewServices.DataSource = new DataHandler().ViewServices();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
