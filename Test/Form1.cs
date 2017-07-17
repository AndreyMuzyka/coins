using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Test.Classes;
namespace Test
{
    public partial class Form1 : Form
    {
        public FirstWay firstWay;
        public SecondWay secondWay;
        public Form1()
        {
            InitializeComponent();

            firstWay = new FirstWay();
            secondWay = new SecondWay();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxFirstResult.Text = firstWay.GetWaysNumber().ToString();
            textBoxSecondResult.Text = secondWay.GetWaysNumber().Last().ToString();
        }
    }
}
