using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop_assignment
{
    internal class Trainer
    {
        private string userID;
        private string username;
        private string password;
        private string name;
        private string phone;
        private string email;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());

        public string UserID { get { return UserID; } set { UserID = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Trainer(string username, string password, string name, string phone, string email)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public Trainer(string name)
        {
            this.name = name;
        }


        public string addTrainer()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users(username,password,role,name,phone,email) values(@username,@password,'trainer',@name,@phone,@email); SELECT SCOPE_IDENTITY()", con);
            SqlCommand cmd2 = new SqlCommand("Insert into Trainers(userid) values(@userID) ", con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            

            int UserID = Convert.ToInt32(cmd.ExecuteScalar());
            cmd2.Parameters.AddWithValue("@userID", UserID);
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
                status = "Trainer Registered";
            else
                status = "Unable to Register Trainer";
            con.Close();
            return status;
        }

        public static ArrayList viewAll()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select name from Users where role = 'trainer'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public string deleteTrainer(string name)
        {
            string status;
            con.Open();
            
            SqlCommand cmd = new SqlCommand("delete FROM Trainers WHERE userID IN (SELECT userID FROM Users WHERE name = @TrainerName)", con);
            SqlCommand cmd2 = new SqlCommand("delete FROM Users WHERE name = @TrainerName", con);

            cmd.Parameters.AddWithValue("@TrainerName", name);
            cmd2.Parameters.AddWithValue("@TrainerName", name);
            cmd.ExecuteNonQuery();

            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
                status = "Trainer Deleted";
            else
                status = "Unable to Delete Trainer";
            con.Close();
            return status;
        }
    }
}
