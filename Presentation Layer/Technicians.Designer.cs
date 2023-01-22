namespace Project.PresentationLayer
{
    partial class Technicians
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technicians));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnCalls = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.pnlLoginUser = new System.Windows.Forms.Panel();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.pbLoginIcon = new System.Windows.Forms.PictureBox();
            this.lblTechnicianID = new System.Windows.Forms.Label();
            this.txtTechnicianID = new System.Windows.Forms.TextBox();
            this.btnSearchTechnician = new System.Windows.Forms.Button();
            this.dgvTechnicians = new System.Windows.Forms.DataGridView();
            this.lblTechnicians = new System.Windows.Forms.Label();
            this.btnDeleteTechnician = new System.Windows.Forms.Button();
            this.btnAddTechnician = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUpdateTechnician = new System.Windows.Forms.Button();
            this.txtSearchTechnician = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.pnlSidebar.Controls.Add(this.btnServices);
            this.pnlSidebar.Controls.Add(this.btnLogOut);
            this.pnlSidebar.Controls.Add(this.btnQuit);
            this.pnlSidebar.Controls.Add(this.btnTechnicians);
            this.pnlSidebar.Controls.Add(this.btnRequests);
            this.pnlSidebar.Controls.Add(this.btnJobs);
            this.pnlSidebar.Controls.Add(this.btnContracts);
            this.pnlSidebar.Controls.Add(this.btnClients);
            this.pnlSidebar.Controls.Add(this.btnCalls);
            this.pnlSidebar.Controls.Add(this.btnAgents);
            this.pnlSidebar.Controls.Add(this.pnlLoginUser);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(186, 577);
            this.pnlSidebar.TabIndex = 13;
            // 
            // btnServices
            // 
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnServices.Location = new System.Drawing.Point(0, 426);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(186, 42);
            this.btnServices.TabIndex = 6;
            this.btnServices.Text = "Services";
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnLogOut.Location = new System.Drawing.Point(0, 483);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 47);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnQuit.Location = new System.Drawing.Point(0, 530);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(186, 47);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTechnicians
            // 
            this.btnTechnicians.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTechnicians.FlatAppearance.BorderSize = 0;
            this.btnTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicians.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnTechnicians.Location = new System.Drawing.Point(0, 384);
            this.btnTechnicians.Name = "btnTechnicians";
            this.btnTechnicians.Size = new System.Drawing.Size(186, 42);
            this.btnTechnicians.TabIndex = 1;
            this.btnTechnicians.Text = "Technicians";
            this.btnTechnicians.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTechnicians.UseVisualStyleBackColor = true;
            this.btnTechnicians.Click += new System.EventHandler(this.btnTechnicians_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequests.FlatAppearance.BorderSize = 0;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnRequests.Location = new System.Drawing.Point(0, 342);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(186, 42);
            this.btnRequests.TabIndex = 1;
            this.btnRequests.Text = "Requests";
            this.btnRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnJobs.Location = new System.Drawing.Point(0, 300);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(186, 42);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnContracts.Location = new System.Drawing.Point(0, 258);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(186, 42);
            this.btnContracts.TabIndex = 1;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnClients.Location = new System.Drawing.Point(0, 216);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(186, 42);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clients";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnCalls
            // 
            this.btnCalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalls.FlatAppearance.BorderSize = 0;
            this.btnCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalls.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnCalls.Location = new System.Drawing.Point(0, 174);
            this.btnCalls.Name = "btnCalls";
            this.btnCalls.Size = new System.Drawing.Size(186, 42);
            this.btnCalls.TabIndex = 1;
            this.btnCalls.Text = "Calls";
            this.btnCalls.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalls.UseVisualStyleBackColor = true;
            this.btnCalls.Click += new System.EventHandler(this.btnCalls_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgents.FlatAppearance.BorderSize = 0;
            this.btnAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgents.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAgents.Location = new System.Drawing.Point(0, 132);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(186, 42);
            this.btnAgents.TabIndex = 1;
            this.btnAgents.Text = "Agents";
            this.btnAgents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgents.UseVisualStyleBackColor = true;
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // pnlLoginUser
            // 
            this.pnlLoginUser.Controls.Add(this.lblLoginUsername);
            this.pnlLoginUser.Controls.Add(this.pbLoginIcon);
            this.pnlLoginUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginUser.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginUser.Name = "pnlLoginUser";
            this.pnlLoginUser.Size = new System.Drawing.Size(186, 132);
            this.pnlLoginUser.TabIndex = 0;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lblLoginUsername.Location = new System.Drawing.Point(56, 87);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(81, 17);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "Username";
            // 
            // pbLoginIcon
            // 
            this.pbLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginIcon.Image")));
            this.pbLoginIcon.Location = new System.Drawing.Point(59, 21);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(63, 63);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // lblTechnicianID
            // 
            this.lblTechnicianID.AutoSize = true;
            this.lblTechnicianID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTechnicianID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblTechnicianID.Location = new System.Drawing.Point(773, 121);
            this.lblTechnicianID.Name = "lblTechnicianID";
            this.lblTechnicianID.Size = new System.Drawing.Size(116, 21);
            this.lblTechnicianID.TabIndex = 26;
            this.lblTechnicianID.Text = "Technician ID:";
            // 
            // txtTechnicianID
            // 
            this.txtTechnicianID.Location = new System.Drawing.Point(777, 150);
            this.txtTechnicianID.Name = "txtTechnicianID";
            this.txtTechnicianID.Size = new System.Drawing.Size(141, 20);
            this.txtTechnicianID.TabIndex = 25;
            // 
            // btnSearchTechnician
            // 
            this.btnSearchTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnSearchTechnician.FlatAppearance.BorderSize = 0;
            this.btnSearchTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTechnician.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnSearchTechnician.Location = new System.Drawing.Point(777, 42);
            this.btnSearchTechnician.Name = "btnSearchTechnician";
            this.btnSearchTechnician.Size = new System.Drawing.Size(141, 42);
            this.btnSearchTechnician.TabIndex = 24;
            this.btnSearchTechnician.Text = "Search";
            this.btnSearchTechnician.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchTechnician.UseVisualStyleBackColor = false;
            this.btnSearchTechnician.Click += new System.EventHandler(this.btnSearchTechnician_Click);
            // 
            // dgvTechnicians
            // 
            this.dgvTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicians.Location = new System.Drawing.Point(199, 132);
            this.dgvTechnicians.Name = "dgvTechnicians";
            this.dgvTechnicians.RowHeadersWidth = 51;
            this.dgvTechnicians.Size = new System.Drawing.Size(556, 336);
            this.dgvTechnicians.TabIndex = 21;
            this.dgvTechnicians.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnicians_CellContentClick);
            // 
            // lblTechnicians
            // 
            this.lblTechnicians.AutoSize = true;
            this.lblTechnicians.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTechnicians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblTechnicians.Location = new System.Drawing.Point(192, 21);
            this.lblTechnicians.Name = "lblTechnicians";
            this.lblTechnicians.Size = new System.Drawing.Size(162, 37);
            this.lblTechnicians.TabIndex = 27;
            this.lblTechnicians.Text = "Technicians";
            // 
            // btnDeleteTechnician
            // 
            this.btnDeleteTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnDeleteTechnician.FlatAppearance.BorderSize = 0;
            this.btnDeleteTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTechnician.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnDeleteTechnician.Location = new System.Drawing.Point(583, 505);
            this.btnDeleteTechnician.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTechnician.Name = "btnDeleteTechnician";
            this.btnDeleteTechnician.Size = new System.Drawing.Size(163, 42);
            this.btnDeleteTechnician.TabIndex = 29;
            this.btnDeleteTechnician.Text = "Delete Technician";
            this.btnDeleteTechnician.UseVisualStyleBackColor = false;
            this.btnDeleteTechnician.Click += new System.EventHandler(this.btnDeleteTechnician_Click);
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnAddTechnician.FlatAppearance.BorderSize = 0;
            this.btnAddTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTechnician.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAddTechnician.Location = new System.Drawing.Point(199, 505);
            this.btnAddTechnician.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(163, 42);
            this.btnAddTechnician.TabIndex = 28;
            this.btnAddTechnician.Text = "Add Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = false;
            this.btnAddTechnician.Click += new System.EventHandler(this.btnAddTechnician_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(777, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 33;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblName.Location = new System.Drawing.Point(773, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(777, 264);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 20);
            this.txtSurname.TabIndex = 35;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblSurname.Location = new System.Drawing.Point(773, 235);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 21);
            this.lblSurname.TabIndex = 34;
            this.lblSurname.Text = "Surname:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(777, 321);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(141, 20);
            this.txtNumber.TabIndex = 37;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblNumber.Location = new System.Drawing.Point(773, 292);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 21);
            this.lblNumber.TabIndex = 36;
            this.lblNumber.Text = "Number:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(777, 378);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(141, 20);
            this.txtDescription.TabIndex = 39;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblDescription.Location = new System.Drawing.Point(773, 349);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 21);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Job Description:";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 100);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 40;
            // 
            // btnUpdateTechnician
            // 
            this.btnUpdateTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnUpdateTechnician.FlatAppearance.BorderSize = 0;
            this.btnUpdateTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTechnician.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnUpdateTechnician.Location = new System.Drawing.Point(391, 505);
            this.btnUpdateTechnician.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTechnician.Name = "btnUpdateTechnician";
            this.btnUpdateTechnician.Size = new System.Drawing.Size(163, 42);
            this.btnUpdateTechnician.TabIndex = 41;
            this.btnUpdateTechnician.Text = "Update Technician";
            this.btnUpdateTechnician.UseVisualStyleBackColor = false;
            this.btnUpdateTechnician.Click += new System.EventHandler(this.btnUpdateTechnician_Click);
            // 
            // txtSearchTechnician
            // 
            this.txtSearchTechnician.Location = new System.Drawing.Point(529, 55);
            this.txtSearchTechnician.Name = "txtSearchTechnician";
            this.txtSearchTechnician.Size = new System.Drawing.Size(226, 20);
            this.txtSearchTechnician.TabIndex = 42;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(777, 435);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(141, 20);
            this.txtBranch.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(773, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Branch:";
            // 
            // btnAvailability
            // 
            this.btnAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnAvailability.FlatAppearance.BorderSize = 0;
            this.btnAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailability.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAvailability.Location = new System.Drawing.Point(775, 505);
            this.btnAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(163, 42);
            this.btnAvailability.TabIndex = 45;
            this.btnAvailability.Text = "Change Availability";
            this.btnAvailability.UseVisualStyleBackColor = false;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // Technicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchTechnician);
            this.Controls.Add(this.btnUpdateTechnician);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDeleteTechnician);
            this.Controls.Add(this.btnAddTechnician);
            this.Controls.Add(this.lblTechnicians);
            this.Controls.Add(this.lblTechnicianID);
            this.Controls.Add(this.txtTechnicianID);
            this.Controls.Add(this.btnSearchTechnician);
            this.Controls.Add(this.dgvTechnicians);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Technicians";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technicians";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTechnicians;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnCalls;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Panel pnlLoginUser;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.PictureBox pbLoginIcon;
        private System.Windows.Forms.Label lblTechnicianID;
        private System.Windows.Forms.TextBox txtTechnicianID;
        private System.Windows.Forms.Button btnSearchTechnician;
        private System.Windows.Forms.DataGridView dgvTechnicians;
        private System.Windows.Forms.Label lblTechnicians;
        private System.Windows.Forms.Button btnDeleteTechnician;
        private System.Windows.Forms.Button btnAddTechnician;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnUpdateTechnician;
        private System.Windows.Forms.TextBox txtSearchTechnician;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAvailability;
    }
}