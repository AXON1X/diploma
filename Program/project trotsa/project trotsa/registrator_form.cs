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
    public partial class registrator_form : Form
    {
        Form oldForm = new Form();
        DB obj_registrator_db;
        DataTable applicants;
        int counter = 0;
        public registrator_form(Form previous)
        {
            InitializeComponent();
            oldForm = previous;
            obj_registrator_db = new DB(files_work.read_server_data_file());
            applicants = obj_registrator_db.load_all_applicants(counter);
            label_counter_dgv.Text += applicants.Rows.Count.ToString();
            set_applicants();
        }

        void set_applicants()
        {

            if(comboBox_Counter.SelectedIndex != -1)
            {
                applicants = obj_registrator_db.load_all_applicants(counter, Convert.ToInt32(comboBox_Counter.Text));
                DGV_Applicants.DataSource = applicants;
                label_counter_dgv.Text = $"{counter+1}—{counter+Convert.ToInt32(comboBox_Counter.Text)}";
            }
            else 
            {
                applicants = obj_registrator_db.load_all_applicants(counter);
                DGV_Applicants.DataSource = applicants;
                label_counter_dgv.Text = $"{counter+1}—{counter+10}";
            }
            
        }

        private void registrator_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            oldForm.Show();
        }

        private void button_ten_next_Click(object sender, EventArgs e)
        {
            if(comboBox_Counter.SelectedIndex != -1)
            {
                counter+= Convert.ToInt32(comboBox_Counter.Text);
            }
            else
            {
                counter+=10;
            }
            applicants = obj_registrator_db.load_all_applicants(counter);
            set_applicants();
        }

        private void button_ten_previous_Click(object sender, EventArgs e)
        {
            if (comboBox_Counter.SelectedIndex != -1)
            {
                counter-= Convert.ToInt32(comboBox_Counter.Text);
            }
            else
            {
                counter-=10;
            }
            if(counter < 0) { counter = 0; }
            applicants = obj_registrator_db.load_all_applicants(counter);
            set_applicants();
        }

        private void button_to_start_list_Click(object sender, EventArgs e)
        {
            counter=0;
            if(comboBox_Counter.SelectedIndex != -1)
            {
                applicants = obj_registrator_db.load_all_applicants(counter, Convert.ToInt32(comboBox_Counter.Text));
            }
            else
            {
                applicants = obj_registrator_db.load_all_applicants(counter);
            }
            
            set_applicants();
        }
        private void comboBox_Counter_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_counter_dgv.Text = $"{counter+1}—{counter+Convert.ToInt64(comboBox_Counter.Text)}";
            set_applicants();
        }
    }
}
