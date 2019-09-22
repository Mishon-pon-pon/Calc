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
        static Int32 stage = 0;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        {
            operand.SetValue(1);
            SetValueTextBox(1.ToString(), textBox1);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            operand.SetValue(2);
            SetValueTextBox(2.ToString(), textBox1);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            operand.SetValue(3);
            SetValueTextBox(3.ToString(), textBox1);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            operand.SetValue(4);
            SetValueTextBox(4.ToString(), textBox1);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            operand.SetValue(5);
            SetValueTextBox(5.ToString(), textBox1);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            operand.SetValue(6);
            SetValueTextBox(6.ToString(), textBox1);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            operand.SetValue(7);
            SetValueTextBox(7.ToString(), textBox1);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            operand.SetValue(8);
            SetValueTextBox(8.ToString(), textBox1);
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            operand.SetValue(9);
            SetValueTextBox(9.ToString(), textBox1);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            operand.SetValue(0);
            SetValueTextBox(0.ToString(), textBox1);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            action = "Plus";
            subResult = operand.GetValue();
            operand.Clear();
            SetValueTextBox("+", textBox1);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            action = "Minus";
            subResult = operand.GetValue();
            operand.Clear();
            SetValueTextBox("-", textBox1);
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            action = "Multi";
            subResult = operand.GetValue();
            operand.Clear();
            SetValueTextBox("*", textBox1);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            action = "Division";
            subResult = operand.GetValue();
            operand.Clear();
            SetValueTextBox("/", textBox1);
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
                    SetValueTextBox(result.ToString(), textBox1, true);
                    break;
                case "Minus":
                    result = subResult - operand.GetValue();
                    operand.Clear();
                    action = "";
                    SetValueTextBox(result.ToString(), textBox1, true);
                    break;
                case "Multi":
                    result = subResult * operand.GetValue();
                    operand.Clear();
                    action = "";
                    SetValueTextBox(result.ToString(), textBox1, true);
                    break;
                case "Division":
                    result = subResult / operand.GetValue();
                    operand.Clear();
                    action = "";
                    SetValueTextBox(result.ToString(), textBox1, true);
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
            if (t.Text == "0" || stage == 1) t.Text = "";
            t.Text = t.Text + n;
            stage = 0;
        }
        private static void SetValueTextBox(String n, TextBox t, Boolean result)
        {
            if (t.Text == "0" || result) t.Text = "";
            t.Text = t.Text + n;
            stage = 1;
        }
    }
}
