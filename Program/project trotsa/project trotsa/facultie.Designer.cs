namespace project_trotsa
{
    partial class facultie
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
            this.label_facultie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_code_facultie = new System.Windows.Forms.TextBox();
            this.textBox_name_facultie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_short_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_delete_facultie = new System.Windows.Forms.Button();
            this.button_add_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_facultie
            // 
            this.label_facultie.AutoSize = true;
            this.label_facultie.Location = new System.Drawing.Point(13, 13);
            this.label_facultie.Name = "label_facultie";
            this.label_facultie.Size = new System.Drawing.Size(109, 16);
            this.label_facultie.TabIndex = 0;
            this.label_facultie.Text = "специальность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код";
            // 
            // textBox_code_facultie
            // 
            this.textBox_code_facultie.Location = new System.Drawing.Point(125, 46);
            this.textBox_code_facultie.Name = "textBox_code_facultie";
            this.textBox_code_facultie.Size = new System.Drawing.Size(155, 22);
            this.textBox_code_facultie.TabIndex = 4;
            this.textBox_code_facultie.TabStop = false;
            // 
            // textBox_name_facultie
            // 
            this.textBox_name_facultie.Location = new System.Drawing.Point(125, 77);
            this.textBox_name_facultie.Name = "textBox_name_facultie";
            this.textBox_name_facultie.Size = new System.Drawing.Size(155, 22);
            this.textBox_name_facultie.TabIndex = 5;
            this.textBox_name_facultie.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование";
            // 
            // textBox_short_name
            // 
            this.textBox_short_name.Location = new System.Drawing.Point(125, 105);
            this.textBox_short_name.Name = "textBox_short_name";
            this.textBox_short_name.Size = new System.Drawing.Size(155, 22);
            this.textBox_short_name.TabIndex = 6;
            this.textBox_short_name.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Короткое имя";
            // 
            // button_delete_facultie
            // 
            this.button_delete_facultie.Location = new System.Drawing.Point(16, 133);
            this.button_delete_facultie.Name = "button_delete_facultie";
            this.button_delete_facultie.Size = new System.Drawing.Size(119, 62);
            this.button_delete_facultie.TabIndex = 7;
            this.button_delete_facultie.Text = "удалить";
            this.button_delete_facultie.UseVisualStyleBackColor = true;
            this.button_delete_facultie.Click += new System.EventHandler(this.button_delete_facultie_Click);
            // 
            // button_add_change
            // 
            this.button_add_change.Location = new System.Drawing.Point(161, 133);
            this.button_add_change.Name = "button_add_change";
            this.button_add_change.Size = new System.Drawing.Size(119, 62);
            this.button_add_change.TabIndex = 8;
            this.button_add_change.Text = "добавить";
            this.button_add_change.UseVisualStyleBackColor = true;
            this.button_add_change.Click += new System.EventHandler(this.button_add_change_Click);
            // 
            // facultie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 203);
            this.Controls.Add(this.button_add_change);
            this.Controls.Add(this.button_delete_facultie);
            this.Controls.Add(this.textBox_short_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name_facultie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_code_facultie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_facultie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "facultie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "специальность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_facultie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_code_facultie;
        private System.Windows.Forms.TextBox textBox_name_facultie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_short_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_delete_facultie;
        private System.Windows.Forms.Button button_add_change;
    }
}