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
    public partial class Employee_Add : Form
    {
        public Employee_Add()
        {
            InitializeComponent();
        }

        private void Employee_Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.CUSTOMER' table. You can move, or remove it, as needed.
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CUSTOMER VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The item was successfuly added.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.bankDataSet.CUSTOMER);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Functions em = new Employee_Functions();
            em.Show();
            this.Hide();
        }
    }
}
