using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Home_Trade
{
    class DataBase
    {

        static string con = File.ReadLines("Sqlcon.txt").ElementAtOrDefault(0);

        SqlConnection sqlCon = new SqlConnection(@con);

        public void OpenConnection()
        {
          
            if (sqlCon.State==System.Data.ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }
                catch(SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                        MessageBox.Show(errorMessages.ToString(), "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void CloseConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return sqlCon;
        }



        public int getID(string login)
        {

            string queryString = $"select id from users where user_login = '{login}'";
            int ID = -1;

            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
     

                SqlCommand command = new SqlCommand(queryString, sqlCon);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                ID = dataReader.GetInt32(0);
                dataReader.Close();
                CloseConnection();
            }
            return ID;
        }

        public string getLogin(int ID)
        {
            string queryString = $"select user_login from users where id = '{ID}'";
            string login = "";

            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                
                SqlCommand command = new SqlCommand(queryString, sqlCon);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                login = reader.GetString(0);
                reader.Close();
                CloseConnection();
            }
            return login;
        }

        public bool userCheck(string loginUser, string passUser)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                string queryString = $"select user_login,user_pass from users where user_login = '{loginUser}' and user_pass = '{passUser}'";
                SqlCommand command = new SqlCommand(queryString, sqlCon);

                adapter.SelectCommand = command;
                adapter.Fill(table);
               
                if (table.Rows.Count == 1)
                {
                    return true;
                }
                CloseConnection();
            }
            return false;
        }

        public bool adminCheck(string loginUser, string passUser)
        {
            OpenConnection();
            bool admin = false;
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                string queryString = $"select admin from users where user_login = '{loginUser}' and user_pass = '{passUser}'";

                SqlCommand command = new SqlCommand(queryString, sqlCon);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                admin = reader.GetBoolean(0);
                reader.Close();
                CloseConnection();
            }
            return admin;
        }


        public bool userAdd( string loginUser, string passUser)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                
                string queryString = $"insert into users(user_login,user_pass) values ('{loginUser}','{passUser}')";

                SqlCommand command = new SqlCommand(queryString, sqlCon);
               
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                CloseConnection();
            }
            return false;

        }


        public bool apartAdd(int userID,string district, string sqr, string layout, string login)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();

                string queryString = $"insert into apartament(owner_id,district, sqr, layout,trade_state,trade_offer_id,owner_login) values ('{userID}','{district}','{sqr}','{layout}',0,0,'{login}')";

                SqlCommand command = new SqlCommand(queryString, sqlCon);
                
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                CloseConnection();
            }
            return false;
        }


        public bool apartCheck(string userID, string district, string sqr, string layout)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();

                string queryString = $"select district,sqr,layout from apartament where district ='{district}',sqr ='{sqr}', layout = '{layout}')";

                SqlCommand command = new SqlCommand(queryString, sqlCon);

                adapter.SelectCommand = command;
                adapter.Fill(table);
               
                if (table.Rows.Count == 1)
                {
                    return true;
                }
                CloseConnection();
            }

            return false;

        }

        public void apartDelete(int apId)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                string queryString = $"delete from apartament where id ='{apId}'";

                SqlCommand command = new SqlCommand(queryString, sqlCon);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }


        public int tradeStateCheck(int apId)
        {
            OpenConnection();

            int tradeState = -1;
            string querystring = $"select trade_state from apartament where id ='{apId}'";
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                tradeState = reader.GetInt32(0);
                CloseConnection();
                reader.Close();
            }
            return tradeState;
        }

        public void tradeStateChange(int apId, int newState)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                string querystring = $"update apartament set trade_state = '{newState}' where id='{apId}'";
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                command.ExecuteNonQuery();
                CloseConnection();
            }

        }

        public void tradeOfferChange(int apId,int offerId)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                string querystring = $"update apartament set trade_offer_id = '{offerId}' where id='{apId}'";
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                command.ExecuteNonQuery();
                querystring = $"update apartament set trade_state = 3 where id='{apId}'";
                command = new SqlCommand(querystring, sqlCon);
                command.ExecuteNonQuery();
                querystring = $"update apartament set trade_state = 3 where id='{offerId}'";
                command = new SqlCommand(querystring, sqlCon);
                command.ExecuteNonQuery();
                CloseConnection();
            }

        }


        public void tradeOfferReset(int apId)
        {
            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                string querystring = $"update apartament set trade_offer_id = 0 where id='{apId}'";
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                command.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public int tradeOfferCheck(int apId)
        {
           
            int offerState = -1;
            string querystring = $"select trade_offer_id from apartament where id ='{apId}'";
            OpenConnection();

            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                offerState = reader.GetInt32(0);
                CloseConnection();
                reader.Close();
            }
            return offerState;

        }

        public int getIdbyAp(int apId)
        {
            
            int id = -1;
            string querystring = $"select owner_id from apartament where id ='{apId}'";

            OpenConnection();
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(querystring, sqlCon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                id = reader.GetInt32(0);
                CloseConnection();
                reader.Close();
            }
            return id;
        }


    }
}
