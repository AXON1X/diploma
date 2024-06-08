using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using project_trotsa.JSON;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        SqlCommand request = null;

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
        public DataTable load_all_applicants(int start_limit, int end_limit)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call get_applicants("+start_limit+", "+end_limit+");";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            return dt;
        }
        public DataTable load_applicants_facultie(string facultie, int start_limit, int end_limit)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call trotsa.get_applicants_facultie(\'"+facultie+"\', "+start_limit+", "+end_limit+");";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            return dt;
        }

        public List<string> load_all_faculties()
        {
            List<string> faculties_list = new List<string>();
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT code_facultie FROM faculties;";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            faculties_list.Add("все");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                faculties_list.Add(dt.Rows[i][0].ToString());
            }
            return faculties_list;
        }

        public void update_facultie(string old_code_facultie, string new_code_facultie,
            string new_name_facultie, string new_short_name)
        {
            open_conn();
            cmd = "call trotsa.update_facultie(\'"+old_code_facultie+"\', \'"+new_code_facultie+"\', \'"+new_name_facultie+"\', \'"+new_short_name+"\');";
            MySqlCommand sql = new MySqlCommand(cmd, get_conn());

            if(sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменено", "Факультет", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            close_conn();

        }

        public bool facultie_exists(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select `facultie exist`(\'"+code_facultie+"\') as `bool`;";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            if (Convert.ToBoolean(dt.Rows[0][0]))
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
        public string facultie_name(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.facultie_name(\'"+code_facultie+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        public string facultie_short_name(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.facultie_short_name(\'"+code_facultie+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
    }
}
