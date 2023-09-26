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
    public partial class Loan_Types : Form
    {
        public Loan_Types()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHOW show = new SHOW();
            show.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_SystemDataSet.LOAN' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lOANTableAdapter.Fill(this.bankDataSet.LOAN);
        }
    }
}
