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

namespace project_trotsa
{
    public partial class facultie : Form
    {
        DB obj_facultie_db = null;
        public facultie(string facultie)
        {
            InitializeComponent();
            label_facultie.Text += "Изменение";
            this.Text = facultie;
            textBox_code_facultie.Text = facultie;
            obj_facultie_db = new DB(files_work.read_server_data_file());
            textBox_name_facultie.Text = obj_facultie_db.facultie_name(this.Text);
            textBox_short_name.Text = obj_facultie_db.facultie_short_name(this.Text);
        }
        public facultie()
        {
            InitializeComponent();
            label_facultie.Text += "Добавление"; 
            button_delete_facultie.Visible = false;
            button_add_change.Text = "Добавить";
        }

        private void button_delete_facultie_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
            {
            
            }
        }

        private void button_add_change_Click(object sender, EventArgs e)
        {
            if(this.Name != "Факультет")
            {
                if (!obj_facultie_db.facultie_exists(textBox_code_facultie.Text))
                {
                    obj_facultie_db.update_facultie(this.Name, textBox_code_facultie.Text,
                    textBox_name_facultie.Text, textBox_short_name.Text);
                }
                else
                {
                    MessageBox.Show("Такой код уже существует!", "Факультет:ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else 
            {
                if(!obj_facultie_db.facultie_exists(textBox_code_facultie.Text))
                {

                }
                else 
                {
                    MessageBox.Show("Такой код уже существует!", "Факультет:ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void facultie_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
