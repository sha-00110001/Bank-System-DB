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
    public partial class SHOW : Form
    {
        public SHOW()
        {
            InitializeComponent();
        }

        private void SHOW_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Show_customer sc = new Show_customer();
            sc.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanWithData fs = new LoanWithData();
            fs.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan_Types loan = new Loan_Types();
            loan.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Functions functions= new Admin_Functions();
            functions.Show();
            this.Hide();
        }
    }
}
