using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioop_assignment
{
    public partial class TrainerDashboard : Form
    {
        public static string username;
        public static string name;
        public static string role;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());
        SqlDataAdapter adpt;
        DataTable dt;
        public TrainerDashboard()
        {
            InitializeComponent();
        }

        public TrainerDashboard(string uname, string n, string r)
        {
            InitializeComponent();
            username = uname;
            name = n;
            role = r;
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = false;
            panel_addCoachingClass.Visible = false;
            panel_updateprofile.Visible = false;
            showData();
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
            panel_updateprofile.Visible = false;
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
            //trainer functions
            lbl_addcoachclass.Cursor = Cursors.Hand;
            //pic_addcoachclass.Cursor = Cursors.Hand;
            lbl_updatecoachclass.Cursor = Cursors.Hand;
            //pic_updatecoachclass.Cursor = Cursors.Hand;
            //pic_viewenroll.Cursor = Cursors.Hand;
            lbl_viewenroll.Cursor = Cursors.Hand;
            //pic_sendfeedback.Cursor = Cursors.Hand;
            lbl_sendfeedback.Cursor = Cursors.Hand;
            //
        }

       

        private void lbl_updateprofile_Click(object sender, EventArgs e)
        {
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = false;
            panel_addCoachingClass.Visible = false;
            panel_updateprofile.Visible = true;
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
            panel_addCoachingClass.Visible = false;
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = false;
        }

        private void lbl_addcoachclass_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = false;
            panel_addCoachingClass.Visible = true;
        }

        private void lbl_updatecoachclass_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = false;
            panel_addCoachingClass.Visible = false;
            panel_updateCoachingClass.Visible = true;
        }

        private void lbl_viewenroll_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_sendFeedback.Visible = false;
            panel_addCoachingClass.Visible = false;
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = true;
        }

        private void lbl_sendfeedback_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_addCoachingClass.Visible = false;
            panel_updateCoachingClass.Visible = false;
            panel_viewStudentEnr.Visible = false;
            panel_sendFeedback.Visible = true;
        }

        private void btn_addCoachingClass_Click(object sender, EventArgs e)
        {
            con.Open();
            string moduleName = textBox_ModuleName.Text;
            double charges = double.Parse(textBox_Charges.Text);
            string schedule = textBox_Schedule.Text;
            Coaching coach = new Coaching(moduleName, charges, schedule);
            coach.addCoachingClass();
            textBox_ModuleName.Text = string.Empty;
            textBox_Charges.Text = string.Empty;
            textBox_Schedule.Text = string.Empty;
            con.Close();
            showData();
        }

        // show the database table in datagridview Coaching Class
        public void showData()
        {
            adpt = new SqlDataAdapter("SELECT * FROM CoachingClass", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView_CoachingClass.DataSource = dt;
        }
    }
}
