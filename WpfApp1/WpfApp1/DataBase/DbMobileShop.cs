using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.View;
using MySqlX.XDevAPI.Common;
using System.Runtime.InteropServices.WindowsRuntime;
using WpfApp1.Model;

namespace WpfApp1.DataBase
{
    internal class DbMobileShop
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["hciMobileShop"].ConnectionString;
        public static List<string> ThemeAttributes = new List<string>();
        public static Article UpdatedArticle = new Article();
        public static Account LoggedAccount;
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
                    DateOfBirth = reader.GetString(3)

                }); ;
            }
            reader.Close();
            conn.Close();
            return result;
        }

        public static List<Account> GetAccounts()
        {
            List<Account> result = new List<Account>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `nalog`";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(3) != null)
                    result.Add(new Account()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Password = reader.GetString(2),
                        ThemeColor = reader.GetString(3),
                        ThemeFontSize = reader.GetString(4),
                        ThemeFontStyle = reader.GetString(5),
                        Language = reader.GetString(6)
                    });


            }

            return result;
        }



        public static List<Article> GetArticlesByCategory(string category)
        {
            List<Article> result = new List<Article>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `artikal` WHERE `KategorijaArtikla` = '" + category + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Article()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    NumberOfArticles = reader.GetInt32(2),
                    ArticleCategory = reader.GetString(3),
                    ArticlePrice = reader.GetInt32(4),
                    Varrranty = reader.GetInt32(5),
                    Description = reader.GetString(6)

                });
            }
            return result;
        }

        public static bool IsAdmin(Account acc)
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand mySqlCommand = con.CreateCommand();
            mySqlCommand.CommandText = "SELECT * FROM `administrator`";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (acc.Id == reader.GetInt32(4))
                {
                    return true;
                }
            }
            return false;

        }

        public static void changeThemeParameters()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("change_Theme_Parameters", connection))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@nalogID", LoggedAccount.Id);
                    cmd.Parameters.AddWithValue("@lang", ThemeAttributes[0]);
                    cmd.Parameters.AddWithValue("@color", ThemeAttributes[1]);
                    cmd.Parameters.AddWithValue("@fontsize", ThemeAttributes[2]);
                    cmd.Parameters.AddWithValue("@fontstyle", ThemeAttributes[3]);
                    MySqlDataReader reader = cmd.ExecuteReader();



                }
            }
        }

        public static void AddArticle(Article art)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand mySqlCommand = con.CreateCommand();
            mySqlCommand.CommandText = "insert into artikal (NazivArtikla,BrojArtikalaNaStanju,KategorijaArtikla,CijenaArtikla,GarantniList) values (" + "'" + art.Name + "'," + "'" + art.NumberOfArticles + "'," + "'" + art.ArticleCategory + "'," + "'" + art.ArticlePrice + "'," + "'" + art.Varrranty + "'" + ")";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
        }

        public static void DeleteArticle(Article article)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand sqlCommand = con.CreateCommand();
            sqlCommand.CommandText = "delete from artikal where idArtikal='" + article.Id + "'";
            MySqlDataReader reader = sqlCommand.ExecuteReader();
        }

        public static void EditArticle(Article article)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("update_article", connection))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    Console.WriteLine("++++++++++" + article.Id);
                    cmd.Parameters.AddWithValue("@id", article.Id);
                    cmd.Parameters.AddWithValue("@naziv_artikla", article.Name);
                    cmd.Parameters.AddWithValue("@br_artikala", article.NumberOfArticles);
                    cmd.Parameters.AddWithValue("@kategorija", article.ArticleCategory);
                    cmd.Parameters.AddWithValue("@cijena", article.ArticlePrice);
                    cmd.Parameters.AddWithValue("@garancija", article.Varrranty);
                    cmd.Parameters.AddWithValue("@opis", article.Description);
                    MySqlDataReader reader = cmd.ExecuteReader();



                }
            }
        }

        public static Article GetaArticleById(int id)
        {
            Article article = null;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `artikal` WHERE `idArtikal` = '" + id + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                article = new Article {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    NumberOfArticles = reader.GetInt32(2),
                    ArticleCategory = reader.GetString(3),
                    ArticlePrice = reader.GetInt32(4),
                    Varrranty = reader.GetInt32(5),
                    Description = reader.GetString(6)

                };
            }
            return article;
        }
        //zavrsiti getallitems
        public static List<SaleItem> GetAllSaleItemsBySale()
        {
            List<SaleItem> res = new List<SaleItem>();



            return res;
        }

        public static int CreateSale(string jmbg, DateTime dateTime, List<SaleItem> items)
        {
            int res = 0;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand mySqlCommand = con.CreateCommand();
            mySqlCommand.CommandText = "insert into prodaja (`Zaposleni_JMBG`,`DatumProdaje`) values (" + "'" + jmbg + "'," + "'" + "2023-04-02" + "')";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            res = Convert.ToInt32(mySqlCommand.LastInsertedId);
            Console.WriteLine(res);
            //iskoristiti id za kreiranje prodajastavke
        

            foreach(SaleItem item in items)
            {
             
                DbMobileShop.CreateSaleItem(res, item.ArticleId, item.AmountOfArticles, item.TotalPrice);
            }
            return res;
        }

        public static string GetUIDbyAccountID(int id)
        {
            string res = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("get_UID_by_AccountID", connection))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlParameter outParameter = new MySqlParameter("@jmbg", MySqlDbType.VarChar);
                    outParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outParameter);
                    MySqlDataReader reader = cmd.ExecuteReader();
                   res = Convert.ToString(outParameter.Value);

                }
            }

            return res;
        }
        
        public static void CreateSaleItem(int brProdaje,int id, int brArtikala, double cijena)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand mySqlCommand = con.CreateCommand();
            mySqlCommand.CommandText = "insert into prodajastavka (`Prodaja_brojProdaje`,`Artikal_idArtikal`,`brojArtikala`,`UkupnaCijena`) values (" + "'" + brProdaje + "',"  + "'" + id + "'," + "'" + brArtikala + "'," + "'" + cijena + "')";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
        }

        public static List<Sale> GetSales()
        {
            List<Sale> res = new List<Sale>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `prodaja`";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                res.Add(new Sale()
                {
                    SaleNumber = reader.GetInt32(0),
                    EmployeeUID = reader.GetString(1),
                    SaleDate = reader.GetString(2),
                    EmployeeNameAndSurname = GetEmployeeById(reader.GetString(1)).FirstName + " " + GetEmployeeById(reader.GetString(1)).LastName
                }); 
            }
                return res;
        }

        public static Employee GetEmployeeById(string id)
        {
            Employee emp = new Employee();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `zaposleni` WHERE `JMBG` = '" + id + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                emp = new Employee
                {
                    UID = reader.GetString(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    DateOfBirth = reader.GetString(3),
                    YearOfEmployment = reader.GetString(4),
                    Email = reader.GetString(5),
                    ExpirationOfContract = reader.GetString(6),
                    Salary = reader.GetInt32(7),
                    Address = reader.GetString(8),


                };
            
            }
            return emp;
        }

    }
}
