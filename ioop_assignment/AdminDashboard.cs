using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioop_assignment
{
    public partial class AdminDashboard : Form
    {
        public static string userID;
        public static string username;
        public static string name;
        public static string role;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(string id,string uname, string n, string r)
        {
            InitializeComponent();
            userID = id;
            username = uname;
            name = n;
            role = r;
        }

        private void admin_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbl_identity.Text = "Welcome back, " + name;
            DateTime loggedInDate = DateTime.Now;
            lbl_loggedintime.Text = "Logged in on: \n" + loggedInDate.ToString();
            lbl_role.Text = "Role: " + role;
            MouseCursorChanged();
        }

        private void MouseCursorChanged()
        {
            //Base functions
            lbl_home.Cursor = Cursors.Hand;
            //pic_home.Cursor = Cursors.Hand;
            lbl_updateprofile.Cursor = Cursors.Hand;
            //pic_updateprofile.Cursor = Cursors.Hand;
            //
            //admin functions
            lbl_assigntrainer.Cursor = Cursors.Hand;
            //pic_assigntrainer.Cursor = Cursors.Hand;
            lbl_regtrainer.Cursor = Cursors.Hand;
            //pic_regtrainer.Cursor = Cursors.Hand;
            lbl_viewincome.Cursor = Cursors.Hand;
            //pic_viewincome.Cursor = Cursors.Hand;
            lbl_viewfeedback.Cursor = Cursors.Hand;
            //pic_viewfeedback.Cursor = Cursors.Hand;
            //
        }
        private void lbl_regtrainer_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_registertrainer.Visible = true;
        }
        private void lbl_updateprofile_Click(object sender, EventArgs e)
        {
            
            panel_updateprofile.Visible = true;
            panel_registertrainer.Visible = false;

            //load viewProfile
            Users obj1 = new Users(username);
            Users.viewProfile(obj1);

            txtbox_name.Text = obj1.Name;
            txtbox_phone.Text = obj1.Phone;
            txtbox_email.Text = obj1.Email;
            //

        }

        private void btn_updateprofile_Click(object sender, EventArgs e)
        {
            Users obj1 = new Users(username);
            MessageBox.Show(obj1.updateProfile(txtbox_name.Text, txtbox_phone.Text, txtbox_email.Text));
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_registertrainer.Visible = false;
        }

        private void btn_rt_register_Click(object sender, EventArgs e)
        {
            Trainer obj1 = new Trainer(txtbox_rt_username.Text, txtbox_rt_password.Text, txtbox_rt_name.Text, txtbox_rt_phone.Text, txtbox_rt_email.Text);
            MessageBox.Show(obj1.addTrainer());
        }
    }
}
