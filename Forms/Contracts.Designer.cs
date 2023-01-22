namespace Project.PresentationLayer
{
    partial class FrmContracts
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
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.btnContractAvailability = new System.Windows.Forms.Button();
            this.btnContractPerformance = new System.Windows.Forms.Button();
            this.dgrContracts = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.Location = new System.Drawing.Point(55, 339);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(136, 41);
            this.btnViewContracts.TabIndex = 0;
            this.btnViewContracts.Text = "View Contracts";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.btnViewContracts_Click);
            // 
            // btnContractAvailability
            // 
            this.btnContractAvailability.Location = new System.Drawing.Point(307, 339);
            this.btnContractAvailability.Name = "btnContractAvailability";
            this.btnContractAvailability.Size = new System.Drawing.Size(148, 41);
            this.btnContractAvailability.TabIndex = 1;
            this.btnContractAvailability.Text = "Contract Availability";
            this.btnContractAvailability.UseVisualStyleBackColor = true;
            this.btnContractAvailability.Click += new System.EventHandler(this.btnContractAvailability_Click);
            // 
            // btnContractPerformance
            // 
            this.btnContractPerformance.Location = new System.Drawing.Point(556, 339);
            this.btnContractPerformance.Name = "btnContractPerformance";
            this.btnContractPerformance.Size = new System.Drawing.Size(168, 41);
            this.btnContractPerformance.TabIndex = 2;
            this.btnContractPerformance.Text = "Contract Performance";
            this.btnContractPerformance.UseVisualStyleBackColor = true;
            this.btnContractPerformance.Click += new System.EventHandler(this.btnContractPerformance_Click);
            // 
            // dgrContracts
            // 
            this.dgrContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrContracts.Location = new System.Drawing.Point(41, 13);
            this.dgrContracts.Name = "dgrContracts";
            this.dgrContracts.RowHeadersWidth = 51;
            this.dgrContracts.RowTemplate.Height = 24;
            this.dgrContracts.Size = new System.Drawing.Size(607, 297);
            this.dgrContracts.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(673, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 41);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(673, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgrContracts);
            this.Controls.Add(this.btnContractPerformance);
            this.Controls.Add(this.btnContractAvailability);
            this.Controls.Add(this.btnViewContracts);
            this.Name = "FrmContracts";
            this.Text = "Contracts";
            ((System.ComponentModel.ISupportInitialize)(this.dgrContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewContracts;
        private System.Windows.Forms.Button btnContractAvailability;
        private System.Windows.Forms.Button btnContractPerformance;
        private System.Windows.Forms.DataGridView dgrContracts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}