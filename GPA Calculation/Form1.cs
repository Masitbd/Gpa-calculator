using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int marketing, accounting, computing, total, avg;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.ResetText();
            textAccounting.ResetText();
            textMarketing.ResetText();
            texComputing.ResetText();
            textTotal.ResetText();
            textAvg.ResetText();
            textAvg.ResetText();
            textGrade.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marketing = int.Parse(textMarketing.Text);
            accounting = int.Parse(textAccounting.Text);
            computing = int.Parse(texComputing.Text);

            total = marketing + accounting + computing;
            textTotal.Text = total.ToString();

            avg = total / 3;
            textAvg.Text = avg.ToString();


            if (avg > 90)
            {
                textGrade.Text = "A";
            }
            else if(avg>80)
            {
                textGrade.Text = "B";
            }

            else if (avg > 70)
            {
                textGrade.Text = "C";
            }
            else if (avg > 60)
            {
                textGrade.Text = "D";
            }

            else
            {
                textGrade.Text = "F";
            }
        }
    }
}
