using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppp_ass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Soda ")
            {
                dt.Rows.Add("Soda", "1.95");
            }
            else if (comboBox1.Text == "Tea ")
            {
                dt.Rows.Add("Tea ", "1.50");
            }
            else if (comboBox1.Text == "Coffee")
            {
                dt.Rows.Add("Coffee", "1.25");
            }
            else if (comboBox1.Text == "Minearl Water")
            {
                dt.Rows.Add("Minearl Water", "2.95");
            }
            else if (comboBox1.Text == "Juice")
            {
                dt.Rows.Add("Juice", "2.50");
            }
            else if (comboBox1.Text == "Milk")
            {
                dt.Rows.Add("Milk", "1.50");
            }
            getPrice();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.Text == "Buffalo wings")
            {
                dt.Rows.Add("Buffalo wings", "5.95");
            }
            else if (comboBox2.Text == "Buffalo Fingers")
            {
                dt.Rows.Add("Buffalo Fingers", "5.95");
            }
            else if (comboBox2.Text == "Potato skins")
            {
                dt.Rows.Add("Potato skins", "8.95");
            }
            else if (comboBox2.Text == "Nachos")
            {
                dt.Rows.Add("Nachos", "8.95");
            }
            else if (comboBox2.Text == "Mushroom Chaps")
            {
                dt.Rows.Add("Mushroom Chaps", "10.95");
            }
            else if (comboBox2.Text == "Shrimp Coocktail")
            {
                dt.Rows.Add("Shrimp Coocktail", "12.95");
            }
            else if (comboBox2.Text == "Shrimp Coocktail")
            {
                dt.Rows.Add("Shrimp Coocktail", "12.95");
            }
            else if (comboBox2.Text == "Cips and salsa")
            {
                dt.Rows.Add("Cips and salsa", "6.95");
            }
            getPrice();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Seafood Alfredo")
            {
                dt.Rows.Add("Seafood Alfredo", "15.95");
            }
            else if (comboBox3.Text == "Chicken Alferdo")
            {
                dt.Rows.Add("Chicken Alferdo", "13.95");
            }
            else if (comboBox3.Text == "Chicken Pateeta")
            {
                dt.Rows.Add("Chicken Pateeta", "13.95");
            }
            else if (comboBox3.Text == "Turkey Club")
            {
                dt.Rows.Add("Turkey Club", "11.95");
            }
            else if (comboBox3.Text == "Losber Pie")
            {
                dt.Rows.Add("Losber Pie", "19.95");
            }
            else if (comboBox3.Text == "Prime rub")
            {
                dt.Rows.Add("Prime rub", "20.95");
            }
            else if (comboBox3.Text == "Scrimp sacert")
            {
                dt.Rows.Add("Scrimp sacert", "18.95");
            }
            else if (comboBox3.Text == "Turkey dinner")
            {
                dt.Rows.Add("Turkey dinner", "13.95");
            }
            else if (comboBox3.Text == "Stuffed Chicken")
            {
                dt.Rows.Add("Stuffed Chicken", "14.95");
            }
            getPrice();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Apple Pie")
            {
                dt.Rows.Add("Apple Pie", "5.95");
            }
            else if (comboBox4.Text == "Sundae")
            {
                dt.Rows.Add("Sundae", "3.95");
            }
            else if (comboBox4.Text == "Carrot cake")
            {
                dt.Rows.Add("Carrot cake", "5.95");
            }
            else if (comboBox4.Text == "Mud pie")
            {
                dt.Rows.Add("Mud pie", "4.95");
            }
            else if (comboBox4.Text == "Apple crisp")
            {
                dt.Rows.Add("Apple crisp", "5.95");
            }
            getPrice();
        }
        public void getPrice()
        {
            double total = 0;
            foreach (DataRow item in dt.Rows)
            {
                total += Convert.ToDouble(item["Price"]);
            }
            textBox1.Text = total.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
