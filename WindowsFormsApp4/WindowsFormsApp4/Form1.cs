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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.BANK' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO BANK VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The item was successfuly added.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bANKTableAdapter.Fill(this.bankDataSet.BANK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD add = new ADD();
            add.Show();
            this.Hide();
        }
    }
}
