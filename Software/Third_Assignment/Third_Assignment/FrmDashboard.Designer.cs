namespace Third_Assignment
{
    partial class FrmDashboard
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
            this.dgvGymMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGymMembers
            // 
            this.dgvGymMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGymMembers.Location = new System.Drawing.Point(36, 36);
            this.dgvGymMembers.Name = "dgvGymMembers";
            this.dgvGymMembers.RowHeadersWidth = 62;
            this.dgvGymMembers.RowTemplate.Height = 28;
            this.dgvGymMembers.Size = new System.Drawing.Size(715, 344);
            this.dgvGymMembers.TabIndex = 0;
            this.dgvGymMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGymMembers_CellContentClick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGymMembers);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGymMembers;
    }
}