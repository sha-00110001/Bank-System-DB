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
    public partial class Employee_Functions : Form
    {
        public Employee_Functions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Add em = new Employee_Add();
            em.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bank_System bank = new Bank_System();
            bank.Show();
            this.Hide();
        }
    }
}
