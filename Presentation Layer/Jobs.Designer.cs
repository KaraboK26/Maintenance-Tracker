namespace Project.PresentationLayer
{
    partial class Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
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
            this.lblJobs = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnEscalateJob = new System.Windows.Forms.Button();
            this.btnCloseJob = new System.Windows.Forms.Button();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTechnicianID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.btnReassignJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
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
            this.lblLoginUsername.Location = new System.Drawing.Point(56, 95);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(81, 17);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "Username";
            // 
            // pbLoginIcon
            // 
            this.pbLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginIcon.Image")));
            this.pbLoginIcon.Location = new System.Drawing.Point(59, 29);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(63, 63);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblJobs.Location = new System.Drawing.Point(192, 29);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(75, 37);
            this.lblJobs.TabIndex = 15;
            this.lblJobs.Text = "Jobs";
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(199, 132);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.Size = new System.Drawing.Size(545, 336);
            this.dgvJobs.TabIndex = 22;
            this.dgvJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 100);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 32;
            // 
            // btnEscalateJob
            // 
            this.btnEscalateJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnEscalateJob.FlatAppearance.BorderSize = 0;
            this.btnEscalateJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscalateJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEscalateJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnEscalateJob.Location = new System.Drawing.Point(495, 499);
            this.btnEscalateJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnEscalateJob.Name = "btnEscalateJob";
            this.btnEscalateJob.Size = new System.Drawing.Size(143, 48);
            this.btnEscalateJob.TabIndex = 29;
            this.btnEscalateJob.Text = "Escalate Job";
            this.btnEscalateJob.UseVisualStyleBackColor = false;
            this.btnEscalateJob.Click += new System.EventHandler(this.btnEscalateJob_Click);
            // 
            // btnCloseJob
            // 
            this.btnCloseJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnCloseJob.FlatAppearance.BorderSize = 0;
            this.btnCloseJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCloseJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnCloseJob.Location = new System.Drawing.Point(348, 499);
            this.btnCloseJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseJob.Name = "btnCloseJob";
            this.btnCloseJob.Size = new System.Drawing.Size(143, 48);
            this.btnCloseJob.TabIndex = 29;
            this.btnCloseJob.Text = "Close Job";
            this.btnCloseJob.UseVisualStyleBackColor = false;
            this.btnCloseJob.Click += new System.EventHandler(this.btnCloseJob_Click);
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(760, 373);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(170, 20);
            this.txtServiceID.TabIndex = 30;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblJobID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblJobID.Location = new System.Drawing.Point(756, 336);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(87, 21);
            this.lblJobID.TabIndex = 23;
            this.lblJobID.Text = "Service ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(756, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Technician ID:";
            // 
            // txtTechnicianID
            // 
            this.txtTechnicianID.Location = new System.Drawing.Point(760, 227);
            this.txtTechnicianID.Name = "txtTechnicianID";
            this.txtTechnicianID.Size = new System.Drawing.Size(170, 20);
            this.txtTechnicianID.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(756, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Client ID:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(760, 300);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(170, 20);
            this.txtClientID.TabIndex = 38;
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnTrackJob.FlatAppearance.BorderSize = 0;
            this.btnTrackJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTrackJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnTrackJob.Location = new System.Drawing.Point(770, 56);
            this.btnTrackJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(143, 48);
            this.btnTrackJob.TabIndex = 39;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = false;
            this.btnTrackJob.Click += new System.EventHandler(this.btnTrackJob_Click);
            // 
            // btnReassignJob
            // 
            this.btnReassignJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnReassignJob.FlatAppearance.BorderSize = 0;
            this.btnReassignJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReassignJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReassignJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnReassignJob.Location = new System.Drawing.Point(642, 499);
            this.btnReassignJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnReassignJob.Name = "btnReassignJob";
            this.btnReassignJob.Size = new System.Drawing.Size(143, 48);
            this.btnReassignJob.TabIndex = 40;
            this.btnReassignJob.Text = "Reassign Job";
            this.btnReassignJob.UseVisualStyleBackColor = false;
            this.btnReassignJob.Click += new System.EventHandler(this.btnReassignJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnAddJob.FlatAppearance.BorderSize = 0;
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAddJob.Location = new System.Drawing.Point(201, 499);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(143, 48);
            this.btnAddJob.TabIndex = 41;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Location = new System.Drawing.Point(574, 72);
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(170, 20);
            this.txtSearchJob.TabIndex = 42;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnReassignJob);
            this.Controls.Add(this.btnTrackJob);
            this.Controls.Add(this.btnCloseJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEscalateJob);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTechnicianID);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
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
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnEscalateJob;
        private System.Windows.Forms.Button btnCloseJob;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTechnicianID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.Button btnReassignJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.TextBox txtSearchJob;
    }
}