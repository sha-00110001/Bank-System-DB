using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Bank_System : Form
    {
        public Bank_System()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Functions function = new Admin_Functions();
            function.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Functions em = new Employee_Functions();
            em.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Functions cf = new Customer_Functions();
            cf.Show();
            this.Hide();
        }

       
    }
}
