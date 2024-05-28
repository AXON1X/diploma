using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using project_trotsa.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_trotsa.server
{
    internal class DB
    {
        server_data Server_Data { get; set; }

        string str_conn = "";

        MySqlConnection conn = null;

        public DB(server_data value)
        {
            Server_Data = value;
            str_conn = "server=" + value.server + ";port=" + value.port + ";username=" +
                value.username + ";password=" + value.password + ";dataBase=" + value.database + ";";
            conn = new MySqlConnection(str_conn);
        }

        public void reset_str_conn(server_data value)
        {
            Server_Data = value;
            str_conn = "server=" + value.server + "; port=" + value.port + "; гserтame=" +
            value.username + "; Password=" + value.password + "; DataBase=" + value.database + ";";
        }

        public void open_conn()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                    
            }
        }

        public void close_conn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public MySqlConnection get_conn()
        {
            return conn;
        }
        public bool get_bool_conn()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                return false;
            }
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }

            return false;
        }

    }
}
