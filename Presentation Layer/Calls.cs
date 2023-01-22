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
    public partial class Calls : Form
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

        private static bool callinprogress = false;

        public Calls()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnCalls.Height;
            pnlNav.Top = btnCalls.Top;
            pnlNav.Left = btnCalls.Left;
            btnCalls.BackColor = Color.FromArgb(46, 51, 73);

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    btnNewCall.Hide(); btnIncomingCall.Hide(); btnEndCall.Hide();
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide();
                    pnlNav.Height = btnCalls.Height;
                    pnlNav.Top = btnAgents.Top;
                    pnlNav.Left = btnCalls.Left;
                    btnCalls.BackColor = Color.FromArgb(46, 51, 73);
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    break;
            }

            dataGridView1.DataSource = new Call().ViewCalls();
            //dataGridView1.Columns.
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

        private void btnNewCall_Click(object sender, EventArgs e)
        {
            try
            {
                Call call = new Call();
                Simulator simulator = new Simulator();

                call.Call_Date = DateTime.Today.ToString();
                call.Call_Duration = simulator.callinfo().Duration;
                call.Client_Phonenumber = simulator.callinfo().CallNumber;
                call.Client_Problem = txtProblem.Text;
                call.Client_ID = txtClientID.Text;

                if (new Validator().NotNull(call))
                {
                    call.NewCall();

                    dataGridView1.DataSource = call.ViewCalls();

                    btnNewCall.Visible = false;

                    MessageBox.Show("Call logged successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to log call", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncomingCall_Click(object sender, EventArgs e)
        {
            try
            {
                if (callinprogress == false)
                {
                    new Simulator().StartCall();
                    callinprogress = true;

                    MessageBox.Show("Call has been accepted");
                }
                else
                {
                    MessageBox.Show("Call is already in progress");
                }
            }
            catch
            {
                MessageBox.Show("Failed to start call", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            try
            {
                if (callinprogress == true)
                {
                    new Simulator().EndCall();
                    callinprogress = false;
                    btnNewCall.Visible = true;

                    MessageBox.Show("Call has been ended");
                }
                else
                {
                    MessageBox.Show("No call in progress");
                }
            }
            catch
            {
                MessageBox.Show("Failed to end call", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
