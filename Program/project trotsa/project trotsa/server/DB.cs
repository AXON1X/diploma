using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using project_trotsa.JSON;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        public DataTable get_fio(string id)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT surname, `name`, patronymic FROM trotsa.applicants where ID_applicant = \'"+id+"\';";
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
        public DataTable get_dop_info(string id)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT * FROM trotsa.personal_data_applicant where ID_applicant = \'"+id+"\';";
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
        public DataTable get_exam_info(string id)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT * FROM trotsa.exam_applicants where ID_applicant = \'"+id+"\';";
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
        public DataTable get_exam_requirements(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call trotsa.get_exam_requirements(\'"+code_facultie+"\');";
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
        public DataTable search_applicants(string str)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT ID_applicant as  `Идентификатор`, surname as `Фамилия`, `name` as `Имя`, patronymic as `Отчество` FROM trotsa.applicants " +
                "where ID_applicant like '%"+str+"%' or surname like '%"+str+"%' or `name` like  '%"+str+"%' or patronymic like '%"+str+"%';";
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
        public DataTable get_access_to_exams(string id)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "call trotsa.access_to_exams(\'"+id+"\');";
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
        public string get_current_facultie_applicant(string id_applicant)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.get_current_facultie_applicant("+id_applicant+");";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            try
            {
                adapter.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string facultie_name(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.facultie_name(\'"+code_facultie+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            try
            {
                adapter.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string facultie_short_name(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.facultie_short_name(\'"+code_facultie+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            try
            {
                adapter.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public void set_dop_info(string id, bool Disability, bool Privileges, bool Orphan, string Documents_Commentary, string Commentary)
        {
            open_conn();
            cmd = "UPDATE `trotsa`.`personal_data_applicant` SET `Disability` = \'"+Convert.ToInt32(Disability)+"\', `Privileges` = \'"+Convert.ToInt32(Privileges)+"\', `Orphan` = \'"+Convert.ToInt32(Orphan)+"\'," +
                " `Documents_Commentary` = \'"+Documents_Commentary+"\', `Commentary` = \'"+Commentary+"\' WHERE (`ID_applicant` = \'"+id+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void set_exam_info(string id, uint russian, uint math, uint social_science, uint physic, uint history, uint computer_science,
            uint biology, uint chemistry, uint geography, uint literature, uint foreign_language)
        {
            open_conn();
            cmd = "UPDATE `trotsa`.`exam_applicants` SET `russian` = \'"+russian+"\', `math` = \'"+math+"\', `social_science` = \'"+social_science+"\'," +
                " `physic` = \'"+physic+"\', `history` = \'"+history+"\', `computer_science` = \'"+computer_science+"\', " +
                "`biology` = \'"+biology+"\', `chemistry` = \'"+chemistry+"\', `geography` = \'"+geography+"\', " +
                "`literature` = \'"+literature+"\', `foreign_language` = \'"+foreign_language+"\' WHERE (`ID_applicant` = \'"+id+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void set_exam_info_pd(string id, uint score)
        {
            open_conn();
            cmd = "UPDATE `trotsa`.`personal_data_applicant` SET `exam_scores` = \'"+score+"\' WHERE (`ID_applicant` = \'"+id+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
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
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void change_code_facultie(string old_code, string new_code)
        {
            open_conn();
            cmd = "call trotsa.change_code(\'"+old_code+"\', \'"+new_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void delete_old_code_facultie(string old_code)
        {
            open_conn();
            cmd = "call trotsa.delete_old_code_facultie(\'"+old_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void delete_facultie(string delete_code)
        {
            open_conn();
            cmd = "call trotsa.delete_facultie(\'"+delete_code+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void add_facultie(string code_facultie, string name_facultie, string short_name)
        {
            open_conn();
            cmd = "call trotsa.add_facultie(\'"+code_facultie+"\', \'"+name_facultie+"\', \'"+short_name+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void delete_applicant(string id)
        {
            open_conn();
            cmd = "call trotsa.delete_applicant("+id+");";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void add_applicant(string surname, string name, string patronymic)
        {
            open_conn();
            cmd = "call `trotsa`.`add_applicant`(\'"+name+"\',\'"+surname+"\',\'"+patronymic+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void update_requirements_exam(string code_facultie_param, bool russian, bool math, bool social_science, bool physic,
            bool history, bool computer_science, bool biology, bool chemistry, bool geography, bool literature, bool foreign_language)

        {
            open_conn();
            cmd = "call trotsa.change_requirements_exam_faculty(\'"+code_facultie_param+"\', \'"+Convert.ToInt32(russian)+"\', \'"+Convert.ToInt32(math)+"\', \'"+Convert.ToInt32(social_science)+"\'," +
                " \'"+Convert.ToInt32(physic)+"\', \'"+Convert.ToInt32(history)+"\', \'"+Convert.ToInt32(computer_science)+"\'," +
                " \'"+Convert.ToInt32(biology)+"\', \'"+Convert.ToInt32(chemistry)+"\'," +
                " \'"+Convert.ToInt32(geography)+"\', \'"+Convert.ToInt32(literature)+"\', \'"+Convert.ToInt32(foreign_language)+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void edit_fio(string id, string surname, string name, string patronymic)
        {
            open_conn();
            cmd = "call trotsa.edit_fio_applicants(\'"+id+"\', \'"+surname+"\', \'"+name+"\', \'"+patronymic+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void add_applicant_to_facultie(string id, string code_facultie)
        {
            open_conn();
            cmd = "call trotsa.add_applicant_facultie(\'"+id+"\', \'"+code_facultie+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
        }
        public void delete_applicant_to_facultie(string id, string code_facultie)
        {
            open_conn();
            cmd = "call trotsa.delete_applicant_from_facultie(\'"+id+"\', \'"+code_facultie+"\');";
            sql = new MySqlCommand(cmd, get_conn());
            try
            {
                sql.ExecuteNonQuery();
                close_conn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_conn();
                return;
            }
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
                return true;
            }
            else
            {
                return false;
            }
            
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
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool facultie_exists(string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select `facultie exist`(\'"+code_facultie+"\') as `bool`;";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            if ((bool)dt.Rows[0][0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUserAdmin(string login)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.IsUserAdmin(\'"+login+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            if ((bool)dt.Rows[0][0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool applicant_exists_facultie(string id, string code_facultie)
        {
            dt.Clear();
            dt.Columns.Clear();
            cmd = "select trotsa.exists_applicants_in_facultie(\'"+code_facultie+"\', \'"+id+"\');";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            if ((bool)dt.Rows[0][0])
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public List<string> load_all_faculties_adm()
        {
            List<string> faculties_list = new List<string>();
            dt.Clear();
            dt.Columns.Clear();
            cmd = "SELECT code_facultie FROM faculties;";
            adapter.SelectCommand = new MySqlCommand(cmd, get_conn());
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                faculties_list.Add(dt.Rows[i][0].ToString());
            }
            return faculties_list;
        }
    }
}
