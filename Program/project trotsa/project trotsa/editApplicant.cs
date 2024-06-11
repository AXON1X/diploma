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
    public partial class editApplicant : Form
    {
        string id_applicant = "", id, code_facultie_applicant = "";
        DB obj_edit_db = new DB(files_work.read_server_data_file());
        DataTable dt = new DataTable();
        uint exam_sum = 0; 
        public editApplicant(string set_id)
        {
            InitializeComponent();
            code_facultie_applicant = obj_edit_db.get_current_facultie_applicant(set_id);
            id_applicant += set_id;
            label_id.Text += set_id;
            id = set_id;
            dt = obj_edit_db.get_fio(id);
            textBox_surname.Text = dt.Rows[0][0].ToString();
            textBox_name.Text = dt.Rows[0][1].ToString();
            textBox_patronymic.Text = dt.Rows[0][2].ToString();

            dt.Columns.Clear();
            dt.Clear();
            dt = obj_edit_db.get_dop_info(id);
            checkBox_Disability.Checked = Convert.ToBoolean(dt.Rows[0][3]);
            checkBox_Privileges.Checked = Convert.ToBoolean(dt.Rows[0][4]);
            checkBox_Orphan.Checked = Convert.ToBoolean(dt.Rows[0][5]);

            textBox_doc_com.Text = dt.Rows[0][6].ToString();
            textBox_dop_com.Text = dt.Rows[0][7].ToString();

            dt.Columns.Clear();
            dt.Clear();
            dt = obj_edit_db.get_exam_info(id);
            textBox_russian.Text = dt.Rows[0][2].ToString();
            textBox_math.Text =  dt.Rows[0][3].ToString();
            textBox_social_science.Text =  dt.Rows[0][4].ToString();
            textBox_physic.Text =  dt.Rows[0][5].ToString();
            textBox_history.Text =  dt.Rows[0][6].ToString();
            textBox_computer_science.Text =  dt.Rows[0][7].ToString();
            textBox_biology.Text =  dt.Rows[0][8].ToString();
            textBox_chemistry.Text =  dt.Rows[0][9].ToString();
            textBox_geography.Text =  dt.Rows[0][10].ToString();
            textBox_literature.Text =  dt.Rows[0][11].ToString();
            textBox_foreign_language.Text =  dt.Rows[0][12].ToString();

            exam_sum = Convert.ToUInt32(textBox_russian.Text) + Convert.ToUInt32(textBox_math.Text) + Convert.ToUInt32(textBox_social_science.Text) +
                    Convert.ToUInt32(textBox_physic.Text) + Convert.ToUInt32(textBox_history.Text) + Convert.ToUInt32(textBox_computer_science.Text) + Convert.ToUInt32(textBox_biology.Text) + Convert.ToUInt32(textBox_chemistry.Text) +
                    Convert.ToUInt32(textBox_geography.Text) + Convert.ToUInt32(textBox_literature.Text) + Convert.ToUInt32(textBox_foreign_language.Text);
            label_sum.Text = exam_sum.ToString();

            comboBox_facultie.DataSource = obj_edit_db.load_all_faculties_adm();
            block_textBox_exams();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                obj_edit_db.set_dop_info(id, checkBox_Disability.Checked, checkBox_Privileges.Checked, checkBox_Orphan.Checked, textBox_doc_com.Text, textBox_dop_com.Text);
            }
            
        }
        void block_textBox_exams()
        {
            DataTable dt_exams = obj_edit_db.get_access_to_exams(code_facultie_applicant);
            if(dt_exams.Rows.Count == 0) 
            { return; }
            textBox_russian.ReadOnly = !(bool)dt_exams.Rows[0][2];
            textBox_math.ReadOnly = !(bool)dt_exams.Rows[0][3];
            textBox_social_science.ReadOnly  = !(bool)dt_exams.Rows[0][4];
            textBox_physic.ReadOnly  = !(bool)dt_exams.Rows[0][5];
            textBox_history.ReadOnly  = !(bool)dt_exams.Rows[0][6];
            textBox_computer_science.ReadOnly  = !(bool)dt_exams.Rows[0][7];
            textBox_biology.ReadOnly = !(bool)dt_exams.Rows[0][8];
            textBox_chemistry.ReadOnly = !(bool)dt_exams.Rows[0][9];
            textBox_geography.ReadOnly  = !(bool)dt_exams.Rows[0][10];
            textBox_literature.ReadOnly = !(bool)dt_exams.Rows[0][11];
            textBox_foreign_language.ReadOnly  = !(bool)dt_exams.Rows[0][12];
            dt_exams.Columns.Clear();
            dt_exams.Clear();

            if (textBox_russian.ReadOnly) { textBox_russian.BackColor = Color.Black; } else { textBox_russian.BackColor = Color.Gray;}
            if (textBox_math.ReadOnly) { textBox_math.BackColor = Color.Black; } else { textBox_math.BackColor = Color.Gray; }
            if (textBox_social_science.ReadOnly) { textBox_social_science.BackColor = Color.Black; } else { textBox_social_science.BackColor = Color.Gray; }
            if (textBox_physic.ReadOnly) { textBox_physic.BackColor = Color.Black; } else { textBox_physic.BackColor = Color.Gray; }
            if (textBox_history.ReadOnly) { textBox_history.BackColor = Color.Black; } else { textBox_history.BackColor = Color.Gray; }
            if (textBox_computer_science.ReadOnly) { textBox_computer_science.BackColor = Color.Gray; } else { textBox_computer_science.BackColor = Color.Gray; }
            if (textBox_biology.ReadOnly) { textBox_biology.BackColor = Color.Black; } else { textBox_biology.BackColor = Color.Gray; }
            if (textBox_chemistry.ReadOnly) { textBox_chemistry.BackColor = Color.Black; } else { textBox_chemistry.BackColor = Color.Gray; }
            if (textBox_geography.ReadOnly) { textBox_geography.BackColor = Color.Black; } else { textBox_geography.BackColor = Color.Gray; }
            if (textBox_literature.ReadOnly) { textBox_literature.BackColor = Color.Black; } else { textBox_literature.BackColor = Color.Gray; }
            if (textBox_foreign_language.ReadOnly) { textBox_foreign_language.BackColor = Color.Black; } else { textBox_foreign_language.BackColor = Color.Gray; }


        }

        private void button_set_exams_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    exam_sum = Convert.ToUInt32(textBox_russian.Text) + Convert.ToUInt32(textBox_math.Text) + Convert.ToUInt32(textBox_social_science.Text) +
                    Convert.ToUInt32(textBox_physic.Text) + Convert.ToUInt32(textBox_history.Text) + Convert.ToUInt32(textBox_computer_science.Text) + Convert.ToUInt32(textBox_biology.Text) + Convert.ToUInt32(textBox_chemistry.Text) +
                    Convert.ToUInt32(textBox_geography.Text) + Convert.ToUInt32(textBox_literature.Text) + Convert.ToUInt32(textBox_foreign_language.Text);
                    if(exam_sum > 300)
                    {
                        MessageBox.Show($"Сумма баллов не должна превышать значение 300\nВведённая сумма {exam_sum}", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    obj_edit_db.set_exam_info(id, Convert.ToUInt32(textBox_russian.Text), Convert.ToUInt32(textBox_math.Text), Convert.ToUInt32(textBox_social_science.Text),
                    Convert.ToUInt32(textBox_physic.Text), Convert.ToUInt32(textBox_history.Text), Convert.ToUInt32(textBox_computer_science.Text), Convert.ToUInt32(textBox_biology.Text), Convert.ToUInt32(textBox_chemistry.Text),
                   Convert.ToUInt32(textBox_geography.Text), Convert.ToUInt32(textBox_literature.Text), Convert.ToUInt32(textBox_foreign_language.Text));
                    obj_edit_db.set_exam_info_pd(id, exam_sum);
                    label_sum.Text = exam_sum.ToString();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_add_applicant_facultie_Click(object sender, EventArgs e)
        {
            if (obj_edit_db.applicant_exists_facultie(id, comboBox_facultie.Text))
            {
                MessageBox.Show("Заявление на имя абитуриента на данную специальность уже подана", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                obj_edit_db.add_applicant_to_facultie(id, comboBox_facultie.Text);
                MessageBox.Show("Успешно", "Специальность", MessageBoxButtons.OK, MessageBoxIcon.Information);
                code_facultie_applicant = obj_edit_db.get_current_facultie_applicant(id);
                block_textBox_exams();
                
            }
        }

        private void button_delete_applicant_facultie_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (code_facultie_applicant == "")
                {
                    return;
                }
                
                obj_edit_db.delete_applicant_to_facultie(id, code_facultie_applicant);
                code_facultie_applicant = obj_edit_db.get_current_facultie_applicant(id);

                textBox_russian.ReadOnly = true;
                textBox_math.ReadOnly = true;
                textBox_social_science.ReadOnly = true;
                textBox_physic.ReadOnly = true;
                textBox_history.ReadOnly = true;
                textBox_computer_science.ReadOnly = true;
                textBox_biology.ReadOnly = true;
                textBox_chemistry.ReadOnly = true;
                textBox_geography.ReadOnly = true;
                textBox_literature.ReadOnly = true;
                textBox_foreign_language.ReadOnly = true;
            }
        }

        private void button_edit_fio_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Вы уверены?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
            {
                obj_edit_db.edit_fio(id, textBox_surname.Text, textBox_name.Text, textBox_patronymic.Text);
            }
            
        }
    }
}
