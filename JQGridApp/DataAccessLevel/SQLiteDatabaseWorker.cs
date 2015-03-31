using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;
using System.Data;
//using JQGridApp.DataAccessLevel;
using JQGridApp.Models;


namespace TheTime.DataAccessLevel
{
    /// <summary>
    /// Работает с данными в базе: insert, update, select
    /// </summary>
    class SQLiteDatabaseWorker
    {
      
        #region Done
        
        public SQLiteConnection m_dbConnection;

        /// <summary>
        /// Открывает соединение с базой данных
        /// </summary>
        /// <param name="path">Полный путь до файла БД</param>
        /// <returns></returns>
    
        public void SetConnect()
        {

           // string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Database.db";
           // string path = @"D:\DataBase.db";

            string path = @"C:\C#\Application\SimSoft\jqGrid (1)\JQGridApp\Adress.db";
         //   string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Database.db";

            m_dbConnection = new SQLiteConnection(@"Data Source=" + path + ";Version=3;datetimeformat=CurrentCulture");
            m_dbConnection.Open();
        }

        /// <summary>
        /// Закрывает соединение с базой данных
        /// </summary>
        /// <returns></returns>
        public void CloseConnect()
        {
            m_dbConnection.Close();
        }
        public List<Catalog> GetTable()
        {
            List<Catalog> table = new List<Catalog>();
            string sql = "SELECT * FROM 'Adress'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    string country = reader["Country"].ToString();
                    string city = reader["City"].ToString();
                    string street = reader["Street"].ToString();
                    int house = int.Parse(reader["House"].ToString());
                    string indexes = reader["Indexes"].ToString();
                    DateTime period = DateTime.Parse(reader["Date"].ToString());
                    string dats = period.ToString("dd-MM-yyyy");
                    DateTime result = DateTime.ParseExact(dats,"dd-MM-yyyy",CultureInfo.InvariantCulture);
                    table.Add(new Catalog { Id = id, Country = country,
                        City = city, Street = street,
                        House = house, Indekses = indexes, Date = result });
                    
                }
            }
            return table;
        }

#endregion
    }


}
