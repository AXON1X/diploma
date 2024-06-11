namespace project_trotsa
{
    partial class administratorForm
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
            this.button_edit_facultie = new System.Windows.Forms.Button();
            this.label_facultie = new System.Windows.Forms.Label();
            this.button_add_facultie = new System.Windows.Forms.Button();
            this.comboBox_faculties = new System.Windows.Forms.ComboBox();
            this.russian = new System.Windows.Forms.CheckBox();
            this.math = new System.Windows.Forms.CheckBox();
            this.social_science = new System.Windows.Forms.CheckBox();
            this.computer_science = new System.Windows.Forms.CheckBox();
            this.history = new System.Windows.Forms.CheckBox();
            this.physic = new System.Windows.Forms.CheckBox();
            this.geography = new System.Windows.Forms.CheckBox();
            this.chemistry = new System.Windows.Forms.CheckBox();
            this.biology = new System.Windows.Forms.CheckBox();
            this.foreign_language = new System.Windows.Forms.CheckBox();
            this.literature = new System.Windows.Forms.CheckBox();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_edit_facultie
            // 
            this.button_edit_facultie.Location = new System.Drawing.Point(170, 25);
            this.button_edit_facultie.Name = "button_edit_facultie";
            this.button_edit_facultie.Size = new System.Drawing.Size(35, 24);
            this.button_edit_facultie.TabIndex = 14;
            this.button_edit_facultie.Text = "...";
            this.button_edit_facultie.UseVisualStyleBackColor = true;
            this.button_edit_facultie.Click += new System.EventHandler(this.button_edit_facultie_Click);
            // 
            // label_facultie
            // 
            this.label_facultie.AutoSize = true;
            this.label_facultie.Location = new System.Drawing.Point(9, 7);
            this.label_facultie.Name = "label_facultie";
            this.label_facultie.Size = new System.Drawing.Size(78, 16);
            this.label_facultie.TabIndex = 13;
            this.label_facultie.Text = "факультет";
            // 
            // button_add_facultie
            // 
            this.button_add_facultie.Location = new System.Drawing.Point(140, 26);
            this.button_add_facultie.Name = "button_add_facultie";
            this.button_add_facultie.Size = new System.Drawing.Size(24, 24);
            this.button_add_facultie.TabIndex = 12;
            this.button_add_facultie.Text = "+";
            this.button_add_facultie.UseVisualStyleBackColor = true;
            this.button_add_facultie.Click += new System.EventHandler(this.button_add_facultie_Click);
            // 
            // comboBox_faculties
            // 
            this.comboBox_faculties.FormattingEnabled = true;
            this.comboBox_faculties.Location = new System.Drawing.Point(12, 26);
            this.comboBox_faculties.Name = "comboBox_faculties";
            this.comboBox_faculties.Size = new System.Drawing.Size(121, 24);
            this.comboBox_faculties.TabIndex = 11;
            this.comboBox_faculties.TextChanged += new System.EventHandler(this.comboBox_faculties_TextChanged);
            // 
            // russian
            // 
            this.russian.AutoSize = true;
            this.russian.Location = new System.Drawing.Point(152, 71);
            this.russian.Name = "russian";
            this.russian.Size = new System.Drawing.Size(82, 20);
            this.russian.TabIndex = 15;
            this.russian.Text = "русский";
            this.russian.UseVisualStyleBackColor = true;
            this.russian.CheckedChanged += new System.EventHandler(this.russian_CheckedChanged);
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Location = new System.Drawing.Point(12, 71);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(108, 20);
            this.math.TabIndex = 16;
            this.math.Text = "математика";
            this.math.UseVisualStyleBackColor = true;
            this.math.CheckedChanged += new System.EventHandler(this.math_CheckedChanged);
            // 
            // social_science
            // 
            this.social_science.AutoSize = true;
            this.social_science.Location = new System.Drawing.Point(257, 123);
            this.social_science.Name = "social_science";
            this.social_science.Size = new System.Drawing.Size(92, 20);
            this.social_science.TabIndex = 17;
            this.social_science.Text = "общество";
            this.social_science.UseVisualStyleBackColor = true;
            this.social_science.CheckedChanged += new System.EventHandler(this.social_science_CheckedChanged);
            // 
            // computer_science
            // 
            this.computer_science.AutoSize = true;
            this.computer_science.Location = new System.Drawing.Point(12, 97);
            this.computer_science.Name = "computer_science";
            this.computer_science.Size = new System.Drawing.Size(119, 20);
            this.computer_science.TabIndex = 20;
            this.computer_science.Text = "информатика";
            this.computer_science.UseVisualStyleBackColor = true;
            this.computer_science.CheckedChanged += new System.EventHandler(this.computer_science_CheckedChanged);
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(257, 71);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(82, 20);
            this.history.TabIndex = 19;
            this.history.Text = "история";
            this.history.UseVisualStyleBackColor = true;
            this.history.CheckedChanged += new System.EventHandler(this.history_CheckedChanged);
            // 
            // physic
            // 
            this.physic.AutoSize = true;
            this.physic.Location = new System.Drawing.Point(152, 97);
            this.physic.Name = "physic";
            this.physic.Size = new System.Drawing.Size(79, 20);
            this.physic.TabIndex = 18;
            this.physic.Text = "физика";
            this.physic.UseVisualStyleBackColor = true;
            this.physic.CheckedChanged += new System.EventHandler(this.physic_CheckedChanged);
            // 
            // geography
            // 
            this.geography.AutoSize = true;
            this.geography.Location = new System.Drawing.Point(152, 149);
            this.geography.Name = "geography";
            this.geography.Size = new System.Drawing.Size(99, 20);
            this.geography.TabIndex = 23;
            this.geography.Text = "география";
            this.geography.UseVisualStyleBackColor = true;
            this.geography.CheckedChanged += new System.EventHandler(this.geography_CheckedChanged);
            // 
            // chemistry
            // 
            this.chemistry.AutoSize = true;
            this.chemistry.Location = new System.Drawing.Point(257, 97);
            this.chemistry.Name = "chemistry";
            this.chemistry.Size = new System.Drawing.Size(67, 20);
            this.chemistry.TabIndex = 22;
            this.chemistry.Text = "химия";
            this.chemistry.UseVisualStyleBackColor = true;
            this.chemistry.CheckedChanged += new System.EventHandler(this.chemistry_CheckedChanged);
            // 
            // biology
            // 
            this.biology.AutoSize = true;
            this.biology.Location = new System.Drawing.Point(152, 123);
            this.biology.Name = "biology";
            this.biology.Size = new System.Drawing.Size(90, 20);
            this.biology.TabIndex = 21;
            this.biology.Text = "биология";
            this.biology.UseVisualStyleBackColor = true;
            this.biology.CheckedChanged += new System.EventHandler(this.biology_CheckedChanged);
            // 
            // foreign_language
            // 
            this.foreign_language.AutoSize = true;
            this.foreign_language.Location = new System.Drawing.Point(12, 123);
            this.foreign_language.Name = "foreign_language";
            this.foreign_language.Size = new System.Drawing.Size(118, 20);
            this.foreign_language.TabIndex = 25;
            this.foreign_language.Text = "Иностранный";
            this.foreign_language.UseVisualStyleBackColor = true;
            this.foreign_language.CheckedChanged += new System.EventHandler(this.foreign_language_CheckedChanged);
            // 
            // literature
            // 
            this.literature.AutoSize = true;
            this.literature.Location = new System.Drawing.Point(12, 149);
            this.literature.Name = "literature";
            this.literature.Size = new System.Drawing.Size(107, 20);
            this.literature.TabIndex = 24;
            this.literature.Text = "литература";
            this.literature.UseVisualStyleBackColor = true;
            this.literature.CheckedChanged += new System.EventHandler(this.literature_CheckedChanged);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(98, 186);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(147, 44);
            this.button_change.TabIndex = 26;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // administratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 242);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.foreign_language);
            this.Controls.Add(this.literature);
            this.Controls.Add(this.geography);
            this.Controls.Add(this.chemistry);
            this.Controls.Add(this.biology);
            this.Controls.Add(this.computer_science);
            this.Controls.Add(this.history);
            this.Controls.Add(this.physic);
            this.Controls.Add(this.social_science);
            this.Controls.Add(this.math);
            this.Controls.Add(this.russian);
            this.Controls.Add(this.button_edit_facultie);
            this.Controls.Add(this.label_facultie);
            this.Controls.Add(this.button_add_facultie);
            this.Controls.Add(this.comboBox_faculties);
            this.Name = "administratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administratorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administratorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_edit_facultie;
        private System.Windows.Forms.Label label_facultie;
        private System.Windows.Forms.Button button_add_facultie;
        private System.Windows.Forms.ComboBox comboBox_faculties;
        private System.Windows.Forms.CheckBox russian;
        private System.Windows.Forms.CheckBox math;
        private System.Windows.Forms.CheckBox social_science;
        private System.Windows.Forms.CheckBox computer_science;
        private System.Windows.Forms.CheckBox history;
        private System.Windows.Forms.CheckBox physic;
        private System.Windows.Forms.CheckBox geography;
        private System.Windows.Forms.CheckBox chemistry;
        private System.Windows.Forms.CheckBox biology;
        private System.Windows.Forms.CheckBox foreign_language;
        private System.Windows.Forms.CheckBox literature;
        private System.Windows.Forms.Button button_change;
    }
}