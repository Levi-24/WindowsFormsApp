using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMe_Click;
        }
        static Random rnd = new Random();

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            if (lblTextField.Text.Contains("Placeholder"))
            {
                lblTextField.Text = "Hello World!";
            }
            else
            {
                lblTextField.BackColor = Color.FromArgb(
                    red: rnd.Next(0, 256),
                    blue: rnd.Next(0, 256),
                    green: rnd.Next(0, 256)
                    ) ;
            }
        }
    }
}
