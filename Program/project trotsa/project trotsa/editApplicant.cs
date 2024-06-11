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
        string id_applicant = "", id;
        DB obj_edit_db = new DB(files_work.read_server_data_file());
        DataTable dt = new DataTable();
        uint exam_sum = 0; 
        public editApplicant(string set_id)
        {
            InitializeComponent();
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
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                obj_edit_db.set_dop_info(id, checkBox_Disability.Checked, checkBox_Privileges.Checked, checkBox_Orphan.Checked, textBox_doc_com.Text, textBox_dop_com.Text);
            }
            
        }

        private void button_set_exams_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    obj_edit_db.set_exam_info(id, Convert.ToUInt32(textBox_russian.Text), Convert.ToUInt32(textBox_math.Text), Convert.ToUInt32(textBox_social_science.Text),
                    Convert.ToUInt32(textBox_physic.Text), Convert.ToUInt32(textBox_history.Text), Convert.ToUInt32(textBox_computer_science.Text), Convert.ToUInt32(textBox_biology.Text), Convert.ToUInt32(textBox_chemistry.Text),
                   Convert.ToUInt32(textBox_geography.Text), Convert.ToUInt32(textBox_literature.Text), Convert.ToUInt32(textBox_foreign_language.Text));
                    
                    exam_sum = Convert.ToUInt32(textBox_russian.Text) + Convert.ToUInt32(textBox_math.Text) + Convert.ToUInt32(textBox_social_science.Text) +
                    Convert.ToUInt32(textBox_physic.Text) + Convert.ToUInt32(textBox_history.Text) + Convert.ToUInt32(textBox_computer_science.Text) + Convert.ToUInt32(textBox_biology.Text) + Convert.ToUInt32(textBox_chemistry.Text) +
                    Convert.ToUInt32(textBox_geography.Text) + Convert.ToUInt32(textBox_literature.Text) + Convert.ToUInt32(textBox_foreign_language.Text);

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
            }
        }

        private void button_delete_applicant_facultie_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                obj_edit_db.delete_applicant_to_facultie(id, comboBox_facultie.Text);
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
