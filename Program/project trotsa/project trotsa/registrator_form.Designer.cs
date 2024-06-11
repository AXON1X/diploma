namespace project_trotsa
{
    partial class registrator_form
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
            this.DGV_Applicants = new System.Windows.Forms.DataGridView();
            this.label_counter_dgv = new System.Windows.Forms.Label();
            this.button_ten_previous = new System.Windows.Forms.Button();
            this.button_to_start_list = new System.Windows.Forms.Button();
            this.button_ten_next = new System.Windows.Forms.Button();
            this.comboBox_Counter = new System.Windows.Forms.ComboBox();
            this.comboBox_faculties = new System.Windows.Forms.ComboBox();
            this.label_facultie = new System.Windows.Forms.Label();
            this.button_delete_applicants = new System.Windows.Forms.Button();
            this.button_create_applicant = new System.Windows.Forms.Button();
            this.button_change_data = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_clear_search = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Applicants)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Applicants
            // 
            this.DGV_Applicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Applicants.Location = new System.Drawing.Point(12, 42);
            this.DGV_Applicants.Name = "DGV_Applicants";
            this.DGV_Applicants.ReadOnly = true;
            this.DGV_Applicants.RowHeadersVisible = false;
            this.DGV_Applicants.RowHeadersWidth = 51;
            this.DGV_Applicants.RowTemplate.Height = 24;
            this.DGV_Applicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Applicants.Size = new System.Drawing.Size(424, 362);
            this.DGV_Applicants.TabIndex = 0;
            this.DGV_Applicants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Applicants_CellDoubleClick);
            // 
            // label_counter_dgv
            // 
            this.label_counter_dgv.AutoSize = true;
            this.label_counter_dgv.Location = new System.Drawing.Point(12, 23);
            this.label_counter_dgv.Name = "label_counter_dgv";
            this.label_counter_dgv.Size = new System.Drawing.Size(43, 16);
            this.label_counter_dgv.TabIndex = 1;
            this.label_counter_dgv.Text = "1—10: ";
            // 
            // button_ten_previous
            // 
            this.button_ten_previous.Location = new System.Drawing.Point(93, 415);
            this.button_ten_previous.Name = "button_ten_previous";
            this.button_ten_previous.Size = new System.Drawing.Size(75, 23);
            this.button_ten_previous.TabIndex = 2;
            this.button_ten_previous.Text = "←";
            this.button_ten_previous.UseVisualStyleBackColor = true;
            this.button_ten_previous.Click += new System.EventHandler(this.button_ten_previous_Click);
            // 
            // button_to_start_list
            // 
            this.button_to_start_list.Location = new System.Drawing.Point(12, 415);
            this.button_to_start_list.Name = "button_to_start_list";
            this.button_to_start_list.Size = new System.Drawing.Size(75, 23);
            this.button_to_start_list.TabIndex = 3;
            this.button_to_start_list.Text = "<<";
            this.button_to_start_list.UseVisualStyleBackColor = true;
            this.button_to_start_list.Click += new System.EventHandler(this.button_to_start_list_Click);
            // 
            // button_ten_next
            // 
            this.button_ten_next.Location = new System.Drawing.Point(174, 415);
            this.button_ten_next.Name = "button_ten_next";
            this.button_ten_next.Size = new System.Drawing.Size(75, 23);
            this.button_ten_next.TabIndex = 5;
            this.button_ten_next.Text = "→";
            this.button_ten_next.UseVisualStyleBackColor = true;
            this.button_ten_next.Click += new System.EventHandler(this.button_ten_next_Click);
            // 
            // comboBox_Counter
            // 
            this.comboBox_Counter.FormattingEnabled = true;
            this.comboBox_Counter.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100"});
            this.comboBox_Counter.Location = new System.Drawing.Point(256, 415);
            this.comboBox_Counter.Name = "comboBox_Counter";
            this.comboBox_Counter.Size = new System.Drawing.Size(68, 24);
            this.comboBox_Counter.TabIndex = 6;
            this.comboBox_Counter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Counter_SelectedIndexChanged);
            // 
            // comboBox_faculties
            // 
            this.comboBox_faculties.FormattingEnabled = true;
            this.comboBox_faculties.Location = new System.Drawing.Point(441, 141);
            this.comboBox_faculties.Name = "comboBox_faculties";
            this.comboBox_faculties.Size = new System.Drawing.Size(192, 24);
            this.comboBox_faculties.TabIndex = 7;
            this.comboBox_faculties.SelectedValueChanged += new System.EventHandler(this.comboBox_faculties_SelectedValueChanged);
            // 
            // label_facultie
            // 
            this.label_facultie.AutoSize = true;
            this.label_facultie.Location = new System.Drawing.Point(438, 122);
            this.label_facultie.Name = "label_facultie";
            this.label_facultie.Size = new System.Drawing.Size(78, 16);
            this.label_facultie.TabIndex = 9;
            this.label_facultie.Text = "факультет";
            // 
            // button_delete_applicants
            // 
            this.button_delete_applicants.Location = new System.Drawing.Point(442, 348);
            this.button_delete_applicants.Name = "button_delete_applicants";
            this.button_delete_applicants.Size = new System.Drawing.Size(192, 56);
            this.button_delete_applicants.TabIndex = 11;
            this.button_delete_applicants.Text = "удалить";
            this.button_delete_applicants.UseVisualStyleBackColor = true;
            this.button_delete_applicants.Click += new System.EventHandler(this.button_delete_applicants_Click);
            // 
            // button_create_applicant
            // 
            this.button_create_applicant.Location = new System.Drawing.Point(442, 171);
            this.button_create_applicant.Name = "button_create_applicant";
            this.button_create_applicant.Size = new System.Drawing.Size(192, 56);
            this.button_create_applicant.TabIndex = 12;
            this.button_create_applicant.Text = "Добавить";
            this.button_create_applicant.UseVisualStyleBackColor = true;
            this.button_create_applicant.Click += new System.EventHandler(this.button_create_applicant_Click);
            // 
            // button_change_data
            // 
            this.button_change_data.Location = new System.Drawing.Point(441, 233);
            this.button_change_data.Name = "button_change_data";
            this.button_change_data.Size = new System.Drawing.Size(192, 56);
            this.button_change_data.TabIndex = 13;
            this.button_change_data.Text = "Изменить";
            this.button_change_data.UseVisualStyleBackColor = true;
            this.button_change_data.Click += new System.EventHandler(this.button_change_data_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(443, 38);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(191, 22);
            this.textBox_search.TabIndex = 14;
            // 
            // button_clear_search
            // 
            this.button_clear_search.Location = new System.Drawing.Point(443, 67);
            this.button_clear_search.Name = "button_clear_search";
            this.button_clear_search.Size = new System.Drawing.Size(75, 23);
            this.button_clear_search.TabIndex = 15;
            this.button_clear_search.Text = "стереть";
            this.button_clear_search.UseVisualStyleBackColor = true;
            this.button_clear_search.Click += new System.EventHandler(this.button_to_start_list_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(560, 67);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // registrator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_clear_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_change_data);
            this.Controls.Add(this.button_create_applicant);
            this.Controls.Add(this.button_delete_applicants);
            this.Controls.Add(this.label_facultie);
            this.Controls.Add(this.comboBox_faculties);
            this.Controls.Add(this.comboBox_Counter);
            this.Controls.Add(this.button_ten_next);
            this.Controls.Add(this.button_to_start_list);
            this.Controls.Add(this.button_ten_previous);
            this.Controls.Add(this.label_counter_dgv);
            this.Controls.Add(this.DGV_Applicants);
            this.Name = "registrator_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrator_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registrator_form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Applicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Applicants;
        private System.Windows.Forms.Label label_counter_dgv;
        private System.Windows.Forms.Button button_ten_previous;
        private System.Windows.Forms.Button button_to_start_list;
        private System.Windows.Forms.Button button_ten_next;
        private System.Windows.Forms.ComboBox comboBox_Counter;
        private System.Windows.Forms.ComboBox comboBox_faculties;
        private System.Windows.Forms.Label label_facultie;
        private System.Windows.Forms.Button button_delete_applicants;
        private System.Windows.Forms.Button button_create_applicant;
        private System.Windows.Forms.Button button_change_data;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_clear_search;
        private System.Windows.Forms.Button button_search;
    }
}