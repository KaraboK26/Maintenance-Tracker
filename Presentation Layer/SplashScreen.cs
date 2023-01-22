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
    public partial class SplashScreen : Form
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

        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = 0;
            pnlNav.Top = 0;
            pnlNav.Left = 0;
            pnlNav.Visible = true;

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide();
                    //pnlNav.Height = btnAgents.Height;
                    //pnlNav.Top = btnAgents.Top;
                    //pnlNav.Left = btnAgents.Left;
                    //btnAgents.BackColor = Color.FromArgb(46, 51, 73);
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    //pnlNav.Height = btnAgents.Height;
                    //pnlNav.Top = btnAgents.Top;
                    //pnlNav.Left = btnAgents.Left;
                    //btnAgents.BackColor = Color.FromArgb(46, 51, 73);
                    break;
            }
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAgents.Height;
            pnlNav.Top = btnAgents.Top;
            pnlNav.Left = btnAgents.Left;
            btnAgents.BackColor = Color.FromArgb(46,51,73);

            new Agents().Show();
            this.Hide();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73);

            new Calls().Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnClients.Height;
            pnlNav.Top = btnClients.Top;
            pnlNav.Left = btnClients.Left;
            btnClients.BackColor = Color.FromArgb(46, 51, 73);

            new Clients().Show();
            this.Hide();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContracts.Height;
            pnlNav.Top = btnContracts.Top;
            pnlNav.Left = btnContracts.Left;
            btnContracts.BackColor = Color.FromArgb(46, 51, 73);

            new Contracts().Show();
            this.Hide();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnJobs.Height;
            pnlNav.Top = btnJobs.Top;
            pnlNav.Left = btnJobs.Left;
            btnJobs.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;

            new Jobs().Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRequests.Height;
            pnlNav.Top = btnRequests.Top;
            pnlNav.Left = btnRequests.Left;
            btnRequests.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;

            new Requests().Show();
            this.Hide();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTechnicians.Height;
            pnlNav.Top = btnTechnicians.Top;
            pnlNav.Left = btnTechnicians.Left;
            btnTechnicians.BackColor = Color.FromArgb(46, 51, 73); pnlNav.Height = btnCalls.Height;

            new Technicians().Show();
            this.Hide();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQuit.Height;
            pnlNav.Top = btnQuit.Top;
            pnlNav.Left = btnQuit.Left;
            btnQuit.BackColor = Color.FromArgb(46, 51, 73);

            Environment.Exit(0);
        }

        private void btnAgents_Leave(object sender, EventArgs e)
        {
            btnAgents.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnCalls_Leave(object sender, EventArgs e)
        {
            btnCalls.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnClients_Leave(object sender, EventArgs e)
        {
            btnClients.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnContracts_Leave(object sender, EventArgs e)
        {
            btnContracts.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnJobs_Leave(object sender, EventArgs e)
        {
            btnJobs.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnRequests_Leave(object sender, EventArgs e)
        {
            btnRequests.BackColor = Color.FromArgb(41, 50, 65);
        }

        private void btnTechnicians_Leave(object sender, EventArgs e)
        {
            btnTechnicians.BackColor = Color.FromArgb(41, 50, 65);
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
