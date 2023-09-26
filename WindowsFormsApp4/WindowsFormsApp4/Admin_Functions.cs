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
    public partial class Admin_Functions : Form
    {
        public Admin_Functions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD add = new ADD();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update Update = new update();
            Update.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SHOW show = new SHOW();
            show.Show();
            this.Hide();
        }

        private void Functions_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bank_System bank = new Bank_System();
            bank.Show();
            this.Hide();
        }
    }
}
