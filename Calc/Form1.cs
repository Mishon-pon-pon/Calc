using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operand operand = new Operand();
        Int32 subResult;
        String action;


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        {
            operand.SetValue(1);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            operand.SetValue(2);

        }

        private void Number3_Click(object sender, EventArgs e)
        {
            operand.SetValue(3);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            operand.SetValue(4);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            operand.SetValue(5);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            operand.SetValue(6);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            operand.SetValue(7);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            operand.SetValue(8);
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            operand.SetValue(9);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            operand.SetValue(0);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            action = "Plus";
            subResult = operand.GetValue();
            operand.Clear();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            action = "Minus";
            subResult = operand.GetValue();
            operand.Clear();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            action = "Multi";
            subResult = operand.GetValue();
            operand.Clear();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            action = "Division";
            subResult = operand.GetValue();
            operand.Clear();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Int32 result;
            switch (action)
            {
                case "Plus":
                    result = subResult + operand.GetValue();
                    operand.Clear();
                    action = "";
                    MessageBox.Show(result.ToString());
                    break;
                case "Minus":
                    result = subResult - operand.GetValue();
                    operand.Clear();
                    action = "";
                    MessageBox.Show(result.ToString());
                    break;
                case "Multi":
                    result = subResult * operand.GetValue();
                    operand.Clear();
                    action = "";
                    MessageBox.Show(result.ToString());
                    break;
                case "Division":
                    result = subResult / operand.GetValue();
                    operand.Clear();
                    action = "";
                    MessageBox.Show(result.ToString());
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
