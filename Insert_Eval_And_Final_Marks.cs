using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PVGCreditSystem
{
    // Class to save the evaluation mode marks in Evaluation table.
    // Calculate final marks and save in Student_Subject table.
    public partial class Course : Form
    {
        // For inserting the marks of student in the database 
        // Tables updated : Evaluation , Student_Subject
        private void Insert_Eval_Marks_Click(object sender, EventArgs e)
        {
            int subject_id = 0, student_id = 0;

            Insert_Eval_Marks_Button.Hide();
            Total_Score_label.Show();
            int final_marks = Calculate_Best_Of_Three_Marks();
            Marks_Outof_50.Show();
            Marks_Outof_50.Text = final_marks + " / 50";

            
            // If all marks are not inserted in all textboxes.
            if (Eval_1_Marks_txtbox.Text == "" || Eval_2_Marks_txtbox.Text == "" || Eval_3_Marks_txtbox.Text == "")
            {
                MessageBox.Show("Enter Marks of all 3 Subjects");
            }



            // If all marks are inserted in all textboxes.
            else
            {
                string commandText1 = "SELECT subject_id from Subject where subject_name = @subj_name";
                string commandText2 = "SELECT student_id from Student where student_name = @stud_name";
                string commandText3 = "INSERT into Evaluation_Marks (subject_id, student_id, eval_1_marks, eval_2_marks, eval_3_marks, final_marks) values (@subj_id , @stud_id, @eval_1_marks, @eval_2_marks, @eval_3_marks, @final_marks)";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                    {
                        cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.SelectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            subject_id = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    using (SqlCommand cmd2 = new SqlCommand(commandText2, sqlConnection1))
                    {
                        cmd2.Parameters.AddWithValue("@stud_name", StudentComboBox.SelectedItem);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            student_id = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    using (SqlCommand cmd3 = new SqlCommand(commandText3, sqlConnection1))
                    {
                        cmd3.Parameters.AddWithValue("@subj_id", subject_id);
                        cmd3.Parameters.AddWithValue("@stud_id", student_id);
                        cmd3.Parameters.AddWithValue("@eval_1_marks", Eval_1_Marks_txtbox.Text);
                        cmd3.Parameters.AddWithValue("@eval_2_marks", Eval_2_Marks_txtbox.Text);
                        cmd3.Parameters.AddWithValue("@eval_3_marks", Eval_3_Marks_txtbox.Text);
                        cmd3.Parameters.AddWithValue("@final_marks", final_marks);
                        cmd3.ExecuteNonQuery();
                    }


                    Add_Inserted_And_Updated_Marks_On_Data_Grid_View(final_marks , "", student_id);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //Insert_Marks_Of_Another_Student();    
        }

        // Method for calculating the Final Marks of a student by best-of-three method.
        // Returns int type variable
        public int Calculate_Best_Of_Three_Marks()
        {
            try
            {
                int marks_1 = int.Parse(Eval_1_Marks_txtbox.Text);
                int marks_2 = int.Parse(Eval_2_Marks_txtbox.Text);
                int marks_3 = int.Parse(Eval_3_Marks_txtbox.Text);

                return (marks_1 > marks_2 ? (marks_2 > marks_3 ? marks_1 + marks_2 : marks_1 + marks_3) : (marks_1 > marks_3 ? marks_1 + marks_2 : marks_2 + marks_3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }



    }
}
