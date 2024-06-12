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
    public partial class administratorForm : Form
    {
        Form previous;
        DB obj_adm_db;
        int count = 0;
        public administratorForm(Form OldForm)
        {
            InitializeComponent();
            previous = OldForm;
            obj_adm_db = new DB(files_work.read_server_data_file());
            update_form();
        }

        private void administratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previous.Show();
        }

        private void button_add_facultie_Click(object sender, EventArgs e)
        {
            facultie facultie = new facultie();
            facultie.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            facultie.ShowDialog();
        }

        private void button_edit_facultie_Click(object sender, EventArgs e)
        {
            facultie facultie = new facultie(comboBox_faculties.Text);
            facultie.FormClosed += new FormClosedEventHandler(facultie_FormClosed);
            facultie.ShowDialog();
        }
        void facultie_FormClosed(object sender, FormClosedEventArgs e) 
        {
            comboBox_faculties.DataSource = null;
            comboBox_faculties.DataSource = obj_adm_db.load_all_faculties_adm();
        }

        void update_form()
        {
            DataTable dt = new DataTable();
            dt.Columns.Clear();
            dt.Clear();
            comboBox_faculties.DataSource = obj_adm_db.load_all_faculties_adm();
            dt = obj_adm_db.get_exam_requirements(comboBox_faculties.Text);
            russian.Checked = Convert.ToBoolean(dt.Rows[0][0]);
            math.Checked = Convert.ToBoolean(dt.Rows[0][1]);
            social_science.Checked = Convert.ToBoolean(dt.Rows[0][2]);
            physic.Checked = Convert.ToBoolean(dt.Rows[0][3]);
            history.Checked = Convert.ToBoolean(dt.Rows[0][4]);
            computer_science.Checked = Convert.ToBoolean(dt.Rows[0][5]);
            biology.Checked = Convert.ToBoolean(dt.Rows[0][6]);
            chemistry.Checked = Convert.ToBoolean(dt.Rows[0][7]);
            geography.Checked = Convert.ToBoolean(dt.Rows[0][8]);
            literature.Checked = Convert.ToBoolean(dt.Rows[0][9]);
            foreign_language.Checked = Convert.ToBoolean(dt.Rows[0][10]);
            count = 0;
        }

        int counting()
        {
            count = 0;
            if (russian.Checked) { count++; }
            if (math.Checked) { count++; }
            if (social_science.Checked) { count++; }
            if (physic.Checked) { count++; }
            if (history.Checked) { count++; }
            if (computer_science.Checked) { count++; }
            if (biology.Checked) { count++; }
            if (chemistry.Checked) { count++; }
            if (geography.Checked) { count++; }
            if (literature.Checked) { count++; }
            if (foreign_language.Checked) { count++; }
            return count;
        }

        private void comboBox_faculties_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Clear();
            dt.Clear();
            try
            {
                dt = obj_adm_db.get_exam_requirements(comboBox_faculties.Text);
                russian.Checked = Convert.ToBoolean(dt.Rows[0][0]);
                math.Checked = Convert.ToBoolean(dt.Rows[0][1]);
                social_science.Checked = Convert.ToBoolean(dt.Rows[0][2]);
                physic.Checked = Convert.ToBoolean(dt.Rows[0][3]);
                history.Checked = Convert.ToBoolean(dt.Rows[0][4]);
                computer_science.Checked = Convert.ToBoolean(dt.Rows[0][5]);
                biology.Checked = Convert.ToBoolean(dt.Rows[0][6]);
                chemistry.Checked = Convert.ToBoolean(dt.Rows[0][7]);
                geography.Checked = Convert.ToBoolean(dt.Rows[0][8]);
                literature.Checked = Convert.ToBoolean(dt.Rows[0][9]);
                foreign_language.Checked = Convert.ToBoolean(dt.Rows[0][10]);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            count = 0;

        }

        private void math_CheckedChanged(object sender, EventArgs e)
        {
            if(math.Checked)
            {
                if(counting() == 5)
                {
                    math.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if(counting() > 4)
            {
                MessageBox.Show("Нельзя выбрать больше 4 дисциплин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (counting() <= 4)
            {
                obj_adm_db.update_requirements_exam(comboBox_faculties.Text, russian.Checked, math.Checked, social_science.Checked,
                    physic.Checked, history.Checked, computer_science.Checked, biology.Checked, chemistry.Checked, geography.Checked, literature.Checked, foreign_language.Checked);
                MessageBox.Show("Изменения внесены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(counting() == 0)
            {
                MessageBox.Show("Ничего не выбрано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void biology_CheckedChanged(object sender, EventArgs e)
        {
            if (biology.Checked)
            {
                if (counting() == 5)
                {
                    biology.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void physic_CheckedChanged(object sender, EventArgs e)
        {
            if (physic.Checked)
            {
                if (counting() == 5)
                {
                    physic.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void russian_CheckedChanged(object sender, EventArgs e)
        {
            if (russian.Checked)
            {
                if (counting() == 5)
                {
                    russian.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void geography_CheckedChanged(object sender, EventArgs e)
        {
            if (geography.Checked)
            {
                if (counting() == 5)
                {
                    geography.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void social_science_CheckedChanged(object sender, EventArgs e)
        {
            if (social_science.Checked)
            {
                if (counting() == 5)
                {
                    social_science.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void chemistry_CheckedChanged(object sender, EventArgs e)
        {
            if (chemistry.Checked)
            {
                if (counting() == 5)
                {
                    chemistry.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void history_CheckedChanged(object sender, EventArgs e)
        {
            if (history.Checked)
            {
                if (counting() == 5)
                {
                    history.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void literature_CheckedChanged(object sender, EventArgs e)
        {
            if (literature.Checked)
            {
                if (counting() == 5)
                {
                    literature.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void computer_science_CheckedChanged(object sender, EventArgs e)
        {
            if (computer_science.Checked)
            {
                if (counting() == 5)
                {
                    computer_science.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }

        private void foreign_language_CheckedChanged(object sender, EventArgs e)
        {
            if (foreign_language.Checked)
            {
                if (counting() == 5)
                {
                    foreign_language.Checked = false;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count--;
            }
        }
    }
}
