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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
           

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE EMPLOYEE SET NAME ='" + textBox1.Text + "' ,NUMBER_BR = '" + textBox3.Text + "' WHERE ID_ = '" + textBox2.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updated");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.bankDBDataSet.EMPLOYEE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE CUSTOMER SET NUMBER_BR ='" + textBox5.Text + "' ,NAME_ = '" + textBox6.Text + "',PHONE = '" + textBox7.Text + "',ADDRESS = '" + textBox8.Text + "'    WHERE SSN = '" + textBox4.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updated");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bankDBDataSet.CUSTOMER);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Functions functions= new Admin_Functions();
            functions.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
