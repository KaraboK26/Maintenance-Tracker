namespace Project.PresentationLayer
{
    partial class Calls
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewCall = new System.Windows.Forms.Button();
            this.btnViewCalls = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.CallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallDate,
            this.callDuration,
            this.clientPhoneNum,
            this.clientProblem,
            this.clientID,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(105, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewCall
            // 
            this.btnNewCall.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewCall.Location = new System.Drawing.Point(105, 33);
            this.btnNewCall.Name = "btnNewCall";
            this.btnNewCall.Size = new System.Drawing.Size(167, 54);
            this.btnNewCall.TabIndex = 1;
            this.btnNewCall.Text = "New Call";
            this.btnNewCall.UseVisualStyleBackColor = false;
            // 
            // btnViewCalls
            // 
            this.btnViewCalls.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewCalls.Location = new System.Drawing.Point(294, 33);
            this.btnViewCalls.Name = "btnViewCalls";
            this.btnViewCalls.Size = new System.Drawing.Size(157, 54);
            this.btnViewCalls.TabIndex = 2;
            this.btnViewCalls.Text = "View Calls";
            this.btnViewCalls.UseVisualStyleBackColor = false;
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMainPage.Location = new System.Drawing.Point(371, 21);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(138, 45);
            this.btnMainPage.TabIndex = 3;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Location = new System.Drawing.Point(526, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.Azure;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.btnUpdate);
            this.panelControls.Controls.Add(this.btnDelete);
            this.panelControls.Controls.Add(this.btnExit);
            this.panelControls.Controls.Add(this.btnMainPage);
            this.panelControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelControls.Location = new System.Drawing.Point(105, 369);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(649, 85);
            this.panelControls.TabIndex = 5;
            // 
            // CallDate
            // 
            this.CallDate.HeaderText = "Call Date";
            this.CallDate.Name = "CallDate";
            // 
            // callDuration
            // 
            this.callDuration.HeaderText = "Call Duration";
            this.callDuration.Name = "callDuration";
            // 
            // clientPhoneNum
            // 
            this.clientPhoneNum.HeaderText = "Client Phone Number";
            this.clientPhoneNum.Name = "clientPhoneNum";
            // 
            // clientProblem
            // 
            this.clientProblem.HeaderText = "Client Problem";
            this.clientProblem.Name = "clientProblem";
            // 
            // clientID
            // 
            this.clientID.HeaderText = "Client ID";
            this.clientID.Name = "clientID";
            // 
            // Status
            // 
            this.Status.HeaderText = "Call Status";
            this.Status.Items.AddRange(new object[] {
            "Ringing",
            "In progress",
            "Completed"});
            this.Status.Name = "Status";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(328, 9);
            this.lblTitle.MinimumSize = new System.Drawing.Size(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Call Log Information";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(252, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(131, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Calls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(906, 497);
            this.Controls.Add(this.btnNewCall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnViewCalls);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Calls";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.Button btnNewCall;
        private System.Windows.Forms.Button btnViewCalls;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}