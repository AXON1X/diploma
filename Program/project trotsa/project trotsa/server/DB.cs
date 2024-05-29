using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using project_trotsa.JSON;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_trotsa.server
{
    internal class DB
    {
        server_data Server_Data { get; set; }

        string str_conn = "", cmd = "";

        MySqlConnection conn = null;

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataTable dt = new DataTable();

        public DB(server_data value)
        {
            Server_Data = value;
            str_conn = "server=" + value.server + ";port=" + value.port + ";username=" +
                value.username + ";password=" + value.password + ";dataBase=" + value.database + ";";
            conn = new MySqlConnection(str_conn);
        }

        ~DB()
        {
            str_conn = "";
            conn = null;
            Server_Data.clear();
        }

        public void reset_str_conn(server_data value)
        {
            Server_Data = value;
            str_conn = "server=" + value.server + ";port=" + value.port + ";username=" +
            value.username + ";password=" + value.password + ";database=" + value.database + ";";
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

        public bool search_login(string login)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.search_login_registar(\'" + login + "\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            if((bool)dt.Rows[0][0]) 
            {
                cmd = "";
                adapter.SelectCommand = null;
                dt.Clear();
                dt.Columns.Clear();
                return true;
            }
            cmd = "";
            adapter.SelectCommand = null;
            dt.Clear();
            dt.Columns.Clear();
            return false;
        }

        public bool authorization(string set_login, string set_password)
        {
            dt.Clear();
            dt.Columns.Clear();
            open_conn();
            if(!get_bool_conn()) 
            {
                MessageBox.Show("нет соединения с сервером", "DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            cmd = "select trotsa.authorization(\'" + set_login + "\', \'" + set_password + "\');";
            adapter.SelectCommand= new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            close_conn();
            if ((bool)dt.Rows[0][0])
            {
                cmd = "";
                adapter.SelectCommand = null;
                dt.Clear();
                dt.Columns.Clear();
                return true;
            }
            cmd = "";
            adapter.SelectCommand = null;
            dt.Clear();
            dt.Columns.Clear();
            return false;
        }
    }
}
