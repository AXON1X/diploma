using Mysqlx.Resultset;
using project_trotsa.JSON;
using project_trotsa.server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            comboBox_Counter.SelectedIndex = 0;
            updateComboBox_facultie();
            applicants = obj_registrator_db.load_all_applicants(counter, counter+Convert.ToInt32(comboBox_Counter.Text));
            label_counter_dgv.Text += applicants.Rows.Count.ToString();
            set_applicants();
            DGV_Applicants.AllowUserToAddRows = false;
        }

        public void updateComboBox_facultie()
        {
            comboBox_faculties.DataSource = null;
            comboBox_faculties.DataSource = obj_registrator_db.load_all_faculties();
        }

        void set_applicants()
        {
            DGV_Applicants.AllowUserToAddRows = true;
            if (comboBox_faculties.Text == "все")
            {
                applicants = obj_registrator_db.load_all_applicants(counter, Convert.ToInt32(comboBox_Counter.Text));
            }
            else
            {
                applicants = obj_registrator_db.load_applicants_facultie(comboBox_faculties.Text, counter, counter+Convert.ToInt32(comboBox_Counter.Text));
            }
           
           DGV_Applicants.DataSource = applicants;
           label_counter_dgv.Text = $"{counter+1}—{counter+Convert.ToInt32(comboBox_Counter.Text)}";
           DGV_Applicants.AllowUserToAddRows = false;

        }

        private void registrator_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            oldForm.Show();
        }

        private void button_ten_next_Click(object sender, EventArgs e)
        {
            counter+= Convert.ToInt32(comboBox_Counter.Text);
            applicants = obj_registrator_db.load_all_applicants(counter, counter+Convert.ToInt32(comboBox_Counter.Text));
            set_applicants();
        }

        private void button_ten_previous_Click(object sender, EventArgs e)
        {
            counter-= Convert.ToInt32(comboBox_Counter.Text);
            if(counter < 0) { counter = 0; }
            applicants = obj_registrator_db.load_all_applicants(counter, counter+Convert.ToInt32(comboBox_Counter.Text));
            set_applicants();
        }

        private void button_to_start_list_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            counter=0;
            applicants = obj_registrator_db.load_all_applicants(counter, Convert.ToInt32(comboBox_Counter.Text));
            set_applicants();
        }
        private void comboBox_Counter_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_counter_dgv.Text = $"{counter+1}—{counter+Convert.ToInt64(comboBox_Counter.Text)}";
            set_applicants();
        }

        private void comboBox_faculties_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_faculties.SelectedText == "все")
            {
                label_facultie.Text = "специальность";
            }
            else 
            {
                label_facultie.Text = "специальность: " + obj_registrator_db.facultie_short_name(comboBox_faculties.Text);
            }
            set_applicants();
        }

        private void button_add_facultie_Click(object sender, EventArgs e)
        {
            facultie facultie = new facultie();
            facultie.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            facultie.ShowDialog();
        }
        private void facultie_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            oldForm.Show();
        }

        private void button_edit_facultie_Click(object sender, EventArgs e)
        {
            if(comboBox_faculties.Text == "все")
            {
                return;
            }
            facultie facultie = new facultie(comboBox_faculties.Text);
            facultie.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            facultie.ShowDialog();
        }

        void facultie_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateComboBox_facultie();
        }

        private void button_delete_applicants_Click(object sender, EventArgs e)
        {
            if (DGV_Applicants.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Вы не выбрали ни одного студента", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string question = "Вы действительно хотите удалить ";
            if (DGV_Applicants.SelectedRows.Count == 1) { question += "аббитуриента?"; }
            else if (DGV_Applicants.SelectedRows.Count > 1) { question += "аббитуриентов?"; }

            if (DialogResult.Yes == MessageBox.Show(question, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if(DGV_Applicants.SelectedRows.Count > 0)
                {
                    foreach(DataGridViewRow applicant_cell in DGV_Applicants.SelectedRows)
                    {
                        Console.WriteLine(applicant_cell);
                        obj_registrator_db.delete_applicant(applicant_cell.Cells[0].Value.ToString());
                    }
                }

                set_applicants();
            }
        }

        private void button_create_applicant_Click(object sender, EventArgs e)
        {
            AddApplicant addApplicant = new AddApplicant();
            addApplicant.Show();

            addApplicant.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
        }

        private void button_change_data_Click(object sender, EventArgs e)
        {
            editApplicant addApplicant = new editApplicant(DGV_Applicants.SelectedRows[0].Cells[0].Value.ToString());
            addApplicant.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            addApplicant.Show();
        }

        private void DGV_Applicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editApplicant addApplicant = new editApplicant(DGV_Applicants.SelectedRows[0].Cells[0].Value.ToString());
            addApplicant.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            addApplicant.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DGV_Applicants.DataSource = obj_registrator_db.search_applicants(textBox_search.Text);
        }
    }
}
