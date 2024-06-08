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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet4.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.restaurantDataSet4.Menu);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFICM1U;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand CMD = new SqlCommand("delete from Menu  where itemsName=@itemsName", con);

            CMD.Parameters.AddWithValue("@itemsName", comboBox1.Text);
            con.Open();
            int ro = CMD.ExecuteNonQuery();
            if (ro > 0)
            {
                MessageBox.Show("deleted successfully :))");
            }
            else
                MessageBox.Show(" not deleted successfully :((");
            con.Close();
            // this.employeeTableAdapter.Fill(this.trialsectionDataSet5.Employee);

        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-IFICM1U;Initial Catalog=Restaurant;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("insert into Menu values(@MenuID,@itemsName,@price)", con);
                cmd.Parameters.AddWithValue("@MenuID", minuTxt.Text);
                cmd.Parameters.AddWithValue("@itemsName", itemTxt.Text);
                cmd.Parameters.AddWithValue("@price", float.Parse(priceTxt.Text));


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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
