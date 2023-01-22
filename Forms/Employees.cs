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
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //dgrEmployee.DataSource = new DataHandler().AddEmployee();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //dgrEmployee.DataSource = new DataHandler().DeleteEmployee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
