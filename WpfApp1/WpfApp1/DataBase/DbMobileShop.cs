using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBase
{
    internal class DbMobileShop
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["hciMobileShop"].ConnectionString;
        public static List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT *  FROM `zaposleni` ORDER BY Ime"; 
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Employee()
                {
                    UID = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    dateOfBirth = reader.GetString(3)

                }); ;
            }
            reader.Close();
            conn.Close();
            return result;
        }
    }
}
