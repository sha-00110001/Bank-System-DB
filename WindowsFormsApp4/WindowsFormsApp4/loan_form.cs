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
    public partial class loan_form : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";

        public loan_form()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-9PI690J;Integrated Security=True");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            SetValueForText4 = textBox4.Text;
            SetValueForText5 = textBox5.Text;
            SetValueForText6 = textBox6.Text;
            SetValueForText7 = textBox7.Text;


            Form6 frm6 = new Form6();
            frm6.Show();

            
        }
    }
}
