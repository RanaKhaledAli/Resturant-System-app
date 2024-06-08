using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RESTAURANT_PROJECT
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFICM1U;Initial Catalog=Restaurant;Integrated Security=True");


        private void addbtn_Click(object sender, EventArgs e)
        {



            SqlCommand CMD;
            con.Open();
            SqlDataReader r;


            if (one.Checked == true)
            {

                CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + one.Text, con);
                r = CMD.ExecuteReader();
                if (r.Read())
                {
                    itemTxt.Text = r[0].ToString();
                }
            }



            //    }
            //    else if (two.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", two.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (three.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", three.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (four.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", four.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (five.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", five.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (six.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", six.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (radioButton7.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", radioButton7.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (eight.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", eight.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (nine.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", nine.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (ten.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", ten.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (eleven.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", eleven.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (twelve.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", twelve.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //    else if (thirteen.Checked == true)
            //    {
            //        CMD.Parameters.AddWithValue("@itemsName", thirteen.Text);
            //        itemTxt.Text = r[1].ToString();
            //    }
            //, 

            con.Close();
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMD;

                SqlDataReader r;
                int count = 0;
                
                if (one.Checked == true)
                {
                    
                    CMD = new SqlCommand("select itemsName ,price from Menu where itemsName='" + one.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();
                        
                        
                        count++;
                    }
                    con.Close();
                }
                else if (two.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();
                        
                        count++;
                    }
                    con.Close();
                    
                }
                else if (three.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (four.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (five.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (six.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (eight.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (ten.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (eleven.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (twelve.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (thirteen.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlCommand CMD;

                SqlDataReader r;
               
                if (one.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName ,price from Menu where itemsName='" + one.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        textBox1.Text = r[0].ToString();
                        textBox1.Text += r[1].ToString() + Environment.NewLine;


                        //SqlCommand v = new SqlCommand("insert into the_order quantity='" + r[0].ToString() + "',price '"+ r[1].ToString() + "' ");
                        
                        //int rowf = v.ExecuteNonQuery();
                        //if (rowf > 0)
                        //{
                        //    MessageBox.Show("added succefully");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("not added");
                        //}
                       



                    }

                    con.Close();
                }
                
                 if (two.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName,price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                       
                        textBox1.Text += r[0].ToString();
                        textBox1.Text += r[1].ToString() + Environment.NewLine;
                       


                        
                    }

                   
                    con.Close();
                  
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderData od = new OrderData();
            od.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_screen m = new main_screen();
            this.Hide();

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            priceTxt.Clear();
        }
    }
}

