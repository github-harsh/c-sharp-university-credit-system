using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVGCreditSystem
{
    partial class Course : Form
    {
        // Method for adding newly inserted or updated student marks on the dataGridView1.
        // Called from both Insert_Eval_Marks_Click() and Update_Eval_Marks_Click()

        private void Add_Inserted_And_Updated_Marks_On_Data_Grid_View(int final_marks, string student_name, int student_id)
        {

            if (StudentComboBox.SelectedIndex == -1)
            {
                string[] row = new string[] {student_id.ToString(), student_name, Eval_1_Marks_txtbox.Text, Eval_2_Marks_txtbox.Text, Eval_3_Marks_txtbox.Text, final_marks.ToString() };
                dataGridView1.Rows.Add(row);
                dataGridView1.Refresh();
            }

            else
            {
                string[] row = new string[] {student_id.ToString(), StudentComboBox.SelectedItem.ToString(), Eval_1_Marks_txtbox.Text, Eval_2_Marks_txtbox.Text, Eval_3_Marks_txtbox.Text, final_marks.ToString() };
                dataGridView1.Rows.Add(row);
                dataGridView1.Refresh();
            }

        }
    }
}
