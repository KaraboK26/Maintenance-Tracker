namespace Project.PresentationLayer
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnRemoveRequest = new System.Windows.Forms.Button();
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
            this.lblRequests = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAssignJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLoginUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(734, 154);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(141, 20);
            this.txtClientID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(730, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client ID:";
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(199, 132);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(519, 336);
            this.dgvRequests.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnBefore);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(203, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 69);
            this.panel1.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnLast.Location = new System.Drawing.Point(399, 14);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 40);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnNext.Location = new System.Drawing.Point(281, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 40);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnBefore.FlatAppearance.BorderSize = 0;
            this.btnBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBefore.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnBefore.Location = new System.Drawing.Point(163, 14);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(51, 40);
            this.btnBefore.TabIndex = 10;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = false;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnFirst.Location = new System.Drawing.Point(45, 14);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(51, 40);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(734, 207);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(141, 20);
            this.txtServiceID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(730, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service ID:";
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnNewRequest.FlatAppearance.BorderSize = 0;
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnNewRequest.Location = new System.Drawing.Point(734, 326);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(201, 42);
            this.btnNewRequest.TabIndex = 9;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = false;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnRemoveRequest
            // 
            this.btnRemoveRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnRemoveRequest.FlatAppearance.BorderSize = 0;
            this.btnRemoveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRequest.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnRemoveRequest.Location = new System.Drawing.Point(734, 384);
            this.btnRemoveRequest.Name = "btnRemoveRequest";
            this.btnRemoveRequest.Size = new System.Drawing.Size(201, 42);
            this.btnRemoveRequest.TabIndex = 10;
            this.btnRemoveRequest.Text = "Remove Request";
            this.btnRemoveRequest.UseVisualStyleBackColor = false;
            this.btnRemoveRequest.Click += new System.EventHandler(this.btnRemoveRequest_Click);
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
            this.pnlSidebar.TabIndex = 12;
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
            this.lblLoginUsername.Location = new System.Drawing.Point(53, 87);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(81, 17);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "Username";
            // 
            // pbLoginIcon
            // 
            this.pbLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginIcon.Image")));
            this.pbLoginIcon.Location = new System.Drawing.Point(56, 21);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(63, 63);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.lblRequests.Location = new System.Drawing.Point(192, 21);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(132, 37);
            this.lblRequests.TabIndex = 13;
            this.lblRequests.Text = "Requests";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 100);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 14;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btnAssignJob.FlatAppearance.BorderSize = 0;
            this.btnAssignJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignJob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAssignJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnAssignJob.Location = new System.Drawing.Point(734, 268);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(201, 42);
            this.btnAssignJob.TabIndex = 15;
            this.btnAssignJob.Text = "Assign Job";
            this.btnAssignJob.UseVisualStyleBackColor = false;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btnAssignJob);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lblRequests);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.btnRemoveRequest);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLoginUser.ResumeLayout(false);
            this.pnlLoginUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnRemoveRequest;
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
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnAssignJob;
    }
}