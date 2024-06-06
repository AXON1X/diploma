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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Applicants)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Applicants
            // 
            this.DGV_Applicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Applicants.Location = new System.Drawing.Point(12, 42);
            this.DGV_Applicants.Name = "DGV_Applicants";
            this.DGV_Applicants.RowHeadersWidth = 51;
            this.DGV_Applicants.RowTemplate.Height = 24;
            this.DGV_Applicants.Size = new System.Drawing.Size(424, 362);
            this.DGV_Applicants.TabIndex = 0;
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
            // registrator_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Counter);
            this.Controls.Add(this.button_ten_next);
            this.Controls.Add(this.button_to_start_list);
            this.Controls.Add(this.button_ten_previous);
            this.Controls.Add(this.label_counter_dgv);
            this.Controls.Add(this.DGV_Applicants);
            this.Name = "registrator_form";
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
    }
}