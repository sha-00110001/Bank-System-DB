using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = loan_form.SetValueForText1;
            label2.Text = loan_form.SetValueForText2;
            label3.Text = loan_form.SetValueForText3;
            label4.Text = loan_form.SetValueForText4;
            label5.Text = loan_form.SetValueForText5;
            label6.Text = loan_form.SetValueForText6;
            label7.Text = loan_form.SetValueForText7;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO LOAN VALUES('" + textBox2.Text + "','" + label2.Text + "','" + textBox1.Text +"','"+label6.Text+"','"+label7.Text+ "')";

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The item was successfuly added.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "SSN";
            label2.Text = "Number_Of_Branch";
            label3.Text = "Name";
            label4.Text = "Phone";
            label5.Text = "Address";
            label6.Text = "Amount";
           
            MessageBox.Show("The item was rejected.");

        }
    }
}
