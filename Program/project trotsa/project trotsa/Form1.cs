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

namespace project_trotsa
{
    public partial class Form1 : Form
    {
        server_data Server_Data;
        registar registar;
        DB db_obj;



        void fill_server_page()
        {
            server_EditLine.Text = Server_Data.server;
            port_EditLine.Text = Server_Data.port;
            username_EditLine.Text = Server_Data.username;
            password_EditLine.Text = Server_Data.password;
            DB_EditLine.Text = Server_Data.database;

            save_server_data.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();

            files_work.check_safe();
            Server_Data = files_work.read_server_data_file();
            fill_server_page();
            db_obj = new DB(Server_Data);
            db_obj.open_conn();
            if(db_obj.get_bool_conn())
            {
                db_obj.close_conn();
            }
            else 
            {
                do
                {
                    db_obj.open_conn();
                    if( db_obj.get_bool_conn())
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

            db_obj.open_conn();

            if(db_obj.get_bool_conn())
            {
                MessageBox.Show("Соединение: успешно", "DB");
                db_obj.close_conn();
            }
            else
            {
                MessageBox.Show("Соединение: провалено", "DB");
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
    }
}
