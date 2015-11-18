using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KalDatabase
{
    public class DBConnect
    {
        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            _server = "185.25.148.252";
            _database = "virt1135_FP";
            _uid = "virt1135_guest";
            _password = "guest";
            string connectionString =   "SERVER=" + _server + ";" +
                                        "DATABASE=" + _database + ";" +
                                        "UID=" + _uid + ";" +
                                        "PASSWORD=" + _password + ";";
            _connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password!");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //public List<string> Select(string data, bool distinct, string table, string where)
        //{
        //    where = (where == "") ? "" : " where " + where;
        //    string query = (distinct) ? 
        //        "select distinct " + data + " from " + table + where
        //        : "select " + data + " from " + table + where;

        //    List<string> list = new List<string>();

        //    MySqlCommand cmd = new MySqlCommand(query, _connection);
        //    MySqlDataReader dataReader = cmd.ExecuteReader();

        //    while (dataReader.Read())
        //    {
        //        list.Add(dataReader[data].ToString());
        //    }
        //    dataReader.Close();
        //    return list;
        //}

        public List<string>[] Select (string data, bool distinct, string table, string where)
        {
            where = (where == "") ? "" : " where " + where;
            string query = (distinct) ?
                "select distinct " + data + " from " + table + where
                : "select " + data + " from " + table + where;

            int row = 0;
            string[] dataList = new string[GetRows(data)];

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',') row++;
                else 
                if (data[i] != ' ') dataList[row] += data[i];
            }
            row++;

            List<string>[] list = new List<string>[row];
            for (int i = 0; i < row; i++)
            {
                list[i] = new List<string>();
            }

            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                for (int i = 0; i < row; i++)
                {
                    list[i].Add(dataReader[dataList[i]].ToString());
                }
            }
            dataReader.Close();
            return list;
        }

        private int GetRows(string data)
        {
            int rows = 1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',') rows++;         
            }
            return rows;
        }


    }
}
