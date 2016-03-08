using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Par1;
            decimal Par2;
            string Par1String;
            string Par2String;
            string Result = "";

            Par1String = txtbParameter1.Text;
            Par2String = txtbParameter2.Text;

            Par1 = decimal.Parse(Par1String);
            Par2 = decimal.Parse(Par2String);

            Result += (Par1 + Par2);

            lblResult.Text = Result;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Par1;
            decimal Par2;
            string Par1String;
            string Par2String;
            string Result = "";

            Par1String = txtbParameter1.Text;
            Par2String = txtbParameter2.Text;

            Par1 = decimal.Parse(Par1String);
            Par2 = decimal.Parse(Par2String);

            Result += (Par1 - Par2);

            lblResult.Text = Result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal Par1;
            decimal Par2;
            string Par1String;
            string Par2String;
            string Result = "";

            Par1String = txtbParameter1.Text;
            Par2String = txtbParameter2.Text;

            Par1 = decimal.Parse(Par1String);
            Par2 = decimal.Parse(Par2String);

            Result += (Par1 * Par2);

            lblResult.Text = Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float Par1;
            float Par2;
            string Par1String;
            string Par2String;
            string Result = "";
            float dcmResult;

            Par1String = txtbParameter1.Text;
            Par2String = txtbParameter2.Text;

            Par1 = float.Parse(Par1String);
            Par2 = float.Parse(Par2String);

            dcmResult = Par1 / Par2;
            Result += dcmResult.ToString();


            lblResult.Text = Result;
        }
    }
}
