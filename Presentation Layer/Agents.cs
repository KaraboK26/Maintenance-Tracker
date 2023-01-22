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
    public partial class Agents : Form
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

        public Agents()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAgents.Height;
            pnlNav.Top = btnAgents.Top;
            pnlNav.Left = btnAgents.Left;
            btnAgents.BackColor = Color.FromArgb(46, 51, 73);

            Logins credentials = new Logins().getcredentials();

            lblLoginUsername.Text = credentials.Username;

            switch (credentials.Position)
            {
                case "manager":
                    break;

                case "agent":
                    btnAgents.Hide(); btnTechnicians.Hide();
                    break;

                case "technician":
                    btnAgents.Hide(); btnCalls.Hide(); btnContracts.Hide(); btnClients.Hide(); btnRequests.Hide(); btnTechnicians.Hide(); btnServices.Hide();
                    break;
            }

            dataGridView1.DataSource = new CallAgent().ViewAgents();
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

        private void btnagents_Click(object sender, EventArgs e)
        {
            new Agents().Show();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAgentID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            try
            {
                CallAgent agent = new CallAgent();

                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.PhoneNumber = txtNumber.Text;
                agent.Employee_ID = txtAgentID.Text;
                agent.Branch = txtBranch.Text;

                if (new Validator().NotNull(agent))
                {
                    agent.AddEmployee();
                    agent.AddAgent();

                    dataGridView1.DataSource = agent.ViewAgents();

                    MessageBox.Show("Agent added successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to add agent", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                CallAgent agent = new CallAgent();

                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.PhoneNumber = txtNumber.Text;
                agent.Employee_ID = txtAgentID.Text;

                if (new Validator().NotNull(agent))
                {
                    agent.UpdateAgent();

                    dataGridView1.DataSource = agent.ViewAgents();

                    MessageBox.Show("Agent updated successfully", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed to update agent", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTechnician_Click(object sender, EventArgs e)
        {
            try
            {
                CallAgent agent = new CallAgent();
                agent.Employee_ID = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to remove {dataGridView1.CurrentRow.Cells[0].Value}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString() == "Yes")
                {
                    agent.DeleteEmployee();

                    dataGridView1.DataSource = agent.ViewAgents();
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete agent", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchAgent_Click(object sender, EventArgs e)
        {
            try
            {
                CallAgent agent = new CallAgent();
                agent.Employee_ID = txtSearchAgent.Text;

                if (new Validator().NotNull(agent))
                {
                    dataGridView1.DataSource = agent.SearchAgent();
                }
                else
                {
                    MessageBox.Show("Please fill in all the required details", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"Failed to search for agent", "Operation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
