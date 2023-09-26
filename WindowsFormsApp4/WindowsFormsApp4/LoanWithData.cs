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
    public partial class LoanWithData : Form
    {
        public LoanWithData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection=new SqlConnection("Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True");
            string query = @"SELECT LOAN.LOAN_NUM, LOAN.ID_,LOAN.AMOUNT_,LOAN.NUMBER_BR,LOAN.TYPE_LOAN_,EMPLOYEE.NAME as Employee_Name,CUSTOMER.NAME_ as Customer_Name FROM [Bank System].dbo.LOAN ,[Bank System].dbo.EMPLOYEE,[Bank System].dbo.CUSTOMER,[Bank System].dbo.PROVIDER
            where LOAN.ID_=EMPLOYEE.ID_ and LOAN.LOAN_NUM=PROVIDER.LOAN_NUM and PROVIDER.SSN=CUSTOMER.SSN";
            sqlConnection.Open();
            string conn = "Data Source=DESKTOP-9PI690J;Initial Catalog=Bank;Integrated Security=True";

            //define the SqlCommand object
            SqlCommand cmd = new SqlCommand(query,sqlConnection);


            //Set the SqlDataAdapter object
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            //define dataset
            DataSet ds = new DataSet();

            //fill dataset with query results
            dAdapter.Fill(ds);

            //set DataGridView control to read-only
            dataGridView1.ReadOnly = true;

            //set the DataGridView control's data source/data table
            dataGridView1.DataSource = ds.Tables[0];


            //close connection
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHOW show= new SHOW();
            show.Show();
            this.Hide();
        }
    }
}
