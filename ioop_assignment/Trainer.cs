using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        private string modulename;
        private string levelname;
        private string amount;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());


        public string UserID { get { return userID; } set { userID = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Modulename { get { return modulename; } set { modulename = value; } }
        public string Levelname { get { return levelname; } set { levelname = value; } }
        public string Amount { get { return amount; } set { amount = value; } }


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

        public Trainer(string name, string modulename, string levelname)
        {
            this.name = name;
            this.modulename = modulename;
            this.levelname = levelname;
        }
        public Trainer(string name, string modulename, string levelname, string amount)
        {
            this.name = name;
            this.modulename = modulename;
            this.levelname = levelname;
            this.amount = amount;
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

            SqlCommand cmd = new SqlCommand("DELETE FROM Invoice WHERE trainerID = (SELECT trainerID FROM Trainers WHERE userID IN (SELECT userID FROM Users WHERE name = @TrainerName))", con);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM TrainerModules WHERE trainerID IN (SELECT trainerID FROM Trainers WHERE userID IN (SELECT userID FROM Users WHERE name = @TrainerName));", con);
            SqlCommand cmd3 = new SqlCommand("delete FROM Trainers WHERE userID IN (SELECT userID FROM Users WHERE name = @TrainerName)", con);
            SqlCommand cmd4 = new SqlCommand("delete FROM Users WHERE name = @TrainerName", con);
            


            cmd.Parameters.AddWithValue("@TrainerName", name);
            cmd2.Parameters.AddWithValue("@TrainerName", name);
            cmd3.Parameters.AddWithValue("@TrainerName", name);
            cmd4.Parameters.AddWithValue("@TrainerName", name);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            int i = cmd4.ExecuteNonQuery();
            if (i != 0)
                status = "Trainer Deleted";
            else
                status = "Unable to Delete Trainer";
            con.Close();
            return status;
        }

        public static ArrayList viewModule()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select distinct modulename FROM Modules", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

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

        public string assignTrainer(string name, string modulename, string levelname)
        {
            string status;
            int trainerID = GetTrainerID(name);

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TrainerModules(trainerID, moduleID) SELECT @trainerID, m.moduleID FROM Modules m JOIN Levels l ON m.levelID = l.levelID WHERE m.moduleName = @ModuleName AND l.levelName = @LevelName" , con);

            cmd.Parameters.AddWithValue("@trainerID", trainerID);
            cmd.Parameters.AddWithValue("@levelName", levelname);
            cmd.Parameters.AddWithValue("@ModuleName", modulename);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Invoice (trainerID, moduleID, paymentID, amount) SELECT Trainers.trainerID, Modules.moduleID, Payment.paymentID, Modules.charges FROM Trainers INNER JOIN TrainerModules ON Trainers.trainerID = TrainerModules.trainerID INNER JOIN Modules ON TrainerModules.moduleID = Modules.moduleID INNER JOIN Levels ON Modules.levelID = Levels.levelID CROSS JOIN Payment WHERE Trainers.trainerID = @trainerID AND Modules.modulename = @ModuleName AND Levels.levelname = @levelname AND Payment.paymentstatus = 'unpaid'", con);
            cmd2.Parameters.AddWithValue("@trainerID", trainerID);
            cmd2.Parameters.AddWithValue("@ModuleName", modulename);
            cmd2.Parameters.AddWithValue("@levelName", levelname);
            cmd.ExecuteNonQuery();
            int rowsAffected = cmd2.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
                status = "Trainer Assigned";
            else
                status = "Unable to Assign Trainer";

            return status;
        }

        private int GetTrainerID(string name)
        {
            int trainerID = -1; 

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT trainerID FROM Trainers WHERE userID IN (SELECT userID FROM Users WHERE name = @TrainerName)", con);
            cmd.Parameters.AddWithValue("@TrainerName", name);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                trainerID = reader.GetInt32(0);
            }

            reader.Close();
            con.Close();

            return trainerID;
        }

        public static DataTable Loadincome()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM vwIncome", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();

            return dataTable;

        }

/*        public static List<Trainer> SearchIncomeByFilters(string trainerName, string moduleName, string levelName)
        {
            List<Trainer> incomeData = new List<Trainer>();
            con.Open();

            // Start with a base query to retrieve all income data
            string query = "SELECT TrainerName, ModuleName, LevelName, Amount FROM vwIncome WHERE 1=1";

            // Apply filters based on the selected values
            if (!string.IsNullOrEmpty(trainerName))
            {
                query += " AND TrainerName = @TrainerName";
            }

            if (!string.IsNullOrEmpty(moduleName))
            {
                query += " AND ModuleName = @ModuleName";
            }

            if (!string.IsNullOrEmpty(levelName))
            {
                query += " AND LevelName = @LevelName";
            }

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (!string.IsNullOrEmpty(trainerName))
                {
                    cmd.Parameters.AddWithValue("@TrainerName", trainerName);
                }

                if (!string.IsNullOrEmpty(moduleName))
                {
                    cmd.Parameters.AddWithValue("@ModuleName", moduleName);
                }

                if (!string.IsNullOrEmpty(levelName))
                {
                    cmd.Parameters.AddWithValue("@LevelName", levelName);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Trainer income = new Trainer(trainerName, moduleName, levelName)
                        {
                            name = reader.GetString(reader.GetOrdinal("TrainerName")),
                            modulename = reader.GetString(reader.GetOrdinal("ModuleName")),
                            levelname = reader.GetString(reader.GetOrdinal("LevelName")),
                            amount = reader.GetString(reader.GetOrdinal("Amount"))
                        };

                        incomeData.Add(income);
                    }
                }
            }
            con.Close();

            return incomeData;*/
        }

    }

