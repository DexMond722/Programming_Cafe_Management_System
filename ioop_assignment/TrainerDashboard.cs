using System;
using System.Collections;
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
        }

        private void admin_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInitial()
        {
            lbl_identity.Text = "Welcome back, " + name;
            DateTime loggedInDate = DateTime.Now;
            lbl_loggedintime.Text = "Logged in on: \n" + loggedInDate.ToString();
            lbl_role.Text = "Role: " + role;
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FormInitial();
            MouseCursorChanged();
            loadComboBox();
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

        private void loadComboBox()
        {
            ArrayList moduleName = new ArrayList();

            moduleName = Coaching.viewModuleName();
            foreach (var item in moduleName)
            {
                cmbBox_module.Items.Add(item);
            }

            ArrayList level = new ArrayList();

            moduleName = Coaching.viewLevel();
            foreach (var item in moduleName)
            {
                cmbBox_level.Items.Add(item);
            }
        }

        // Return the item selected in combobox if no selected item return empty string
        private string GetSelectedComboBoxItem(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                return comboBox.SelectedItem.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        // add coaching class
        private void addCoachingClass()
        {
            if (cmbBox_module.SelectedIndex != -1 && !string.IsNullOrEmpty(txtBox_Schedule.Text))
            {
                Coaching obj1 = new Coaching(GetSelectedComboBoxItem(cmbBox_module), GetSelectedComboBoxItem(cmbBox_level), txtBox_Schedule.Text);
                obj1.Username = username;
                MessageBox.Show(obj1.addCoachingClass());
            }
            else
                MessageBox.Show("Please insert data");

            cmbBox_module.SelectedIndex = -1;
            cmbBox_level.SelectedIndex = -1;
            txtBox_Schedule.Text = String.Empty;
        }

        private void btn_addCoachingClass_Click(object sender, EventArgs e)
        {
            addCoachingClass();
        }

        
    }
}
