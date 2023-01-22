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
    public partial class Clients : Form
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

        public Clients()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnClients.Height;
            pnlNav.Top = btnClients.Top;
            pnlNav.Left = btnClients.Left;
            btnClients.BackColor = Color.FromArgb(46, 51, 73);

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide();
                    pnlNav.Height = btnClients.Height;
                    pnlNav.Top = btnCalls.Top;
                    pnlNav.Left = btnClients.Left;
                    btnClients.BackColor = Color.FromArgb(46, 51, 73);
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    break;
            }

            dataGridView1.DataSource = new Client().ViewClients();
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

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                client.Client_ID = txtSearchClient.Text;

                if (new Validator().NotNull(client))
                {
                    dataGridView1.DataSource = client.SearchClient();
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to find client", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                Contract contract = new Contract();

                client.Name = txtName.Text;
                client.Surname = txtSurname.Text;
                client.Phonenumber = txtPhoneNumber.Text;
                client.Address = txtAddress.Text;
                client.Client_Type = txtClientType.Text;
                client.Contract_ID = txtContractID.Text;

                contract.Contract_ID = txtContractID.Text;

                if (new Validator().NotNull(client))
                {
                    client.AddClient();
                    contract.ContractSale();

                    dataGridView1.DataSource = client.ViewClients();

                    MessageBox.Show("Client added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to add client", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                client.Client_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to delete {dataGridView1.CurrentRow.Cells[1].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    client.DeleteClient();

                    dataGridView1.DataSource = client.ViewClients();
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete client", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtClientType.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtContractID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                Contract contract = new Contract();

                client.Client_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                client.Name = txtName.Text;
                client.Surname = txtSurname.Text;
                client.Phonenumber = txtPhoneNumber.Text;
                client.Address = txtAddress.Text;
                client.Client_Type = txtClientType.Text;
                client.Contract_ID = txtContractID.Text;

                if (new Validator().NotNull(client))
                {
                    if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != txtContractID.Text)
                    {
                        contract.Contract_ID = txtContractID.Text;
                        contract.ContractSale();
                    }

                    client.UpdateClient();

                    dataGridView1.DataSource = client.ViewClients();

                    MessageBox.Show("Client updated successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to update client", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientAgreement_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                client.Client_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                new Contracts(client.ClientAgreement()).Show();
            }
            catch
            {
                MessageBox.Show("Failed to find client agreement", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
