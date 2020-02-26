using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();

           
                

        }


        private void ResultsScreen_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Form1.egg.Count(); i++)
            {
                label1.Text += "\n" + i + ": " + Form1.egg[i];
            }
            for (int i = 0; i < Form1.egg.Count(); i++)
            {
                Form1.egg.Sort();
                label2.Text += "\n" + i + ": " + Form1.egg[i];
            }
            for (int i = 0; i < Form1.egg.Count(); i++)
            {
                int x = Form1.egg.Count();
                label3.Text = Convert.ToString(x);
            }
            this.Refresh();

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
