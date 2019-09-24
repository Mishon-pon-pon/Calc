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
        Expression expression = new Expression();
        static Int32 stage = 0;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        {
            expression.operant = 1;
            SetValueTextBox(1.ToString(), textBox1);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            expression.operant = 2;
            SetValueTextBox(2.ToString(), textBox1);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            expression.operant = 3;
            SetValueTextBox(3.ToString(), textBox1);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            expression.operant = 4;
            SetValueTextBox(4.ToString(), textBox1);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            expression.operant = 5;
            SetValueTextBox(5.ToString(), textBox1);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            expression.operant = 6;
            SetValueTextBox(6.ToString(), textBox1);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            expression.operant = 7;
            SetValueTextBox(7.ToString(), textBox1);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            expression.operant = 8;
            SetValueTextBox(8.ToString(), textBox1);
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            expression.operant = 9;
            SetValueTextBox(9.ToString(), textBox1);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            expression.operant = 0;
            SetValueTextBox(0.ToString(), textBox1);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            expression.action = "Plus";
            expression.saveOnceOperant(expression.operant);
            expression.ResetOperant();
            SetValueTextBox("+", textBox1);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            expression.action = "Minus";
            expression.saveOnceOperant(expression.operant);
            expression.ResetOperant();
            SetValueTextBox("-", textBox1);
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            expression.action = "Multi";
            expression.saveOnceOperant(expression.operant);
            expression.ResetOperant();
            SetValueTextBox("*", textBox1);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            expression.action = "Division";
            expression.saveOnceOperant(expression.operant);
            expression.ResetOperant();
            SetValueTextBox("/", textBox1);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Int32 result;
            switch (expression.action)
            {
                case "Plus":
                    expression.result = expression.result + expression.operant;
                    expression.ResetOperant();
                    expression.operant = expression.result;
                    SetValueTextBox(expression.result.ToString(), textBox1, true);
                    break;
                case "Minus":
                    expression.result = expression.result - expression.operant;
                    expression.ResetOperant();
                    expression.operant = expression.result;
                    SetValueTextBox(expression.result.ToString(), textBox1, true);
                    break;
                case "Multi":
                    expression.result = expression.result * expression.operant;
                    expression.ResetOperant();
                    expression.operant = expression.result;
                    SetValueTextBox(expression.result.ToString(), textBox1, true);
                    break;
                case "Division":
                    expression.result = expression.result / expression.operant;
                    expression.ResetOperant();
                    expression.operant = expression.result;
                    SetValueTextBox(expression.result.ToString(), textBox1, true);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private static void SetValueTextBox(String n, TextBox t)
        {
            if (t.Text == "0") t.Text = "";
            t.Text = t.Text + n;
            stage = 0;
        }
        private static void SetValueTextBox(String n, TextBox t, Boolean result)
        {
            if (t.Text == "0" || result) t.Text = "";
            t.Text = t.Text + n;
            stage = 1;
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            expression.Clear();
            textBox1.Text = "0";
        }
    }
}
