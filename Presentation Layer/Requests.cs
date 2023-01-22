using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BusinessLayer;
using System.Runtime.InteropServices;

namespace Project.PresentationLayer
{
    public partial class Requests : Form
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

        public Requests()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnRequests.Height;
            pnlNav.Top = btnRequests.Top;
            pnlNav.Left = btnRequests.Left;
            btnRequests.BackColor = Color.FromArgb(46, 51, 73);

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide(); btnAssignJob.Hide();
                    pnlNav.Height = btnRequests.Height;
                    pnlNav.Top = btnJobs.Top;
                    pnlNav.Left = btnRequests.Left;
                    btnRequests.BackColor = Color.FromArgb(46, 51, 73);
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    break;
            }

            dgvRequests.DataSource = new ServiceRequest().ViewRequests();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[0].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.CurrentRow.Index - 1].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.CurrentRow.Index + 1].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRequests.CurrentCell = dgvRequests.Rows[dgvRequests.RowCount - 2].Cells[0];

                txtClientID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[1].Value);
                txtServiceID.Text = Convert.ToString(dgvRequests.CurrentRow.Cells[2].Value);
            }
            catch
            {
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                Service service = new Service();

                client.Client_ID = txtClientID.Text;
                service.Service_ID = txtServiceID.Text;

                if (Convert.ToInt32(client.ClientAgreement().Rows[0].ItemArray[0]) >= Convert.ToInt32(service.ServiceLevel().Rows[0].ItemArray[0]))
                {
                    ServiceRequest newrequest = new ServiceRequest();
                    newrequest.Client_ID = txtClientID.Text;
                    newrequest.Service_ID = txtServiceID.Text;

                    newrequest.NewRequest();
                    dgvRequests.DataSource = newrequest.ViewRequests();
                    MessageBox.Show("Request added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Client does not qualify for this service, upgrade contract");
                }
            }
            catch
            {
                MessageBox.Show("Failed to add request", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveRequest_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show($"Are you sure you want to remove {dgvRequests.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    ServiceRequest newrequest = new ServiceRequest();
                    newrequest.Request_ID = dgvRequests.CurrentRow.Cells[0].Value.ToString();

                    newrequest.RemoveRequest();
                    dgvRequests.DataSource = newrequest.ViewRequests();
                }
            }
            catch
            {
                MessageBox.Show("Failed to remove request", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Are you sure you want to assign {dgvRequests.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    ServiceRequest request = new ServiceRequest();
                    request.Request_ID = dgvRequests.CurrentRow.Cells[0].Value.ToString();

                    request.RemoveRequest();

                    new Jobs(txtClientID.Text,txtServiceID.Text).Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Failed to assign request", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
