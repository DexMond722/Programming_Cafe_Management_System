using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioop_assignment
{
    public class Coaching
    {
        private string module_name;
        private double charges;
        private string schedule;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());

        public string Module_Name { get { return module_name; } set { module_name = value; } }

        public double Charges { get { return charges; } set { charges = value; } }

        public string Schedule { get { return schedule; } set { schedule = value; } }

        public Coaching(string module_name, double charges, string schedule)
        {
            this.module_name = module_name;
            this.charges = charges;
            this.schedule = schedule;
        }

        // add module
        public void addCoachingClass()
        {
            // opening the connection of database
            con.Open();
            // the query to check the module name exists or not
            string checkExistingStatus = $"SELECT COUNT(*) From CoachingClass WHERE ModuleName = '{module_name}'";
            // query to insert the data into CoachingClass Table
            string insertdata = $"INSERT INTO CoachingClass (ModuleName, Charges, Schedule) VALUES ('{module_name}','{charges}','{schedule}')";

            // checking the existing or not
            SqlCommand checkExisting = new SqlCommand(checkExistingStatus, con);
            int existingCount = (int)checkExisting.ExecuteScalar();

            // if count > 0 means the module has already existed
            if (existingCount > 0)
            {
                // Display error 
                MessageBox.Show("This module has already existed");
                con.Close();
                return; // Exit the method without inserting the data
            }
            else
            {
                // insert data
                SqlCommand insertData = new SqlCommand(insertdata, con);
                insertData.ExecuteNonQuery();
                MessageBox.Show("Coaching Class added successfully");
                con.Close();
            }
        }
    }
}
