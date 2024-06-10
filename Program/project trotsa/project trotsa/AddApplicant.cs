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
    public partial class AddApplicant : Form
    {
        DB obj_addApplicants_db;
        public AddApplicant()
        {
            InitializeComponent();
            obj_addApplicants_db = new DB(files_work.read_server_data_file());
        }

        private void button_add_applicant_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Вы точно хотите добавить абитуриента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    obj_addApplicants_db.add_applicant(textBox_surname_edit.Text, textBox_name_edit.Text, textBox_patronymic_edit.Text);
                    MessageBox.Show("Абитуриент добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
        }
    }
}
