namespace ioop_assignment
{
    partial class LecturerDashboard
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
            this.admin_close = new System.Windows.Forms.Button();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_loggedintime = new System.Windows.Forms.Label();
            this.lbl_identity = new System.Windows.Forms.Label();
            this.panel_info = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_button = new System.Windows.Forms.Panel();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.lbl_delete = new System.Windows.Forms.Label();
            this.pic_approve = new System.Windows.Forms.PictureBox();
            this.lbl_approve = new System.Windows.Forms.Label();
            this.pic_updateenroll = new System.Windows.Forms.PictureBox();
            this.lbl_updateenroll = new System.Windows.Forms.Label();
            this.pic_regenrollstudent = new System.Windows.Forms.PictureBox();
            this.pic_updateprofile = new System.Windows.Forms.PictureBox();
            this.lbl_updateprofile = new System.Windows.Forms.Label();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panel_updateprofile = new System.Windows.Forms.Panel();
            this.btn_updateprofile = new System.Windows.Forms.Button();
            this.txtbox_phone = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_upprofile = new System.Windows.Forms.Label();
            this.lbl_regenrollstudent = new System.Windows.Forms.Label();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_approve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_updateenroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regenrollstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_updateprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.panel_updateprofile.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_close
            // 
            this.admin_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.admin_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_close.FlatAppearance.BorderSize = 0;
            this.admin_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_close.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_close.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.admin_close.Location = new System.Drawing.Point(989, 0);
            this.admin_close.Name = "admin_close";
            this.admin_close.Size = new System.Drawing.Size(40, 29);
            this.admin_close.TabIndex = 1;
            this.admin_close.Text = "X";
            this.admin_close.UseVisualStyleBackColor = false;
            this.admin_close.Click += new System.EventHandler(this.admin_close_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(51, 156);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(38, 19);
            this.lbl_role.TabIndex = 9;
            this.lbl_role.Text = "role";
            // 
            // lbl_loggedintime
            // 
            this.lbl_loggedintime.AutoSize = true;
            this.lbl_loggedintime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loggedintime.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedintime.Location = new System.Drawing.Point(51, 184);
            this.lbl_loggedintime.Name = "lbl_loggedintime";
            this.lbl_loggedintime.Size = new System.Drawing.Size(114, 19);
            this.lbl_loggedintime.TabIndex = 8;
            this.lbl_loggedintime.Text = "loggedintime";
            // 
            // lbl_identity
            // 
            this.lbl_identity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_identity.ForeColor = System.Drawing.Color.White;
            this.lbl_identity.Location = new System.Drawing.Point(12, 125);
            this.lbl_identity.Name = "lbl_identity";
            this.lbl_identity.Size = new System.Drawing.Size(269, 23);
            this.lbl_identity.TabIndex = 7;
            this.lbl_identity.Text = "identity";
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.DimGray;
            this.panel_info.Controls.Add(this.pictureBox1);
            this.panel_info.Controls.Add(this.lbl_role);
            this.panel_info.Controls.Add(this.lbl_identity);
            this.panel_info.Controls.Add(this.lbl_loggedintime);
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(284, 237);
            this.panel_info.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ioop_assignment.Properties.Resources.profile_picture;
            this.pictureBox1.Location = new System.Drawing.Point(85, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.LightGray;
            this.panel_button.Controls.Add(this.pic_delete);
            this.panel_button.Controls.Add(this.lbl_delete);
            this.panel_button.Controls.Add(this.lbl_approve);
            this.panel_button.Controls.Add(this.pic_updateenroll);
            this.panel_button.Controls.Add(this.lbl_updateenroll);
            this.panel_button.Controls.Add(this.pic_regenrollstudent);
            this.panel_button.Controls.Add(this.lbl_regenrollstudent);
            this.panel_button.Controls.Add(this.pic_updateprofile);
            this.panel_button.Controls.Add(this.lbl_updateprofile);
            this.panel_button.Controls.Add(this.pic_home);
            this.panel_button.Controls.Add(this.lbl_home);
            this.panel_button.Controls.Add(this.pic_approve);
            this.panel_button.Location = new System.Drawing.Point(1, 233);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(283, 394);
            this.panel_button.TabIndex = 11;
            // 
            // pic_delete
            // 
            this.pic_delete.Image = global::ioop_assignment.Properties.Resources.delete;
            this.pic_delete.Location = new System.Drawing.Point(11, 268);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(43, 45);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 25;
            this.pic_delete.TabStop = false;
            // 
            // lbl_delete
            // 
            this.lbl_delete.AutoSize = true;
            this.lbl_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delete.Location = new System.Drawing.Point(60, 279);
            this.lbl_delete.Name = "lbl_delete";
            this.lbl_delete.Size = new System.Drawing.Size(144, 23);
            this.lbl_delete.TabIndex = 26;
            this.lbl_delete.Text = "Delete Student";
            // 
            // pic_approve
            // 
            this.pic_approve.Image = global::ioop_assignment.Properties.Resources.approve;
            this.pic_approve.Location = new System.Drawing.Point(11, 202);
            this.pic_approve.Name = "pic_approve";
            this.pic_approve.Size = new System.Drawing.Size(43, 45);
            this.pic_approve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_approve.TabIndex = 23;
            this.pic_approve.TabStop = false;
            // 
            // lbl_approve
            // 
            this.lbl_approve.AutoSize = true;
            this.lbl_approve.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_approve.Location = new System.Drawing.Point(59, 211);
            this.lbl_approve.Name = "lbl_approve";
            this.lbl_approve.Size = new System.Drawing.Size(169, 23);
            this.lbl_approve.TabIndex = 24;
            this.lbl_approve.Text = "Approve Request";
            // 
            // pic_updateenroll
            // 
            this.pic_updateenroll.Image = global::ioop_assignment.Properties.Resources.updateclass;
            this.pic_updateenroll.Location = new System.Drawing.Point(11, 140);
            this.pic_updateenroll.Name = "pic_updateenroll";
            this.pic_updateenroll.Size = new System.Drawing.Size(43, 45);
            this.pic_updateenroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_updateenroll.TabIndex = 21;
            this.pic_updateenroll.TabStop = false;
            // 
            // lbl_updateenroll
            // 
            this.lbl_updateenroll.AutoSize = true;
            this.lbl_updateenroll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateenroll.Location = new System.Drawing.Point(60, 152);
            this.lbl_updateenroll.Name = "lbl_updateenroll";
            this.lbl_updateenroll.Size = new System.Drawing.Size(181, 23);
            this.lbl_updateenroll.TabIndex = 22;
            this.lbl_updateenroll.Text = "Update Enrollment";
            // 
            // pic_regenrollstudent
            // 
            this.pic_regenrollstudent.Image = global::ioop_assignment.Properties.Resources.registration;
            this.pic_regenrollstudent.Location = new System.Drawing.Point(11, 79);
            this.pic_regenrollstudent.Name = "pic_regenrollstudent";
            this.pic_regenrollstudent.Size = new System.Drawing.Size(43, 45);
            this.pic_regenrollstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_regenrollstudent.TabIndex = 20;
            this.pic_regenrollstudent.TabStop = false;
            // 
            // pic_updateprofile
            // 
            this.pic_updateprofile.Image = global::ioop_assignment.Properties.Resources.update;
            this.pic_updateprofile.Location = new System.Drawing.Point(10, 329);
            this.pic_updateprofile.Name = "pic_updateprofile";
            this.pic_updateprofile.Size = new System.Drawing.Size(43, 45);
            this.pic_updateprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_updateprofile.TabIndex = 11;
            this.pic_updateprofile.TabStop = false;
            // 
            // lbl_updateprofile
            // 
            this.lbl_updateprofile.AutoSize = true;
            this.lbl_updateprofile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateprofile.Location = new System.Drawing.Point(59, 340);
            this.lbl_updateprofile.Name = "lbl_updateprofile";
            this.lbl_updateprofile.Size = new System.Drawing.Size(141, 23);
            this.lbl_updateprofile.TabIndex = 10;
            this.lbl_updateprofile.Text = "Update Profile";
            this.lbl_updateprofile.Click += new System.EventHandler(this.lbl_updateprofile_Click);
            // 
            // pic_home
            // 
            this.pic_home.Image = global::ioop_assignment.Properties.Resources.home2;
            this.pic_home.Location = new System.Drawing.Point(11, 21);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(43, 45);
            this.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_home.TabIndex = 1;
            this.pic_home.TabStop = false;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Location = new System.Drawing.Point(60, 32);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(65, 23);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "Home";
            this.lbl_home.Click += new System.EventHandler(this.lbl_home_Click);
            // 
            // panel_updateprofile
            // 
            this.panel_updateprofile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_updateprofile.Controls.Add(this.btn_updateprofile);
            this.panel_updateprofile.Controls.Add(this.txtbox_phone);
            this.panel_updateprofile.Controls.Add(this.txtbox_email);
            this.panel_updateprofile.Controls.Add(this.txtbox_name);
            this.panel_updateprofile.Controls.Add(this.lbl_phone);
            this.panel_updateprofile.Controls.Add(this.lbl_email);
            this.panel_updateprofile.Controls.Add(this.lbl_name);
            this.panel_updateprofile.Controls.Add(this.lbl_upprofile);
            this.panel_updateprofile.Location = new System.Drawing.Point(282, 0);
            this.panel_updateprofile.Name = "panel_updateprofile";
            this.panel_updateprofile.Size = new System.Drawing.Size(747, 627);
            this.panel_updateprofile.TabIndex = 12;
            // 
            // btn_updateprofile
            // 
            this.btn_updateprofile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_updateprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateprofile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateprofile.ForeColor = System.Drawing.Color.White;
            this.btn_updateprofile.Location = new System.Drawing.Point(285, 527);
            this.btn_updateprofile.Name = "btn_updateprofile";
            this.btn_updateprofile.Size = new System.Drawing.Size(154, 46);
            this.btn_updateprofile.TabIndex = 7;
            this.btn_updateprofile.Text = "Update";
            this.btn_updateprofile.UseVisualStyleBackColor = false;
            this.btn_updateprofile.Click += new System.EventHandler(this.btn_updateprofile_Click);
            // 
            // txtbox_phone
            // 
            this.txtbox_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_phone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_phone.Location = new System.Drawing.Point(338, 284);
            this.txtbox_phone.Name = "txtbox_phone";
            this.txtbox_phone.Size = new System.Drawing.Size(243, 23);
            this.txtbox_phone.TabIndex = 6;
            // 
            // txtbox_email
            // 
            this.txtbox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_email.Location = new System.Drawing.Point(338, 418);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(243, 23);
            this.txtbox_email.TabIndex = 5;
            // 
            // txtbox_name
            // 
            this.txtbox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_name.Location = new System.Drawing.Point(338, 152);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(243, 23);
            this.txtbox_name.TabIndex = 4;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(76, 279);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(216, 32);
            this.lbl_phone.TabIndex = 3;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(83, 418);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(205, 32);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email Address:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(128, 147);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(102, 32);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_upprofile
            // 
            this.lbl_upprofile.AutoSize = true;
            this.lbl_upprofile.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_upprofile.Location = new System.Drawing.Point(252, 45);
            this.lbl_upprofile.Name = "lbl_upprofile";
            this.lbl_upprofile.Size = new System.Drawing.Size(232, 38);
            this.lbl_upprofile.TabIndex = 0;
            this.lbl_upprofile.Text = "Update Profile";
            // 
            // lbl_regenrollstudent
            // 
            this.lbl_regenrollstudent.AutoSize = true;
            this.lbl_regenrollstudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regenrollstudent.Location = new System.Drawing.Point(55, 90);
            this.lbl_regenrollstudent.Name = "lbl_regenrollstudent";
            this.lbl_regenrollstudent.Size = new System.Drawing.Size(216, 23);
            this.lbl_regenrollstudent.TabIndex = 20;
            this.lbl_regenrollstudent.Text = "Register, Enroll Student";
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 627);
            this.ControlBox = false;
            this.Controls.Add(this.admin_close);
            this.Controls.Add(this.panel_updateprofile);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_approve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_updateenroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regenrollstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_updateprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.panel_updateprofile.ResumeLayout(false);
            this.panel_updateprofile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_close;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_loggedintime;
        private System.Windows.Forms.Label lbl_identity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.PictureBox pic_updateprofile;
        private System.Windows.Forms.Label lbl_updateprofile;
        private System.Windows.Forms.PictureBox pic_regenrollstudent;
        private System.Windows.Forms.PictureBox pic_updateenroll;
        private System.Windows.Forms.Label lbl_updateenroll;
        private System.Windows.Forms.PictureBox pic_approve;
        private System.Windows.Forms.Label lbl_approve;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.Label lbl_delete;
        private System.Windows.Forms.Panel panel_updateprofile;
        private System.Windows.Forms.TextBox txtbox_phone;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_upprofile;
        private System.Windows.Forms.Button btn_updateprofile;
        private System.Windows.Forms.Label lbl_regenrollstudent;
    }
}