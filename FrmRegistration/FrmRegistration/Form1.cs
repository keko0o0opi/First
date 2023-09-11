using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = textBox4.Text.ToString();
            StudentInfoClass.LastName = textBox3.Text.ToString();
            StudentInfoClass.MiddleName = textBox5.Text.ToString();
            StudentInfoClass.Address = textBox8.Text.ToString();
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(textBox6.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(textBox7.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt64(textBox1.Text.ToString());

        }
    }
}
