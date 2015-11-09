using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class frmStrings : Form
    {
        public bool StringComparing(string first, string second)
        {
            bool answer = false;

            string firstUpper;
            string secondUpper;

            firstUpper = first.ToUpper();
            secondUpper = second.ToUpper();

            if (firstUpper.Length == secondUpper.Length)
            {
                if (firstUpper == secondUpper)
                {
                    answer = true;
                }
            }
            else
            {
                answer = false;
            }


            return answer;
        }
        public frmStrings()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Varribles & input

            string Upper = this.txtStringOne.Text;
            string Lowwer = this.txtStringTwo.Text;
            bool answer;
            // Process

            answer = StringComparing(Upper, Lowwer);

            if (answer == true)
            {
                this.lblAnswer.Text = "They are the same.";
            }
            else if (answer == false)
            {
                this.lblAnswer.Text = "They are not the same sorry";
            }
        }
    }
}
