using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PVGCreditSystem
{
    partial class Course : Form
    {

        private void Update_Eval_Marks_Button_Click(object sender, EventArgs e)
        {

            string commandText1 = "UPDATE Evaluation_Marks set eval_1_marks = @eval_1_marks , eval_2_marks = @eval_2_marks , eval_3_marks = @eval_3_marks , final_marks = @final_marks where student_id = (SELECT student_id from Student where student_name = @stud_name) and subject_id = (SELECT subject_id from Subject where subject_name = @subj_name)";

            string commandText2 = "SELECT student_id from Student where student_name = @stud_name";

            Total_Score_label.Show();

            // Method called from Insert_Eval_And_Final_Marks.cs file
            int final_marks = Calculate_Best_Of_Three_Marks();
            Marks_Outof_50.Show();
            Marks_Outof_50.Text = final_marks + " / 50";



            try
            {
                // Code for getting student_name from dataGrdView1 if dataGridView1 row is clicked.
                string student_id=null;
                string student_name;



                if (StudentComboBox.SelectedIndex == -1)
                {
                    student_id = (string)dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
                    TeacherNameLabel.Text = "Here";
                    //TeacherNameLabel.Text = student_id.ToString();
                    student_name = (string)dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value;
                }
                else
                {
                    student_name = StudentComboBox.SelectedItem.ToString();
                    using (SqlCommand cmd = new SqlCommand(commandText2, sqlConnection1))
                    {
                        cmd.Parameters.AddWithValue("@stud_name", StudentComboBox.SelectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            student_id = reader.GetInt32(0).ToString();
                        }
                        reader.Close();
                    }
                }

                using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@eval_1_marks", Eval_1_Marks_txtbox.Text);
                    cmd.Parameters.AddWithValue("@eval_2_marks", Eval_2_Marks_txtbox.Text);
                    cmd.Parameters.AddWithValue("@eval_3_marks", Eval_3_Marks_txtbox.Text);
                    cmd.Parameters.AddWithValue("@final_marks", final_marks);
                    cmd.Parameters.AddWithValue("@stud_name", student_name);
                    cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.SelectedItem);
                    cmd.ExecuteNonQuery();
                }


                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]);
                dataGridView1.Refresh();

                Add_Inserted_And_Updated_Marks_On_Data_Grid_View(final_marks , student_name, Int32.Parse(student_id));


                // For clearing out the textboxes after update.
                Marks_Outof_50.ResetText();
                Eval_1_Marks_txtbox.ResetText();
                Eval_2_Marks_txtbox.ResetText();
                Eval_3_Marks_txtbox.ResetText();
                Hide_Eval_And_Insert_Marks_And_Update_Marks_Code();


            }
            catch ( Exception ex)
            {
                MessageBox.Show("Here is the problem");
            }

            MessageBox.Show("Marks Updated Successfully");
        }


    }
}
