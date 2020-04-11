using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PVGCreditSystem
{
    partial class Course : Form
    {
        private void Data_Grid_View_Initialization()
        {
            dataGridView1.Show();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Name = "Student Name";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[5].Name = "Total Marks Scored";


            // Getting modes of evaluation modes for the selected subject and displaying on dataGridView1.
            string commandText1 = "SELECT eval_mode_1, eval_mode_2, eval_mode_3 from Evaluation where subject_id = (SELECT subject_id from Subject where subject_name = @subj_name)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(commandText1, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.SelectedItem);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        dataGridView1.Columns[2].Name = reader.GetString(0);
                        dataGridView1.Columns[3].Name = reader.GetString(1);
                        dataGridView1.Columns[4].Name = reader.GetString(2);
                    }

                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Get_All_Students_Marks_For_Displaying_On_DataGrid();

        }

        protected void Get_All_Students_Marks_For_Displaying_On_DataGrid()
        {

            string commandText2 = "select st.student_id, st.student_name ,e.eval_1_marks ,e.eval_2_marks,e.eval_3_marks, e.final_marks from Student st JOIN Evaluation_Marks e on (e.student_id = st.student_id) where e.subject_id = (SELECT subject_id from Subject where subject_name = @subj_name)";

            try
            {

                using (SqlCommand cmd = new SqlCommand(commandText2, sqlConnection1))
                {
                    cmd.Parameters.AddWithValue("@subj_name", SubjectComboBox.SelectedItem);
                    SqlDataReader reader = cmd.ExecuteReader();



                    // Alternate code for populating datagridview using DataTable and SqlDataAdapter

                    //Code for creating data adapter and pre-populating it with all the results from DataTable and attaching that      DataTable to the datagridview.                     
                    
                    //SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);
                    //DataTable dtRecord = new DataTable();
                    //sqlDA.Fill(dtRecord);
                    //dataGridView1.DataSource = dtRecord;

                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(2).ToString() , reader.GetInt32(3).ToString() , reader.GetInt32(4).ToString() , reader.GetInt32(5).ToString() };
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Refresh();
                    }

                    reader.Close();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // Click event of dataGridView1
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string stud_name = (string)dataGridView1[1, dataGridView1.CurrentCell.RowIndex  ].Value;

            Display_And_Update_Student_Marks(stud_name);
        }

    }
}
