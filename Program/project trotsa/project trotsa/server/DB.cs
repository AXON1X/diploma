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
        MySqlCommand sql = null;
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
            cmd = "";
            sql = null;
            dt.Columns.Clear();
            conn = null;
            Server_Data.clear();
        }
        public MySqlConnection get_conn()
        {
            return conn;
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
        public void change_data_facultie(string code_facultie, string name, string short_name)
        {
            open_conn();
            cmd = "call trotsa.update_data_facultie(\'"+code_facultie+"\', \'"+name+"\', \'"+short_name+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void change_code_facultie(string old_code, string new_code)
        {
            open_conn();
            cmd = "call trotsa.change_code(\'"+old_code+"\', \'"+new_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void delete_old_code_facultie(string old_code)
        {
            open_conn();
            cmd = "call trotsa.delete_old_code_facultie(\'"+old_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void delete_facultie(string delete_code)
        {
            open_conn();
            cmd = "call trotsa.delete_facultie(\'"+delete_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void add_facultie(string code_facultie, string name_facultie, string short_name)
        {
            open_conn();
            cmd = "call trotsa.add_facultie(\'"+code_facultie+"\', \'"+name_facultie+"\', \'"+short_name+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void delete_applicant(string id)
        {
            open_conn();
            cmd = "call trotsa.delete_applicant("+id+");";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
        }
        public void add_applicant(string surname, string name, string patronymic)
        {
            open_conn();
            cmd = "call `trotsa`.`add_applicant`(\'"+name+"\',\'"+surname+"\',\'"+patronymic+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            sql.ExecuteNonQuery();
            close_conn();
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
        public bool authorization(string set_login, string set_password)
        {
            dt.Clear();
            dt.Columns.Clear();
            open_conn();
            if (!get_bool_conn())
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

        public bool IsUserAdmin(string login)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.IsUserAdmin(\'"+login+"\');";
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
        public DataTable load_all_applicants(int start_limit, int end_limit)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call get_applicants("+start_limit+", "+end_limit+");";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public DataTable load_applicants_facultie(string facultie, int start_limit, int end_limit)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call trotsa.get_applicants_facultie(\'"+facultie+"\', "+start_limit+", "+end_limit+");";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
    }
}
