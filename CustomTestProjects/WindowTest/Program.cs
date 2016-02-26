using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form TestForm = new Form();
            TestForm.Height = 700;
            TestForm.Width = 700;

            Button btnTest = new Button();
            btnTest.Text = "TestButton";
            btnTest.Location = new System.Drawing.Point(20, 20);
            TestForm.Controls.Add(btnTest);

            var lblTest = new Label();
            lblTest.Location = new System.Drawing.Point(25, 20);
            lblTest.Text = "";
            TestForm.Controls.Add(lblTest);

            btnTest.Click += BtnTest_Click;

            Application.Run(TestForm);

            
        }

        private static void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The button has been clicked!");
        }
    }
}
