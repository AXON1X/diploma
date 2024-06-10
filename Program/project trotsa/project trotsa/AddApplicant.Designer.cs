namespace project_trotsa
{
    partial class AddApplicant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_surname_edit = new System.Windows.Forms.TextBox();
            this.textBox_name_edit = new System.Windows.Forms.TextBox();
            this.textBox_patronymic_edit = new System.Windows.Forms.TextBox();
            this.button_add_applicant = new System.Windows.Forms.Button();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_patronymic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_surname_edit
            // 
            this.textBox_surname_edit.Location = new System.Drawing.Point(12, 36);
            this.textBox_surname_edit.Name = "textBox_surname_edit";
            this.textBox_surname_edit.Size = new System.Drawing.Size(275, 22);
            this.textBox_surname_edit.TabIndex = 0;
            // 
            // textBox_name_edit
            // 
            this.textBox_name_edit.Location = new System.Drawing.Point(12, 83);
            this.textBox_name_edit.Name = "textBox_name_edit";
            this.textBox_name_edit.Size = new System.Drawing.Size(275, 22);
            this.textBox_name_edit.TabIndex = 1;
            // 
            // textBox_patronymic_edit
            // 
            this.textBox_patronymic_edit.Location = new System.Drawing.Point(12, 131);
            this.textBox_patronymic_edit.Name = "textBox_patronymic_edit";
            this.textBox_patronymic_edit.Size = new System.Drawing.Size(275, 22);
            this.textBox_patronymic_edit.TabIndex = 2;
            // 
            // button_add_applicant
            // 
            this.button_add_applicant.Location = new System.Drawing.Point(72, 159);
            this.button_add_applicant.Name = "button_add_applicant";
            this.button_add_applicant.Size = new System.Drawing.Size(162, 54);
            this.button_add_applicant.TabIndex = 3;
            this.button_add_applicant.Text = "Создать";
            this.button_add_applicant.UseVisualStyleBackColor = true;
            this.button_add_applicant.Click += new System.EventHandler(this.button_add_applicant_Click);
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(12, 13);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(66, 16);
            this.label_surname.TabIndex = 4;
            this.label_surname.Text = "Фамилия";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 64);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(33, 16);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Имя";
            // 
            // label_patronymic
            // 
            this.label_patronymic.AutoSize = true;
            this.label_patronymic.Location = new System.Drawing.Point(12, 112);
            this.label_patronymic.Name = "label_patronymic";
            this.label_patronymic.Size = new System.Drawing.Size(70, 16);
            this.label_patronymic.TabIndex = 6;
            this.label_patronymic.Text = "Отчество";
            // 
            // AddApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 228);
            this.Controls.Add(this.label_patronymic);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.button_add_applicant);
            this.Controls.Add(this.textBox_patronymic_edit);
            this.Controls.Add(this.textBox_name_edit);
            this.Controls.Add(this.textBox_surname_edit);
            this.Name = "AddApplicant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddApplicant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_surname_edit;
        private System.Windows.Forms.TextBox textBox_name_edit;
        private System.Windows.Forms.TextBox textBox_patronymic_edit;
        private System.Windows.Forms.Button button_add_applicant;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_patronymic;
    }
}