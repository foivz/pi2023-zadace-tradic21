﻿namespace Third_Assignment
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
            this.components = new System.ComponentModel.Container();
            this.dgvGymMembers = new System.Windows.Forms.DataGridView();
            this.lblEnterId = new System.Windows.Forms.Label();
            this.txtEnterId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGymMembers
            // 
            this.dgvGymMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGymMembers.Location = new System.Drawing.Point(41, 70);
            this.dgvGymMembers.Name = "dgvGymMembers";
            this.dgvGymMembers.RowHeadersWidth = 62;
            this.dgvGymMembers.RowTemplate.Height = 28;
            this.dgvGymMembers.Size = new System.Drawing.Size(879, 261);
            this.dgvGymMembers.TabIndex = 0;
            this.dgvGymMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGymMembers_CellContentClick);
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.Location = new System.Drawing.Point(37, 25);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Size = new System.Drawing.Size(86, 20);
            this.lblEnterId.TabIndex = 1;
            this.lblEnterId.Text = "Unesite Id:";
            // 
            // txtEnterId
            // 
            this.txtEnterId.Location = new System.Drawing.Point(130, 25);
            this.txtEnterId.Name = "txtEnterId";
            this.txtEnterId.Size = new System.Drawing.Size(157, 26);
            this.txtEnterId.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(41, 352);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(121, 44);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Dodaj člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(450, 16);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(121, 44);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "Obriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(188, 352);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(121, 44);
            this.btnUpdateMember.TabIndex = 6;
            this.btnUpdateMember.Text = "Ažuriraj člana";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnterId);
            this.Controls.Add(this.lblEnterId);
            this.Controls.Add(this.dgvGymMembers);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGymMembers;
        private System.Windows.Forms.Label lblEnterId;
        private System.Windows.Forms.TextBox txtEnterId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
    }
}