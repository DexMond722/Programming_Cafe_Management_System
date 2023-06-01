using System;
using System.Collections;
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
            FormInitial();
        }

        private void FormInitial()
        {
            lbl_identity.Text = "Welcome back, " + name;
            DateTime loggedInDate = DateTime.Now;
            lbl_loggedintime.Text = "Logged in on: \n" + loggedInDate.ToString();
            lbl_role.Text = "Role: " + role;
            txtbox_rt_password.UseSystemPasswordChar = true;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FormInitial();
            InitialVisibleItem();
            MouseCursorChanged();
            Loadlistbox();
            LoadCombobox();
        }

        private void InitialVisibleItem()
        {
            panel_registertrainer.Visible = false;
            panel_updateprofile.Visible = false;
            panel_assigntrainer.Visible = false;
        }

        private void Loadlistbox()
        {
            ArrayList name = new ArrayList();

            name = Trainer.viewAll();
            foreach (var item in name)
            {
                lstbox_rt_view.Items.Add(item);
            }
        }

        private void Reloadlistbox()
        {
            ArrayList name = Trainer.viewAll();
            lstbox_rt_view.Items.Clear(); 
            foreach (var item in name)
            {
                lstbox_rt_view.Items.Add(item);
            }
        }

        private void Deletetrainer()
        {
            if (lstbox_rt_view.SelectedItem != null)
            {
                string selectedTrainerName = lstbox_rt_view.SelectedItem.ToString();

                Trainer obj1 = new Trainer(selectedTrainerName);
                MessageBox.Show(obj1.deleteTrainer(selectedTrainerName));

                lstbox_rt_view.Items.Remove(lstbox_rt_view.SelectedItem);
            }
        }
        private void LoadCombobox()
        {
            ArrayList trainername = new ArrayList();

            trainername = Trainer.viewAll();
            foreach (var item in trainername)
            {
                cbox_at_trainer.Items.Add(item);
            }
            ArrayList module = new ArrayList();

            module = Trainer.viewModule();
            foreach (var item in module)
            {
                cbox_at_module.Items.Add(item);
            }
            ArrayList level = new ArrayList();

            level = Trainer.viewLevel();
            foreach (var item in level)
            {
                cbox_at_level.Items.Add(item);
            }
        }

        private void viewProfile()
        {
            Users obj1 = new Users(username);
            Users.viewProfile(obj1);

            txtbox_name.Text = obj1.Name;
            txtbox_phone.Text = obj1.Phone;
            txtbox_email.Text = obj1.Email;
        }

        private void updateProfile()
        {
            Users obj1 = new Users(username);
            MessageBox.Show(obj1.updateProfile(txtbox_name.Text, txtbox_phone.Text, txtbox_email.Text));
        }

        private void Registertrainer()
        {
            if (!string.IsNullOrEmpty(txtbox_rt_username.Text) && !string.IsNullOrEmpty(txtbox_rt_password.Text))
            {
                Trainer obj1 = new Trainer(txtbox_rt_username.Text, txtbox_rt_password.Text, txtbox_rt_name.Text, txtbox_rt_phone.Text, txtbox_rt_email.Text);
                MessageBox.Show(obj1.addTrainer());
            }
            else
                MessageBox.Show("Please insert data");

            txtbox_rt_username.Text = null;
            txtbox_rt_password.Text = null;
            txtbox_rt_name.Text = null;
            txtbox_rt_phone.Text = null;
            txtbox_rt_email.Text = null;
        }

        private void AssignTrainer()
        {
            if (cbox_at_trainer.SelectedItem != null && cbox_at_module.SelectedItem != null && cbox_at_level.SelectedItem != null)
            {
                string cbox_selectedTrainerName = cbox_at_trainer.SelectedItem.ToString();
                string cbox_selectedModuleName = cbox_at_module.SelectedItem.ToString();
                string cbox_selectedLevelName = cbox_at_level.SelectedItem.ToString();

                Trainer obj1 = new Trainer(cbox_selectedTrainerName,cbox_selectedModuleName,cbox_selectedLevelName);
                MessageBox.Show(obj1.assignTrainer(cbox_selectedTrainerName,cbox_selectedModuleName,cbox_selectedLevelName));

                cbox_at_level.SelectedItem = null;
                cbox_at_module.SelectedItem = null;
                cbox_at_trainer.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Data not found, Please try again.");
            }
        }

        private void MouseCursorChanged()
        {
            //Base functions
            lbl_home.Cursor = Cursors.Hand;
            lbl_updateprofile.Cursor = Cursors.Hand;
            //
            //admin functions
            lbl_assigntrainer.Cursor = Cursors.Hand;
            lbl_regtrainer.Cursor = Cursors.Hand;
            lbl_viewincome.Cursor = Cursors.Hand;
            lbl_viewfeedback.Cursor = Cursors.Hand;
            //
        }
        private void lbl_regtrainer_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_registertrainer.Visible = true;
            panel_assigntrainer.Visible = false;
        }
        private void lbl_updateprofile_Click(object sender, EventArgs e)
        {
            
            panel_updateprofile.Visible = true;
            panel_registertrainer.Visible = false;
            panel_assigntrainer.Visible = false;
            viewProfile();
        }

        private void btn_updateprofile_Click(object sender, EventArgs e)
        {
            updateProfile();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_registertrainer.Visible = false;
            panel_assigntrainer.Visible = false;
        }

        private void btn_rt_register_Click(object sender, EventArgs e)
        {
            Registertrainer();
            Reloadlistbox();
        }

        private void btn_rt_deletetrainer_Click(object sender, EventArgs e)
        {
            Deletetrainer();
        }

        private void lbl_assigntrainer_Click(object sender, EventArgs e)
        {
            panel_updateprofile.Visible = false;
            panel_registertrainer.Visible = false;
            panel_assigntrainer.Visible = true;
        }

        private void btn_at_assign_Click(object sender, EventArgs e)
        {
            AssignTrainer();
        }


    }
}
