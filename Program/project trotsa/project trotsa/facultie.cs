using project_trotsa.JSON;
using project_trotsa.server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace project_trotsa
{
    public partial class facultie : Form
    {
        DB obj_facultie_db = null;

        struct obj_facultie
        {
            public string id { get; set; }
            public string name {get; set;}
            public string shrt_name {get; set;}
        }
        obj_facultie obj_Facultie = new obj_facultie();
        public facultie(string facultie)
        {
            InitializeComponent();
            label_facultie.Text += "Изменение";
            this.Text = facultie;
            textBox_code_facultie.Text = facultie;
            obj_facultie_db = new DB(files_work.read_server_data_file());
            textBox_name_facultie.Text = obj_facultie_db.facultie_name(this.Text);
            textBox_short_name.Text = obj_facultie_db.facultie_short_name(this.Text);

            obj_Facultie.id = this.Text;
            obj_Facultie.name = textBox_name_facultie.Text;
            obj_Facultie.shrt_name = textBox_short_name.Text;

            button_add_change.Text = "изменить";
        }
        public facultie()
        {
            InitializeComponent();
            label_facultie.Text += "Добавление"; 
            button_delete_facultie.Visible = false;
            obj_facultie_db = new DB(files_work.read_server_data_file());
        }

        private void button_delete_facultie_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
            {
                obj_facultie_db.delete_facultie(this.Text);
                this.Close();
            }
        }

        private void button_add_change_Click(object sender, EventArgs e)
        {
            if (textBox_code_facultie.Text == "" || textBox_name_facultie.Text == ""
                    || textBox_short_name.Text == "")
            {
                MessageBox.Show("Заполните все данные!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (this.Text != "специальность")
            {
                if(obj_Facultie.id == textBox_code_facultie.Text && obj_Facultie.name == textBox_name_facultie.Text
                    && obj_Facultie.shrt_name == textBox_short_name.Text)
                {
                    MessageBox.Show("Вы ничего не поменяли!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(obj_Facultie.id == textBox_code_facultie.Text && (obj_Facultie.name != textBox_name_facultie.Text
                    || obj_Facultie.shrt_name != textBox_short_name.Text))
                {
                    obj_facultie_db.change_data_facultie(textBox_code_facultie.Text, textBox_name_facultie.Text, textBox_short_name.Text);
                }
                else if(obj_Facultie.id != textBox_code_facultie.Text && obj_Facultie.name == textBox_name_facultie.Text
                    && obj_Facultie.shrt_name == textBox_short_name.Text)
                {
                    obj_facultie_db.change_code_facultie(obj_Facultie.id, textBox_code_facultie.Text);
                    obj_facultie_db.delete_old_code_facultie(obj_Facultie.id);
                }
                else if(obj_Facultie.id != textBox_code_facultie.Text && (obj_Facultie.name != textBox_name_facultie.Text
                    || obj_Facultie.shrt_name != textBox_short_name.Text))
                {
                    obj_facultie_db.change_data_facultie(textBox_code_facultie.Text, textBox_name_facultie.Text, textBox_short_name.Text);
                    obj_facultie_db.change_code_facultie(obj_Facultie.id, textBox_code_facultie.Text);
                    obj_facultie_db.delete_old_code_facultie(obj_Facultie.id);
                }

                obj_Facultie.id = textBox_code_facultie.Text;
                obj_Facultie.name = textBox_name_facultie.Text;
                obj_Facultie.shrt_name = textBox_short_name.Text;
                this.Text = obj_Facultie.id;
            }
            else 
            {
                if (obj_facultie_db.facultie_exists(textBox_code_facultie.Text))
                {
                    
                    MessageBox.Show("Такой код уже существует!", "специальность:ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    obj_facultie_db.add_facultie(textBox_code_facultie.Text, textBox_name_facultie.Text, textBox_short_name.Text);
                }
            }
        }
    }
}
