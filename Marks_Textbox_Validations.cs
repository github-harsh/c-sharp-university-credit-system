using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PVGCreditSystem
{

    //Code to validate Marks Entered in the Evaluation Marks Textboxes

    public partial class Course : Form
    {

        private void Eval_1_Marks_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            Eval_1_Marks_txtbox.MaxLength = 2;
        }

        private void Eval_1_Marks_txtbox_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(Eval_1_Marks_txtbox.Text, out number))
            {
                if (number < 0 || number > 25)
                {
                    Eval_1_Marks_txtbox.Clear();
                    MessageBox.Show("Enter Between 0 and 25 only");
                }
            }
        }


        // Evaluation 2 Marks Textbox
        private void Eval_2_Marks_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            Eval_2_Marks_txtbox.MaxLength = 2;
        }

        private void Eval_2_Marks_txtbox_Leave(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(Eval_2_Marks_txtbox.Text, out number))
            {
                if (number < 0 || number > 25)
                {
                    Eval_2_Marks_txtbox.Clear();
                    MessageBox.Show("Enter Between 0 and 25 only");
                }
            }
        }


        //Evaluation 3 Marks Textbox
        private void Eval_3_Marks_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            Eval_3_Marks_txtbox.MaxLength = 2;
        }

        private void Eval_3_Marks_txtbox_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(Eval_3_Marks_txtbox.Text, out number))
            {
                if (number < 0 || number > 25)
                {
                    Eval_3_Marks_txtbox.Clear();
                    MessageBox.Show("Enter Between 0 and 25 only");
                }
            }
        }
    }
}
