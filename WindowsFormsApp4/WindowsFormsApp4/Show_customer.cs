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
    public partial class Show_customer : Form
    {
        public Show_customer()
        {
            InitializeComponent();
        }

        private void Show_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bank_SystemDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHOW show = new SHOW();
            show.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter1.Fill(this.bankDataSet.CUSTOMER);
        }
    }
}
