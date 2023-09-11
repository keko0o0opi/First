using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConfirm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DelProgram = new DelegateText();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName,
    }
}
