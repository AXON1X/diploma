using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Google.Protobuf.Compiler;
using System.Runtime.Remoting.Channels;

namespace project_trotsa.JSON
{
    class files_work
    {
        static void check_safe_space()
        {
            if(!Directory.Exists(Directory.GetCurrentDirectory() + "\\save_data"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\save_data");
            }
        }

        static void check_safe_files() 
        {
            if(!File.Exists(Directory.GetCurrentDirectory() + "\\save_data\\server_data.json"))
            {
                File.Create(Directory.GetCurrentDirectory()+ "\\save_data\\server_data.json");
                StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\save_data\\server_data.json", true);
                writer.Write("{ \"server\":\"\",\"port\":\"3306\",\"username\":\"root\",\"password\":\"\",\"database\":\"\"}");
            }

            if (!File.Exists(Directory.GetCurrentDirectory() + "\\save_data\\registar_data.json"))
            {
                File.Create(Directory.GetCurrentDirectory()+ "\\save_data\\registar_data.json");
            }
        }

        public static void check_safe()
        {
            check_safe_space();
            check_safe_files();
        }

        static public void save_server_data(server_data sd)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\save_data\\server_data.json", FileMode.Create);

            JsonSerializer.Serialize<server_data>(fs, sd);
            fs.Close();
        }
        static public void save_registar_data(registar rd)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\save_data\\registar_data.json", FileMode.Create);
            JsonSerializer.Serialize<registar>(fs, rd);
            fs.Close();
        }

        static public server_data read_server_data_file()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\save_data\\server_data.json", FileMode.Open);
            server_data return_data = new server_data();
            try
            {
                server_data? data = JsonSerializer.Deserialize<server_data>(fs);
                return_data = (server_data)data;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            fs.Close();
            return return_data;
        }
        static public registar read_registar_data_file()
        {
            registar rd = new registar();
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\save_data\\registar_data.json", FileMode.Open);
            try
            {
                registar? data = JsonSerializer.Deserialize<registar>(fs);
                rd = (registar)data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            fs.Close();
            return rd;
        }
        static public void clear_registar_data_file()
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\save_data\\registar_data.json", FileMode.Create);
            fs.Close();

        }
    }
    struct server_data
    {
        public string server { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string database { get; set; }

        public bool all_value_filled()
        {
            if(server != "" && port != "" && username != ""
                && password != "" && database != "")
            {
                return true;
            }
            return false;
        }

        public void clear()
        {
            this.server = "";
            this.port = "";
            this.username = "";
            this.password = "";
            this.database = "";
        }
    }
    struct registar
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public DateTime bun_date { get; set; }
    }


}
