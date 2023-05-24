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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(-1, 0);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(174, 56);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Dodaj člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(203, 0);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(174, 56);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "Pretraži člana";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(404, 0);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(174, 56);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Obriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnAddMember);
            this.Name = "FrmDashboard";
            this.Text = "StrongMan GYM";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnDeleteMember;
    }
}