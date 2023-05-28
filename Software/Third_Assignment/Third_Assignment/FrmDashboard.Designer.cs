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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.dgvGymMembers = new System.Windows.Forms.DataGridView();
            this.lblEnterId = new System.Windows.Forms.Label();
            this.txtEnterId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGymMembers
            // 
            this.dgvGymMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGymMembers.Location = new System.Drawing.Point(41, 451);
            this.dgvGymMembers.Name = "dgvGymMembers";
            this.dgvGymMembers.RowHeadersWidth = 62;
            this.dgvGymMembers.RowTemplate.Height = 28;
            this.dgvGymMembers.Size = new System.Drawing.Size(1174, 361);
            this.dgvGymMembers.TabIndex = 0;
            this.dgvGymMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGymMembers_CellContentClick);
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterId.Location = new System.Drawing.Point(36, 318);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Padding = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.lblEnterId.Size = new System.Drawing.Size(122, 31);
            this.lblEnterId.TabIndex = 1;
            this.lblEnterId.Text = "Unesite Id:";
            // 
            // txtEnterId
            // 
            this.txtEnterId.Location = new System.Drawing.Point(164, 320);
            this.txtEnterId.Name = "txtEnterId";
            this.txtEnterId.Size = new System.Drawing.Size(230, 26);
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
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(41, 366);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 60);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Snow;
            this.btnAddMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(41, 876);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btnAddMember.Size = new System.Drawing.Size(250, 60);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Dodaj člana";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDeleteMember.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMember.Image")));
            this.btnDeleteMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.Location = new System.Drawing.Point(572, 366);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btnDeleteMember.Size = new System.Drawing.Size(250, 60);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "Obriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdateMember.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMember.Image")));
            this.btnUpdateMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMember.Location = new System.Drawing.Point(312, 876);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btnUpdateMember.Size = new System.Drawing.Size(250, 60);
            this.btnUpdateMember.TabIndex = 6;
            this.btnUpdateMember.Text = "Ažuriraj člana";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Khaki;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(303, 366);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(250, 60);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Ponovno učitaj";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(173, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(800, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 174);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F);
            this.label2.Location = new System.Drawing.Point(652, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "StrongMan Gym Manager";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 965);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnterId);
            this.Controls.Add(this.lblEnterId);
            this.Controls.Add(this.dgvGymMembers);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGymMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}