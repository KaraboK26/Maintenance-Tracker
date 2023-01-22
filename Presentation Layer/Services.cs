using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Project.BusinessLayer;

namespace Project.PresentationLayer
{
    public partial class Services : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightWllipse
        );

        public Services()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnServices.Height;
            pnlNav.Top = btnServices.Top;
            pnlNav.Left = btnServices.Left;
            btnServices.BackColor = Color.FromArgb(46, 51, 73);

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide();
                    pnlNav.Height = btnServices.Height;
                    pnlNav.Top = btnRequests.Top;
                    pnlNav.Left = btnServices.Left;
                    btnServices.BackColor = Color.FromArgb(46, 51, 73);
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    break;
            }

            dgrViewServices.DataSource = new Service().ViewServices();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            new Agents().Show();
            this.Hide();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            new Calls().Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new Clients().Show();
            this.Hide();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new Contracts().Show();
            this.Hide();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            new Jobs().Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            new Requests().Show();
            this.Hide();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            new Technicians().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new Services().Show();
            this.Hide();
        }
    }
}
