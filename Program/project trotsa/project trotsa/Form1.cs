using project_trotsa.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_trotsa.server;
using Mysqlx.Expect;
using System.Diagnostics.Eventing.Reader;

namespace project_trotsa
{
    public partial class Form1 : Form
    {
        server_data Server_Data;
        registar registar;
        DB db_obj;
        int authorization_err_count = 0;


        void fill_server_page()
        {
            server_EditLine.Text = Server_Data.server;
            port_EditLine.Text = Server_Data.port;
            username_EditLine.Text = Server_Data.username;
            password_EditLine.Text = Server_Data.password;
            DB_EditLine.Text = Server_Data.database;

            save_server_data.Visible = false;
        }
        void fill_authorization_panel()
        {
            login_EditLine_MF.Text = registar.login;
            pass_EditLine_MF.Text = registar.password;
        }
        void bunning(int counter)
        {
            if(counter < 3)
            {
                return;
            }
            files_work.clear_registar_data_file();
            login_EditLine_MF.Text = "";
            pass_EditLine_MF.Text = "";
            switch (counter) 
            {
                case 3:
                registar.bun_date = DateTime.Now.AddMinutes(1);
                    break;
                case 5:
                    registar.bun_date = DateTime.Now.AddMinutes(5);
                    break;
                case 10:
                    registar.bun_date = DateTime.Now.AddMinutes(15);
                    break;
                case 15:
                    registar.bun_date = DateTime.Now.AddMinutes(30);
                    break;
            }
            if(counter > 15)
            {
                registar.bun_date = DateTime.Now.AddHours(1);
            }
            registar.login = "";
            registar.password = "";
            files_work.save_registar_data(registar);
        }
        public Form1()
        {
            InitializeComponent();

            files_work.check_safe();
            Server_Data = files_work.read_server_data_file();
            registar = files_work.read_registar_data_file();
            fill_server_page();
            fill_authorization_panel();
            if (Server_Data.all_value_filled())
            {
                db_obj = new DB(Server_Data);
                db_obj.open_conn();
                if (db_obj.get_bool_conn())
                {
                    db_obj.close_conn();
                }
                else
                {
                    do
                    {
                        db_obj.open_conn();
                        if (db_obj.get_bool_conn())
                        {
                            break;
                        }
                    } while (DialogResult.Retry == MessageBox.Show("Не удалось подключится к базе данных\nПовторить попытку?", "DB", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error));
                    if (!db_obj.get_bool_conn())
                    {
                        tabControl1.SelectedIndex = 1;
                        OptionsTabPage.SelectedIndex = 1;
                        MessageBox.Show("Возможно в данных присутствует ошибка или нет подключения к серверу\nобратитесь к вашему системному администратору", "DB", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }

                OptionsTabPage.DrawItem += new DrawItemEventHandler(OptionsTabPage_DrawItem);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
                OptionsTabPage.SelectedIndex = 1;
            }
        }
        

        private void OptionsTabPage_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = OptionsTabPage.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = OptionsTabPage.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            save_server_data.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            save_server_data.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            save_server_data.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            save_server_data.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            save_server_data.Visible = true;
        }

        private void save_server_data_Click(object sender, EventArgs e)
        {
            Server_Data.server = server_EditLine.Text;
            Server_Data.port = port_EditLine.Text;
            Server_Data.username = username_EditLine.Text;
            Server_Data.password = password_EditLine.Text;
            Server_Data.database = DB_EditLine.Text;

            save_server_data.Visible = false;

            files_work.save_server_data(Server_Data);
            db_obj.reset_str_conn(Server_Data);

            if(DialogResult.OK == MessageBox.Show("Необходима перезагрузка приложения", "UI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                
                Application.Restart();
            }
        }

        private void check_conn_button_Click(object sender, EventArgs e)
        {
            
            db_obj.open_conn();

            if (db_obj.get_bool_conn())
            {
                MessageBox.Show("Соединение: успешно", "DB");
                db_obj.close_conn();
            }
            else
            {
                MessageBox.Show("Соединение: провалено", "DB");
            }
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            errorProvider_MF.Clear();
            if (registar.bun_date > DateTime.Now)
            {
                if(authorization_err_count != 0)
                {
                    MessageBox.Show($"Неудачных попыток авторизации: {authorization_err_count}\nПовторная попытка может быть совершена {registar.bun_date}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Было совершено много неудачных попыток авторизации\nПовторная попытка может быть совершена {registar.bun_date}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            if (login_EditLine_MF.Text == "")
            {
                errorProvider_MF.SetError(login_EditLine_MF, "Введите логин");
                return;
            }
            if(pass_EditLine_MF.Text == "")
            {
                errorProvider_MF.SetError(pass_EditLine_MF, "Введите пароль");
                return;
            }
            if (!db_obj.search_login(login_EditLine_MF.Text))
            {
                errorProvider_MF.SetError(login_EditLine_MF, "Такого логина не существует");
            }
            if(db_obj.authorization(login_EditLine_MF.Text, pass_EditLine_MF.Text))
            {
                if(!check_save_registar.Checked)
                {
                    files_work.clear_registar_data_file();
                    login_EditLine_MF.Text = "";
                    pass_EditLine_MF.Text = "";
                }
                else
                {
                    registar.login = login_EditLine_MF.Text;
                    registar.password = pass_EditLine_MF.Text;
                    files_work.save_registar_data(registar);
                }
                
                this.Hide();
                registrator_form registrator_Form = new registrator_form();
                registrator_Form.Show();
            }
            else
            {
                errorProvider_MF.SetError(pass_EditLine_MF, "Неверный пароль");
                authorization_err_count++;
            }
            bunning(authorization_err_count);
        }

        private void link_authorizathion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }
    }
}
