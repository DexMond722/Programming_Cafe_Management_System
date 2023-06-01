using System;
using System.Collections;
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
        private string level;
        private double charges;
        private string schedule;
        private string username;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());

        public string Username { get { return username; } set { username = value; } }
        public string Module_Name { get { return module_name; } set { module_name = value; } }

        public string Level { get { return level; } set { level = value; } }
        public double Charges { get { return charges; } set { charges = value; } }

        public string Schedule { get { return schedule; } set { schedule = value; } }

        public Coaching()
        {

        }

        public Coaching(string module_Selected, string level_selected, string schedule)
        {
            module_name = module_Selected;
            level = level_selected;
            this.schedule = schedule;
        }

        // insert information into table
        public string addCoachingClass()
        {
            string status;
            int trainerId = GetTrainerID(username);
            int levelId = GetLevelID(level);
            int moduleId = GetModuleID(module_name, levelId);
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO Class (moduleID,trainerID,schedule) VALUES ('{moduleId}','{trainerId}','{schedule}')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Class Added Successfully";
            else
                status = "Unable to add class";
            con.Close();
            return status;
        }



        // loading Item From Database Modules Table to ComboBox
        public static ArrayList viewModuleName()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DISTINCT moduleName from Modules", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        // loading Item From Database level Table to ComboBox
        public static ArrayList viewLevel()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select distinct levelname FROM Levels", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        // GET LevelID
        private int GetLevelID(string level)
        {
            int levelID = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT levelID FROM Levels WHERE levelname = '{level}'", con);

            object result = cmd.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                levelID = id;
            }
            con.Close();
            return levelID;
        }

        // Get Trainer ID
        private int GetTrainerID(string username)
        {
            int trainerID = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT trainerID FROM Trainers WHERE userID = (SELECT userID FROM Users WHERE username = @username)", con);
            cmd.Parameters.AddWithValue("@username", username);

            object result = cmd.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                trainerID = id;
            }
            con.Close();
            return trainerID;
        }


        // GET Module ID
        private int GetModuleID(string module_name, int levelID)
        {
            int moduleID = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT moduleID FROM Modules WHERE (moduleName = '{module_name}' AND levelID = '{levelID}')", con);

            object result = cmd.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int id))
            {
                moduleID = id;
            }
            con.Close();
            return moduleID;
        }



    }
}
