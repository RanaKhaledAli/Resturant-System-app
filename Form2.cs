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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFICM1U;Initial Catalog=Restaurant;Integrated Security=True");
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

       

        private void addpage_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {


            con.Open();
            string query = "delete from emp where id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            int rowf = cmd.ExecuteNonQuery();
            if (rowf > 0)
            {
                MessageBox.Show("removed sucess");

            }
            else
            {
                MessageBox.Show("");
            }
            con.Close();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //this is the first way to insert data
            //  SqlCommand cmd = new SqlCommand("insert into emp values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "''" + textBox5.Text + "') ", con);
            //this is the second way to insert data
            SqlCommand cmd = new SqlCommand("select name,username,password,ssn,address,telephone,position,gender,salary,branch_id from emp where id='" + comboBox1.Text +"'", con);
            
          
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(); //بيقرأ الداتا من الداتا بيز ويخلي السي شارب يفهمها
            if (dr.Read()) //لو قرا ان في بيانات يبقى اليوزر والباسوورد صحيحين
            {
                //الداتااللي موجوده في اليوزر نيم 
                textBox11.Text = dr[0].ToString();
                textBox9.Text = dr[1].ToString();
                textBox10.Text =dr[2].ToString();
                textBox5.Text = dr[3].ToString(); 
                textBox4.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
                textBox8.Text = dr[6].ToString();
                textBox2.Text = dr[7].ToString();
                textBox3.Text = dr[8].ToString();
                textBox7.Text = dr[9].ToString();


            }
            else
            {
                MessageBox.Show("enter the right data");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from emp";
            SqlCommand cmd = new SqlCommand(query,con);
            
            SqlDataReader dr = cmd.ExecuteReader(); //بيقرأ الداتا من الداتا بيز ويخلي السي شارب يفهمها
            if (dr.Read())
            {
                textBox1.Text= dr[0].ToString();
            }
            else
            {
                MessageBox.Show("mmmm");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is the first way to insert data
            //  SqlCommand cmd = new SqlCommand("insert into emp values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "''" + textBox5.Text + "') ", con);
            //this is the second way to insert data
            SqlCommand cmd = new SqlCommand("select password,address,salary from emp where id='" + comboBox2.Text + "'", con);
            

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(); //بيقرأ الداتا من الداتا بيز ويخلي السي شارب يفهمها
            if (dr.Read()) //لو قرا ان في بيانات يبقى اليوزر والباسوورد صحيحين
            {
                //الداتااللي موجوده في اليوزر نيم 
                
                textBox21.Text = dr[0].ToString();
                textBox15.Text = dr[1].ToString();
              
                textBox14.Text = dr[2].ToString();
               
               
              


            }
            else
            {
                MessageBox.Show("enter the right data");
            }
            con.Close();
        }

        

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBTn_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewpage_Click(object sender, EventArgs e)
        {

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void subBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this is the first way to insert data
                //  SqlCommand cmd = new SqlCommand("insert into emp values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "''" + textBox5.Text + "') ", con);
                //this is the second way to insert data
                SqlCommand cmd = new SqlCommand("insert into emp values(@id,@name,@username,@password,@ssn,@address,@telephone,@position,@gender,@salary,@branch_id)", con);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                cmd.Parameters.AddWithValue("@password", passTxt.Text);
                cmd.Parameters.AddWithValue("@ssn", ssnTxt.Text);
                cmd.Parameters.AddWithValue("@address", addrTxt.Text);
                cmd.Parameters.AddWithValue("@telephone", phoneTxt.Text);
                cmd.Parameters.AddWithValue("@position", posTxt.Text);
                cmd.Parameters.AddWithValue("@gender", genderTxt.Text);
                cmd.Parameters.AddWithValue("@salary", float.Parse(salaTxt.Text));
                if (branchCombobox.Text == "Helioples")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 2);
                }
                else if (branchCombobox.Text == "Nasr City")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 1);
                }
                else if (branchCombobox.Text == "New cairo")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 3);
                }




                con.Open();
                int rowf = cmd.ExecuteNonQuery();
                if (rowf > 0)
                {
                    MessageBox.Show("added succefully");
                }
                else
                {
                    MessageBox.Show("not added");
                }
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update emp set password=@password,address=@address,salary=@salary where id=@id", con);
            cmd.Parameters.AddWithValue("@id", comboBox2.Text);
            cmd.Parameters.AddWithValue("@password", textBox17.Text);
            cmd.Parameters.AddWithValue("@address", textBox16.Text);
            cmd.Parameters.AddWithValue("@salary", float.Parse(textBox13.Text));
            con.Open();
            int rowf = cmd.ExecuteNonQuery();
            if (rowf > 0)
            {
                MessageBox.Show("updated succefully");
            }
            else
            {
                MessageBox.Show("not updated ");
            }
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
