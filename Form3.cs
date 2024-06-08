using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_PROJECT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            

            if(checkBox1.Checked==true)
            {
                textBox2.Text = checkBox1.Text ;
                
                count++;
            }
            if (checkBox2.Checked == true)
            {
                textBox2.Text += checkBox2.Text;
                
                count++;
            }
            if (checkBox3.Checked == true)
            {
                textBox2.Text += checkBox3.Text ;
               
                
                count++;
            }
            textBox1.Text = count.ToString();


        }
    }
}
