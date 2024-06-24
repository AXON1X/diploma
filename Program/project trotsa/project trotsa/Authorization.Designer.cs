namespace project_trotsa
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.check_save_registar = new System.Windows.Forms.CheckBox();
            this.button_authorization = new System.Windows.Forms.Button();
            this.pass_EditLine_MF = new System.Windows.Forms.TextBox();
            this.login_EditLine_MF = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OptionsTabPage = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.DB_EditLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_EditLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_EditLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port_EditLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.server_EditLine = new System.Windows.Forms.TextBox();
            this.save_server_data = new System.Windows.Forms.Button();
            this.check_conn_button = new System.Windows.Forms.Button();
            this.errorProvider_MF = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.OptionsTabPage.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MF)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(973, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label_pass);
            this.panel1.Controls.Add(this.label_login);
            this.panel1.Controls.Add(this.check_save_registar);
            this.panel1.Controls.Add(this.button_authorization);
            this.panel1.Controls.Add(this.pass_EditLine_MF);
            this.panel1.Controls.Add(this.login_EditLine_MF);
            this.panel1.Location = new System.Drawing.Point(377, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 284);
            this.panel1.TabIndex = 1;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(29, 96);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(56, 16);
            this.label_pass.TabIndex = 7;
            this.label_pass.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(29, 33);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(46, 16);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Логин";
            // 
            // check_save_registar
            // 
            this.check_save_registar.AutoSize = true;
            this.check_save_registar.Location = new System.Drawing.Point(51, 219);
            this.check_save_registar.Name = "check_save_registar";
            this.check_save_registar.Size = new System.Drawing.Size(98, 20);
            this.check_save_registar.TabIndex = 5;
            this.check_save_registar.Text = "Сохранить";
            this.check_save_registar.UseVisualStyleBackColor = true;
            // 
            // button_authorization
            // 
            this.button_authorization.Location = new System.Drawing.Point(29, 164);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(138, 49);
            this.button_authorization.TabIndex = 4;
            this.button_authorization.Text = "Авторизация";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // pass_EditLine_MF
            // 
            this.pass_EditLine_MF.Location = new System.Drawing.Point(29, 115);
            this.pass_EditLine_MF.MaxLength = 10;
            this.pass_EditLine_MF.Name = "pass_EditLine_MF";
            this.pass_EditLine_MF.PasswordChar = '*';
            this.pass_EditLine_MF.ShortcutsEnabled = false;
            this.pass_EditLine_MF.Size = new System.Drawing.Size(138, 22);
            this.pass_EditLine_MF.TabIndex = 3;
            // 
            // login_EditLine_MF
            // 
            this.login_EditLine_MF.Location = new System.Drawing.Point(29, 55);
            this.login_EditLine_MF.MaxLength = 15;
            this.login_EditLine_MF.Name = "login_EditLine_MF";
            this.login_EditLine_MF.ShortcutsEnabled = false;
            this.login_EditLine_MF.Size = new System.Drawing.Size(138, 22);
            this.login_EditLine_MF.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OptionsTabPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(973, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OptionsTabPage
            // 
            this.OptionsTabPage.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.OptionsTabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsTabPage.Controls.Add(this.tabPage4);
            this.OptionsTabPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.OptionsTabPage.ItemSize = new System.Drawing.Size(30, 150);
            this.OptionsTabPage.Location = new System.Drawing.Point(5, 6);
            this.OptionsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsTabPage.Multiline = true;
            this.OptionsTabPage.Name = "OptionsTabPage";
            this.OptionsTabPage.SelectedIndex = 0;
            this.OptionsTabPage.Size = new System.Drawing.Size(961, 622);
            this.OptionsTabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.OptionsTabPage.TabIndex = 0;
            this.OptionsTabPage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OptionsTabPage_DrawItem);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.DB_EditLine);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.password_EditLine);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.username_EditLine);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.port_EditLine);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.server_EditLine);
            this.tabPage4.Controls.Add(this.save_server_data);
            this.tabPage4.Controls.Add(this.check_conn_button);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(803, 614);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Сервер";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "База Данных";
            // 
            // DB_EditLine
            // 
            this.DB_EditLine.Location = new System.Drawing.Point(5, 278);
            this.DB_EditLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DB_EditLine.Name = "DB_EditLine";
            this.DB_EditLine.Size = new System.Drawing.Size(164, 22);
            this.DB_EditLine.TabIndex = 5;
            this.DB_EditLine.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль";
            // 
            // password_EditLine
            // 
            this.password_EditLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_EditLine.Location = new System.Drawing.Point(5, 210);
            this.password_EditLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_EditLine.Name = "password_EditLine";
            this.password_EditLine.PasswordChar = '•';
            this.password_EditLine.ShortcutsEnabled = false;
            this.password_EditLine.Size = new System.Drawing.Size(164, 26);
            this.password_EditLine.TabIndex = 4;
            this.password_EditLine.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя Пользователя";
            // 
            // username_EditLine
            // 
            this.username_EditLine.Location = new System.Drawing.Point(5, 146);
            this.username_EditLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_EditLine.Name = "username_EditLine";
            this.username_EditLine.Size = new System.Drawing.Size(164, 22);
            this.username_EditLine.TabIndex = 3;
            this.username_EditLine.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Порт";
            // 
            // port_EditLine
            // 
            this.port_EditLine.Location = new System.Drawing.Point(5, 85);
            this.port_EditLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_EditLine.Name = "port_EditLine";
            this.port_EditLine.Size = new System.Drawing.Size(164, 22);
            this.port_EditLine.TabIndex = 2;
            this.port_EditLine.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сервер";
            // 
            // server_EditLine
            // 
            this.server_EditLine.Location = new System.Drawing.Point(5, 34);
            this.server_EditLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.server_EditLine.Name = "server_EditLine";
            this.server_EditLine.Size = new System.Drawing.Size(164, 22);
            this.server_EditLine.TabIndex = 1;
            this.server_EditLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // save_server_data
            // 
            this.save_server_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_server_data.Location = new System.Drawing.Point(5, 319);
            this.save_server_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_server_data.MaximumSize = new System.Drawing.Size(164, 52);
            this.save_server_data.Name = "save_server_data";
            this.save_server_data.Size = new System.Drawing.Size(164, 52);
            this.save_server_data.TabIndex = 6;
            this.save_server_data.Text = "Сохранить";
            this.save_server_data.UseVisualStyleBackColor = true;
            this.save_server_data.Visible = false;
            this.save_server_data.Click += new System.EventHandler(this.save_server_data_Click);
            // 
            // check_conn_button
            // 
            this.check_conn_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_conn_button.Location = new System.Drawing.Point(572, 7);
            this.check_conn_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_conn_button.MaximumSize = new System.Drawing.Size(173, 76);
            this.check_conn_button.Name = "check_conn_button";
            this.check_conn_button.Size = new System.Drawing.Size(173, 76);
            this.check_conn_button.TabIndex = 0;
            this.check_conn_button.Text = "Проверить соединение";
            this.check_conn_button.UseVisualStyleBackColor = true;
            this.check_conn_button.Click += new System.EventHandler(this.check_conn_button_Click);
            // 
            // errorProvider_MF
            // 
            this.errorProvider_MF.ContainerControl = this;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 687);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.OptionsTabPage.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl OptionsTabPage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox server_EditLine;
        private System.Windows.Forms.Button save_server_data;
        private System.Windows.Forms.Button check_conn_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DB_EditLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_EditLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_EditLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_EditLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.CheckBox check_save_registar;
        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.TextBox pass_EditLine_MF;
        private System.Windows.Forms.TextBox login_EditLine_MF;
        private System.Windows.Forms.ErrorProvider errorProvider_MF;
    }
}

