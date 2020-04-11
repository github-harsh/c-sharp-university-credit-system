namespace PVGCreditSystem
{
    partial class Course
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
            this.components = new System.ComponentModel.Container();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.Eval_1_Label = new System.Windows.Forms.Label();
            this.Eval_2_Label = new System.Windows.Forms.Label();
            this.Eval_3_Label = new System.Windows.Forms.Label();
            this.Eval_1_txtbox = new System.Windows.Forms.TextBox();
            this.Eval_2_txtbox = new System.Windows.Forms.TextBox();
            this.Eval_3_txtbox = new System.Windows.Forms.TextBox();
            this.Insert_eval_mode = new System.Windows.Forms.Button();
            this.Eval_1_Marks_Label = new System.Windows.Forms.Label();
            this.Eval_2_Marks_Label = new System.Windows.Forms.Label();
            this.Eval_3_Marks_Label = new System.Windows.Forms.Label();
            this.Insert_Eval_Marks_Button = new System.Windows.Forms.Button();
            this.Eval_1_Marks_txtbox = new System.Windows.Forms.TextBox();
            this.Eval_2_Marks_txtbox = new System.Windows.Forms.TextBox();
            this.Eval_3_Marks_txtbox = new System.Windows.Forms.TextBox();
            this.Marks_Info_Label = new System.Windows.Forms.Label();
            this.Total_Score_label = new System.Windows.Forms.Label();
            this.Marks_Outof_50 = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.Enter_Eval_Modes_Label = new System.Windows.Forms.Label();
            this.Enter_Student_Marks_Label = new System.Windows.Forms.Label();
            this.Update_Eval_Marks_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Application_Title_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.Location = new System.Drawing.Point(241, 200);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(131, 24);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Select Course";
            this.CourseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(245, 242);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(266, 32);
            this.CourseComboBox.TabIndex = 3;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(245, 351);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(407, 32);
            this.SubjectComboBox.TabIndex = 4;
            this.SubjectComboBox.SelectedValueChanged += new System.EventHandler(this.SubjectComboBox_SelectedValueChanged);
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherNameLabel.Location = new System.Drawing.Point(241, 147);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(64, 24);
            this.TeacherNameLabel.TabIndex = 5;
            this.TeacherNameLabel.Text = "label2";
            this.TeacherNameLabel.Click += new System.EventHandler(this.TeacherNameLabel_Click);
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(245, 460);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(407, 32);
            this.StudentComboBox.TabIndex = 7;
            this.StudentComboBox.SelectedValueChanged += new System.EventHandler(this.StudentComboBox_SelectedValueChanged);
            // 
            // Eval_1_Label
            // 
            this.Eval_1_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_1_Label.Location = new System.Drawing.Point(242, 620);
            this.Eval_1_Label.Name = "Eval_1_Label";
            this.Eval_1_Label.Size = new System.Drawing.Size(187, 24);
            this.Eval_1_Label.TabIndex = 9;
            this.Eval_1_Label.Text = "Evaluation Mode 1 :sdkfdklsjfldkfjsldkj";
            this.Eval_1_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Eval_2_Label
            // 
            this.Eval_2_Label.AutoSize = true;
            this.Eval_2_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_2_Label.Location = new System.Drawing.Point(242, 677);
            this.Eval_2_Label.Name = "Eval_2_Label";
            this.Eval_2_Label.Size = new System.Drawing.Size(187, 24);
            this.Eval_2_Label.TabIndex = 10;
            this.Eval_2_Label.Text = "Evaluation Mode 2 :";
            // 
            // Eval_3_Label
            // 
            this.Eval_3_Label.AutoSize = true;
            this.Eval_3_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_3_Label.Location = new System.Drawing.Point(242, 733);
            this.Eval_3_Label.Name = "Eval_3_Label";
            this.Eval_3_Label.Size = new System.Drawing.Size(187, 24);
            this.Eval_3_Label.TabIndex = 11;
            this.Eval_3_Label.Text = "Evaluation Mode 3 :";
            // 
            // Eval_1_txtbox
            // 
            this.Eval_1_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_1_txtbox.Location = new System.Drawing.Point(478, 616);
            this.Eval_1_txtbox.Name = "Eval_1_txtbox";
            this.Eval_1_txtbox.Size = new System.Drawing.Size(367, 32);
            this.Eval_1_txtbox.TabIndex = 12;
            // 
            // Eval_2_txtbox
            // 
            this.Eval_2_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_2_txtbox.Location = new System.Drawing.Point(478, 674);
            this.Eval_2_txtbox.Name = "Eval_2_txtbox";
            this.Eval_2_txtbox.Size = new System.Drawing.Size(367, 32);
            this.Eval_2_txtbox.TabIndex = 13;
            // 
            // Eval_3_txtbox
            // 
            this.Eval_3_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_3_txtbox.Location = new System.Drawing.Point(478, 730);
            this.Eval_3_txtbox.Name = "Eval_3_txtbox";
            this.Eval_3_txtbox.Size = new System.Drawing.Size(367, 32);
            this.Eval_3_txtbox.TabIndex = 14;
            // 
            // Insert_eval_mode
            // 
            this.Insert_eval_mode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_eval_mode.Location = new System.Drawing.Point(245, 790);
            this.Insert_eval_mode.Name = "Insert_eval_mode";
            this.Insert_eval_mode.Size = new System.Drawing.Size(128, 46);
            this.Insert_eval_mode.TabIndex = 15;
            this.Insert_eval_mode.Text = "Insert";
            this.Insert_eval_mode.UseVisualStyleBackColor = true;
            this.Insert_eval_mode.Click += new System.EventHandler(this.Insert_eval_mode_Click);
            // 
            // Eval_1_Marks_Label
            // 
            this.Eval_1_Marks_Label.AutoSize = true;
            this.Eval_1_Marks_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_1_Marks_Label.Location = new System.Drawing.Point(242, 620);
            this.Eval_1_Marks_Label.Name = "Eval_1_Marks_Label";
            this.Eval_1_Marks_Label.Size = new System.Drawing.Size(0, 24);
            this.Eval_1_Marks_Label.TabIndex = 16;
            this.Eval_1_Marks_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Eval_2_Marks_Label
            // 
            this.Eval_2_Marks_Label.AutoSize = true;
            this.Eval_2_Marks_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_2_Marks_Label.Location = new System.Drawing.Point(242, 677);
            this.Eval_2_Marks_Label.Name = "Eval_2_Marks_Label";
            this.Eval_2_Marks_Label.Size = new System.Drawing.Size(0, 24);
            this.Eval_2_Marks_Label.TabIndex = 17;
            this.Eval_2_Marks_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Eval_3_Marks_Label
            // 
            this.Eval_3_Marks_Label.AutoSize = true;
            this.Eval_3_Marks_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_3_Marks_Label.Location = new System.Drawing.Point(242, 733);
            this.Eval_3_Marks_Label.Name = "Eval_3_Marks_Label";
            this.Eval_3_Marks_Label.Size = new System.Drawing.Size(0, 24);
            this.Eval_3_Marks_Label.TabIndex = 18;
            // 
            // Insert_Eval_Marks_Button
            // 
            this.Insert_Eval_Marks_Button.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Eval_Marks_Button.Location = new System.Drawing.Point(246, 790);
            this.Insert_Eval_Marks_Button.Name = "Insert_Eval_Marks_Button";
            this.Insert_Eval_Marks_Button.Size = new System.Drawing.Size(128, 46);
            this.Insert_Eval_Marks_Button.TabIndex = 19;
            this.Insert_Eval_Marks_Button.Text = "Insert";
            this.Insert_Eval_Marks_Button.UseVisualStyleBackColor = true;
            this.Insert_Eval_Marks_Button.Click += new System.EventHandler(this.Insert_Eval_Marks_Click);
            // 
            // Eval_1_Marks_txtbox
            // 
            this.Eval_1_Marks_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_1_Marks_txtbox.Location = new System.Drawing.Point(552, 616);
            this.Eval_1_Marks_txtbox.Name = "Eval_1_Marks_txtbox";
            this.Eval_1_Marks_txtbox.Size = new System.Drawing.Size(100, 32);
            this.Eval_1_Marks_txtbox.TabIndex = 20;
            this.Eval_1_Marks_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eval_1_Marks_txtbox_KeyPress);
            this.Eval_1_Marks_txtbox.Leave += new System.EventHandler(this.Eval_1_Marks_txtbox_Leave);
            // 
            // Eval_2_Marks_txtbox
            // 
            this.Eval_2_Marks_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_2_Marks_txtbox.Location = new System.Drawing.Point(552, 674);
            this.Eval_2_Marks_txtbox.Name = "Eval_2_Marks_txtbox";
            this.Eval_2_Marks_txtbox.Size = new System.Drawing.Size(100, 32);
            this.Eval_2_Marks_txtbox.TabIndex = 21;
            this.Eval_2_Marks_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eval_2_Marks_txtbox_KeyPress);
            this.Eval_2_Marks_txtbox.Leave += new System.EventHandler(this.Eval_2_Marks_txtbox_Leave);
            // 
            // Eval_3_Marks_txtbox
            // 
            this.Eval_3_Marks_txtbox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eval_3_Marks_txtbox.Location = new System.Drawing.Point(552, 730);
            this.Eval_3_Marks_txtbox.Name = "Eval_3_Marks_txtbox";
            this.Eval_3_Marks_txtbox.Size = new System.Drawing.Size(100, 32);
            this.Eval_3_Marks_txtbox.TabIndex = 22;
            this.Eval_3_Marks_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eval_3_Marks_txtbox_KeyPress);
            this.Eval_3_Marks_txtbox.Leave += new System.EventHandler(this.Eval_3_Marks_txtbox_Leave);
            // 
            // Marks_Info_Label
            // 
            this.Marks_Info_Label.AutoSize = true;
            this.Marks_Info_Label.Location = new System.Drawing.Point(242, 569);
            this.Marks_Info_Label.Name = "Marks_Info_Label";
            this.Marks_Info_Label.Size = new System.Drawing.Size(264, 20);
            this.Marks_Info_Label.TabIndex = 23;
            this.Marks_Info_Label.Text = "*Enter marks between 0 and 25 only";
            // 
            // Total_Score_label
            // 
            this.Total_Score_label.AutoSize = true;
            this.Total_Score_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Score_label.Location = new System.Drawing.Point(242, 790);
            this.Total_Score_label.Name = "Total_Score_label";
            this.Total_Score_label.Size = new System.Drawing.Size(111, 24);
            this.Total_Score_label.TabIndex = 24;
            this.Total_Score_label.Text = "Total Score";
            this.Total_Score_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Marks_Outof_50
            // 
            this.Marks_Outof_50.Enabled = false;
            this.Marks_Outof_50.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_Outof_50.Location = new System.Drawing.Point(552, 787);
            this.Marks_Outof_50.Name = "Marks_Outof_50";
            this.Marks_Outof_50.Size = new System.Drawing.Size(100, 32);
            this.Marks_Outof_50.TabIndex = 25;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(241, 311);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(136, 24);
            this.SubjectLabel.TabIndex = 26;
            this.SubjectLabel.Text = "Select Subject";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(241, 422);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(139, 24);
            this.StudentLabel.TabIndex = 27;
            this.StudentLabel.Text = "Select Student";
            // 
            // Enter_Eval_Modes_Label
            // 
            this.Enter_Eval_Modes_Label.AutoSize = true;
            this.Enter_Eval_Modes_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Eval_Modes_Label.Location = new System.Drawing.Point(242, 545);
            this.Enter_Eval_Modes_Label.Name = "Enter_Eval_Modes_Label";
            this.Enter_Eval_Modes_Label.Size = new System.Drawing.Size(64, 24);
            this.Enter_Eval_Modes_Label.TabIndex = 28;
            this.Enter_Eval_Modes_Label.Text = "label1";
            // 
            // Enter_Student_Marks_Label
            // 
            this.Enter_Student_Marks_Label.AutoSize = true;
            this.Enter_Student_Marks_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Student_Marks_Label.Location = new System.Drawing.Point(241, 545);
            this.Enter_Student_Marks_Label.Name = "Enter_Student_Marks_Label";
            this.Enter_Student_Marks_Label.Size = new System.Drawing.Size(64, 24);
            this.Enter_Student_Marks_Label.TabIndex = 29;
            this.Enter_Student_Marks_Label.Text = "label1";
            // 
            // Update_Eval_Marks_Button
            // 
            this.Update_Eval_Marks_Button.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Eval_Marks_Button.Location = new System.Drawing.Point(246, 856);
            this.Update_Eval_Marks_Button.Name = "Update_Eval_Marks_Button";
            this.Update_Eval_Marks_Button.Size = new System.Drawing.Size(128, 44);
            this.Update_Eval_Marks_Button.TabIndex = 30;
            this.Update_Eval_Marks_Button.Text = "Update";
            this.Update_Eval_Marks_Button.UseVisualStyleBackColor = true;
            this.Update_Eval_Marks_Button.Click += new System.EventHandler(this.Update_Eval_Marks_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dataGridView1.Location = new System.Drawing.Point(882, 258);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(942, 448);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Application_Title_Label
            // 
            this.Application_Title_Label.AutoSize = true;
            this.Application_Title_Label.Font = new System.Drawing.Font("HP Simplified", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Application_Title_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Application_Title_Label.Location = new System.Drawing.Point(718, 45);
            this.Application_Title_Label.Name = "Application_Title_Label";
            this.Application_Title_Label.Size = new System.Drawing.Size(597, 74);
            this.Application_Title_Label.TabIndex = 32;
            this.Application_Title_Label.Text = "PVG CREDIT EVALUATION";
            this.Application_Title_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1795, 929);
            this.Controls.Add(this.Application_Title_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update_Eval_Marks_Button);
            this.Controls.Add(this.Enter_Student_Marks_Label);
            this.Controls.Add(this.Enter_Eval_Modes_Label);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.Marks_Outof_50);
            this.Controls.Add(this.Total_Score_label);
            this.Controls.Add(this.Marks_Info_Label);
            this.Controls.Add(this.Eval_3_Marks_txtbox);
            this.Controls.Add(this.Eval_2_Marks_txtbox);
            this.Controls.Add(this.Eval_1_Marks_txtbox);
            this.Controls.Add(this.Insert_Eval_Marks_Button);
            this.Controls.Add(this.Eval_3_Marks_Label);
            this.Controls.Add(this.Eval_2_Marks_Label);
            this.Controls.Add(this.Eval_1_Marks_Label);
            this.Controls.Add(this.Insert_eval_mode);
            this.Controls.Add(this.Eval_3_txtbox);
            this.Controls.Add(this.Eval_2_txtbox);
            this.Controls.Add(this.Eval_1_txtbox);
            this.Controls.Add(this.Eval_3_Label);
            this.Controls.Add(this.Eval_2_Label);
            this.Controls.Add(this.Eval_1_Label);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.TeacherNameLabel);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.CourseLabel);
            this.Name = "Course";
            this.Text = "PVG Credit Evaluation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLabel;
        private credit_evaluation_dbDataSet credit_evaluation_dbDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private credit_evaluation_dbDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.BindingSource creditevaluationdbDataSetBindingSource;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.Label TeacherNameLabel;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Label Eval_1_Label;
        private System.Windows.Forms.Label Eval_2_Label;
        private System.Windows.Forms.Label Eval_3_Label;
        private System.Windows.Forms.TextBox Eval_1_txtbox;
        private System.Windows.Forms.TextBox Eval_2_txtbox;
        private System.Windows.Forms.TextBox Eval_3_txtbox;
        private System.Windows.Forms.Button Insert_eval_mode;
        private System.Windows.Forms.Label Eval_1_Marks_Label;
        private System.Windows.Forms.Label Eval_2_Marks_Label;
        private System.Windows.Forms.Label Eval_3_Marks_Label;
        private System.Windows.Forms.Button Insert_Eval_Marks_Button;
        private System.Windows.Forms.TextBox Eval_1_Marks_txtbox;
        private System.Windows.Forms.TextBox Eval_2_Marks_txtbox;
        private System.Windows.Forms.TextBox Eval_3_Marks_txtbox;
        private System.Windows.Forms.Label Marks_Info_Label;
        private System.Windows.Forms.Label Total_Score_label;
        private System.Windows.Forms.TextBox Marks_Outof_50;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label Enter_Eval_Modes_Label;
        private System.Windows.Forms.Label Enter_Student_Marks_Label;
        private System.Windows.Forms.Button Update_Eval_Marks_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Application_Title_Label;
    }
}

