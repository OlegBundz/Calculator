using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void main_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_button_click(object sender, EventArgs e)
        {
            if (count < 15)
            {
                Button numb_btn = (Button)sender;
                if (main_text_box.Text == "0")
                {
                    main_text_box.Text = main_text_box.Text.Remove(0);
                    current_value = current_value.Remove(0);
                }
                current_value += numb_btn.Text;
                main_text_box.Text += numb_btn.Text;
                count++;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (main_text_box.Text == "Error")
            {
                EnableButton();
            }
            result = 0;
            FirstValue = true;
            current_op = "";
            current_value = "0";
            main_text_box.Text = "0";
        }
        

        private void button_dot_Click(object sender, EventArgs e)
        {
            main_text_box.Text += ".";
            current_value += ",";
        }

        private void operations_button_Click(object sender, EventArgs e)
        {
            Button op_btn = (Button)sender;

            if (FirstValue)
            {
                result = Convert.ToDouble(current_value);
                FirstValue = false;
            }
             
            if(Char.IsDigit(main_text_box.Text[main_text_box.Text.Length-1]))
            {
                if ((Convert.ToDouble(current_value) == 0) && current_op == "/")
                {
                    main_text_box.Text = "Error";
                    EnableButton();
                }
                else
                {
                    main_text_box.Text += op_btn.Text;
                    switch_method(current_op);
                    current_op = op_btn.Text;
                    current_value = "0";
                    main_text_box.Text = Convert.ToString(result) + op_btn.Text;
                }
            }
            else
            {
                current_op = op_btn.Text;
                main_text_box.Text = main_text_box.Text.Remove(main_text_box.Text.Length - 1) + op_btn.Text;
            }
            count = 0;
        }
       
        private void button_equality_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(current_value) != 0)
            {
                switch_method(current_op);
                main_text_box.Text = Convert.ToString(result);
                current_op = "";
            }
            else
            {
                main_text_box.Text = "Error";
                EnableButton();
            }
        }

        private void EnableButton()
        {
            foreach (Control  x in Controls)
            {
                if (x.Text!="C")
                {
                    x.Enabled = !x.Enabled;
                }
            }
        }
        private double switch_method(string operation)
        {
            switch (operation)
            {
                case "*":
                    result *= Convert.ToDouble(current_value);
                    break;
                case "/":
                    result /= Convert.ToDouble(current_value);
                    break;
                case "+":
                    result += Convert.ToDouble(current_value);
                    break;
                case "-":
                    result -= Convert.ToDouble(current_value);
                    break;
            }
            return result;
        }

        private double result = 0;
        private bool FirstValue = true;
        private string current_op="";
        private string current_value="0";
        private int count = 0;
    }
}
