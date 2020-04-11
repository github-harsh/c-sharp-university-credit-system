using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PVGCreditSystem
{
    public partial class Course : Form
    {
        System.Data.SqlClient.SqlConnection sqlConnection1 =
               new System.Data.SqlClient.SqlConnection(
                   @"Data Source=(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename='C:\Users\HARSH\Documents\Visual Studio 2015\Projects\PVGCreditSystem\PVGCreditSystem\credit_evaluation_db.mdf';
                    Integrated Security=True;
                    Connect Timeout=30"
               );

        

        public Course() 
        {
            InitializeComponent();
            try {
                sqlConnection1.Open();
            }
            catch (SqlException)
            {

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Course_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            SubjectComboBox.Hide();
            StudentComboBox.Hide();
            TeacherNameLabel.Hide();

            Hide_Eval_And_Insert_Marks_And_Update_Marks_Code();

            try
            {
                //sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection1;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select course_name from Course";

                SqlDataReader reader = cmd.ExecuteReader();
            
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CourseComboBox.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
                //sqlConnection1.Close();           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.credit_evaluation_dbDataSet.Course);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

 
        private void TeacherNameLabel_Click(object sender, EventArgs e)
        {

        }


        public void Hide_Eval_And_Insert_Marks_And_Update_Marks_Code()
        {
            Eval_1_Label.Hide();
            Eval_1_txtbox.Hide();
            Eval_2_Label.Hide();
            Eval_2_txtbox.Hide();
            Eval_3_Label.Hide();
            Eval_3_txtbox.Hide();
            Insert_eval_mode.Hide();
            Enter_Eval_Modes_Label.Hide();

            Enter_Student_Marks_Label.Hide();
            Eval_1_Marks_Label.Hide();
            Eval_1_Marks_txtbox.Hide();
            Eval_2_Marks_Label.Hide();
            Eval_2_Marks_txtbox.Hide();
            Eval_3_Marks_Label.Hide();
            Eval_3_Marks_txtbox.Hide();
            Insert_Eval_Marks_Button.Hide();

            Marks_Info_Label.Hide();
            Total_Score_label.Hide();

            Marks_Outof_50.Hide();

            Update_Eval_Marks_Button.Hide();
        }

        //Replaced Method
        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SubjectComboBox.Show();
            TeacherNameLabel.Hide();
            dataGridView1.Hide();
            StudentComboBox.Items.Clear();
            SubjectComboBox.Items.Clear();
            Hide_Eval_And_Insert_Marks_And_Update_Marks_Code();
 
            try
            {
                SubjectLabel.Text = "Select Subject for " + CourseComboBox.SelectedItem;
                int selected_course_id = CourseComboBox.SelectedIndex + 1;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection1;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT subject_name from Subject where course_id =@c_id";
                cmd.Parameters.AddWithValue("@c_id", selected_course_id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SubjectComboBox.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
                //sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


 

 





        private void Insert_eval_mode_Click(object sender, EventArgs e)
        {
            try
            {
                if (Eval_1_txtbox.Text == "" || Eval_2_txtbox.Text == "" || Eval_3_txtbox.Text == "")
                {
                    MessageBox.Show("Please insert 3 modes of Evaluation");
                }

                else
                {
                    //sqlConnection1.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection1;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into Evaluation (subject_id, eval_mode_1,eval_mode_2,eval_mode_3) values((SELECT subject_id from Subject where subject_name = @subject_n), @eval_1, @eval_2, @eval_3)";
                    cmd.Parameters.AddWithValue("@subject_n", SubjectComboBox.Text);
                    cmd.Parameters.AddWithValue("@eval_1", Eval_1_txtbox.Text);
                    cmd.Parameters.AddWithValue("@eval_2", Eval_2_txtbox.Text);
                    cmd.Parameters.AddWithValue("@eval_3", Eval_3_txtbox.Text);

                    SqlDataReader eval_reader = cmd.ExecuteReader();
                    eval_reader.Close();

                    Eval_1_Label.Hide();
                    Eval_1_txtbox.Hide();
                    Eval_2_Label.Hide();
                    Eval_2_txtbox.Hide();
                    Eval_3_Label.Hide();
                    Eval_3_txtbox.Hide();
                    Insert_eval_mode.Hide();

                    // Displaying Textboxes and Labels for inserting marks of students
                    Display_Textboxes_And_Labels_For_Inserting_Marks();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Eval_1_txtbox.Clear();
            Eval_2_txtbox.Clear();
            Eval_3_txtbox.Clear();
        }







        // Replaced Method
        private void SubjectComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            StudentComboBox.Show();
            StudentComboBox.Items.Clear();
            Hide_Eval_And_Insert_Marks_And_Update_Marks_Code();
            dataGridView1.Rows.Clear();

            try
            {
                //sqlConnection1.Open();
                Data_Grid_View_Initialization();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection1;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT teacher_name from Teacher where teacher_id = (Select teacher_id from Subject where subject_name = @sub_name)";
                cmd.Parameters.AddWithValue("@sub_name", SubjectComboBox.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TeacherNameLabel.Text = "Welcome Mrs. " + reader.GetString(0);
                }
                TeacherNameLabel.Show();
                reader.Close();

                cmd.CommandText = "Select student_name from Student where course_id = (SELECT course_id from Subject where subject_name = @s_name)";
                cmd.Parameters.AddWithValue("@s_name", SubjectComboBox.SelectedItem);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StudentComboBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                //sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void StudentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Enter_Eval_Modes_Label.Show();
            Total_Score_label.Hide();
            Marks_Outof_50.Hide();
            Insert_Eval_Marks_Button.Show();
            Update_Eval_Marks_Button.Hide();


            string commandText1 = "SELECT eval_mode_1,eval_mode_2,eval_mode_3 FROM Evaluation WHERE subject_id = (SELECT subject_id FROM Subject where subject_name = @s1_name)";

            try
            {
                //sqlConnection1.Open();
                using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@s1_name", SubjectComboBox.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // If the evaluation modes already are entered in the database.
                    if (reader.HasRows)
                    {
                        reader.Close();
                        if ( Check_If_Marks_Already_Exist()  )
                        {
                            Display_And_Update_Student_Marks( StudentComboBox.SelectedItem.ToString() );
                        }
                        else
                        {
                            // Displaying Textboxes and Labels for inserting Student marks and Labels
                            Display_Textboxes_And_Labels_For_Inserting_Marks();
                        }
                    }

                    // If the evaluation modes are not yet entered in the database.
                    // Creation of Evaluation modes.
                    else
                    {
                        reader.Close();
                        Enter_Modes_Of_Evaluation();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        // Function to insert Evaluation modes for a subject
        public void Enter_Modes_Of_Evaluation()
        {
            Enter_Eval_Modes_Label.Show();
            Enter_Eval_Modes_Label.Text = "Enter 3 modes of evaluation for this Subject";

            Eval_1_Label.Show();
            Eval_1_txtbox.Show();
            Eval_2_Label.Show();
            Eval_2_txtbox.Show();
            Eval_3_Label.Show();
            Eval_3_txtbox.Show();
            Insert_eval_mode.Show();
            Insert_Eval_Marks_Button.Hide();
        }



        public Boolean Check_If_Marks_Already_Exist()
        {
            string commandText2 = "SELECT * from Evaluation_Marks where student_id = (SELECT student_id from Student where student_name = @stud_name) AND subject_id = (SELECT subject_id from Subject where subject_name = @subj_name)";

            try
            {
                //sqlConnection1.Open();
                using (SqlCommand cmd = new SqlCommand(commandText2, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@stud_name", StudentComboBox.SelectedItem);

                    cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // If the marks of the student already exist in the database
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }

                    // If the marks of the student do not exist in the database
                    else
                    {
                        reader.Close();
                        return false;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        // Method for displaying the marks of students already entered in the database.
        public void Display_And_Update_Student_Marks(string stud_name)
        {
            Eval_1_Marks_Label.Show();
            Eval_1_Marks_txtbox.Show();
            Eval_2_Marks_Label.Show();
            Eval_2_Marks_txtbox.Show();
            Eval_3_Marks_Label.Show();
            Eval_3_Marks_txtbox.Show();
            Marks_Info_Label.Show();
            Enter_Eval_Modes_Label.Hide();
            Enter_Student_Marks_Label.Show();
            Update_Eval_Marks_Button.Show();
            Insert_Eval_Marks_Button.Hide();
            Total_Score_label.Show();
            Marks_Outof_50.Show();


            Enter_Student_Marks_Label.Text = "Update marks of : " + stud_name;

            Get_Evaluation_Modes_For_Labels();

            string commandText1 = "SELECT eval_1_marks, eval_2_marks, eval_3_marks, final_marks from Evaluation_Marks where student_id  = (SELECT student_id from Student where student_name = @stud_name) and subject_id = (SELECT subject_id from Subject where subject_name = @subj_name)";


            try
            {
                using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@stud_name", stud_name);
                    cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.SelectedItem);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Eval_1_Marks_txtbox.Text = reader.GetInt32(0).ToString();

                        Eval_2_Marks_txtbox.Text = reader.GetInt32(1).ToString();

                        Eval_3_Marks_txtbox.Text = reader.GetInt32(2).ToString();

                        Marks_Outof_50.Text = reader.GetInt32(3).ToString() + " / 50";
                    }
                    reader.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        // Method for displaying Textboxes and Labels for inserting marks of student.
        // Called from private void StudentComboBox_SelectedValueChange() , private void Insert_eval_mode_Click() and , Display_And_Update_Student_Marks().
        public void Display_Textboxes_And_Labels_For_Inserting_Marks()
        {
            Eval_1_Marks_Label.Show();
            Eval_1_Marks_txtbox.Show();
            Eval_2_Marks_Label.Show();
            Eval_2_Marks_txtbox.Show();
            Eval_3_Marks_Label.Show();
            Eval_3_Marks_txtbox.Show();
            Insert_eval_mode.Hide();
            Insert_Eval_Marks_Button.Show();
            Marks_Info_Label.Show();
            Enter_Eval_Modes_Label.Hide();
            Enter_Student_Marks_Label.Show();

            Enter_Student_Marks_Label.Text = "Enter Marks of : " + StudentComboBox.SelectedItem;

            Get_Evaluation_Modes_For_Labels();
        }



        // Getting evaluation modes from Database and apply to the labels 
        public void Get_Evaluation_Modes_For_Labels()
        {
            string commandText1 = "SELECT * from Evaluation where subject_id = (SELECT subject_id FROM Subject where subject_name = @s2_name)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@s2_name", SubjectComboBox.SelectedItem);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Eval_1_Marks_Label.Text = "Marks for " + reader.GetString(1) + " :";
                        Eval_2_Marks_Label.Text = "Marks for " + reader.GetString(2) + " :";
                        Eval_3_Marks_Label.Text = "Marks for " + reader.GetString(3) + " :";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Eval_1_Marks_txtbox.Clear();
            Eval_2_Marks_txtbox.Clear();
            Eval_3_Marks_txtbox.Clear();
        }



        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
