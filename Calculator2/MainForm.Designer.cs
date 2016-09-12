namespace Calculator2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_equality = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.main_text_box = new System.Windows.Forms.TextBox();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_one
            // 
            this.button_one.Location = new System.Drawing.Point(8, 259);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(65, 65);
            this.button_one.TabIndex = 1;
            this.button_one.Text = "1";
            this.button_one.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_two
            // 
            this.button_two.Location = new System.Drawing.Point(81, 259);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(65, 65);
            this.button_two.TabIndex = 2;
            this.button_two.Text = "2";
            this.button_two.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_zero
            // 
            this.button_zero.Location = new System.Drawing.Point(8, 332);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(138, 65);
            this.button_zero.TabIndex = 3;
            this.button_zero.Text = "0";
            this.button_zero.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(154, 332);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(65, 65);
            this.button_dot.TabIndex = 6;
            this.button_dot.Text = ".";
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_seven
            // 
            this.button_seven.Location = new System.Drawing.Point(8, 113);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(65, 65);
            this.button_seven.TabIndex = 5;
            this.button_seven.Text = "7";
            this.button_seven.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_three
            // 
            this.button_three.Location = new System.Drawing.Point(154, 259);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(65, 65);
            this.button_three.TabIndex = 4;
            this.button_three.Text = "3";
            this.button_three.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_equality
            // 
            this.button_equality.Location = new System.Drawing.Point(227, 259);
            this.button_equality.Name = "button_equality";
            this.button_equality.Size = new System.Drawing.Size(65, 138);
            this.button_equality.TabIndex = 7;
            this.button_equality.Text = "=";
            this.button_equality.Click += new System.EventHandler(this.button_equality_Click);
            // 
            // button_four
            // 
            this.button_four.Location = new System.Drawing.Point(8, 186);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(65, 65);
            this.button_four.TabIndex = 8;
            this.button_four.Text = "4";
            this.button_four.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_five
            // 
            this.button_five.Location = new System.Drawing.Point(81, 186);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(65, 65);
            this.button_five.TabIndex = 9;
            this.button_five.Text = "5";
            this.button_five.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_six
            // 
            this.button_six.Location = new System.Drawing.Point(154, 186);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(65, 65);
            this.button_six.TabIndex = 10;
            this.button_six.Text = "6";
            this.button_six.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_eight
            // 
            this.button_eight.Location = new System.Drawing.Point(81, 113);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(65, 65);
            this.button_eight.TabIndex = 11;
            this.button_eight.Text = "8";
            this.button_eight.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_nine
            // 
            this.button_nine.Location = new System.Drawing.Point(154, 113);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(65, 65);
            this.button_nine.TabIndex = 12;
            this.button_nine.Text = "9";
            this.button_nine.Click += new System.EventHandler(this.number_button_click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(8, 40);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(65, 65);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "C";
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // main_text_box
            // 
            this.main_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_text_box.Location = new System.Drawing.Point(8, 8);
            this.main_text_box.Name = "main_text_box";
            this.main_text_box.Size = new System.Drawing.Size(4000, 20);
            this.main_text_box.TabIndex = 14;
            this.main_text_box.Text = "0";
            this.main_text_box.TextChanged += new System.EventHandler(this.main_text_box_TextChanged);
            // 
            // button_addition
            // 
            this.button_addition.Location = new System.Drawing.Point(227, 113);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(65, 138);
            this.button_addition.TabIndex = 15;
            this.button_addition.Text = "+";
            this.button_addition.Click += new System.EventHandler(this.operations_button_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Location = new System.Drawing.Point(227, 40);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(65, 65);
            this.button_subtraction.TabIndex = 16;
            this.button_subtraction.Text = "-";
            this.button_subtraction.Click += new System.EventHandler(this.operations_button_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(154, 40);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(65, 65);
            this.button_multiplication.TabIndex = 17;
            this.button_multiplication.Text = "*";
            this.button_multiplication.Click += new System.EventHandler(this.operations_button_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(81, 40);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(65, 65);
            this.button_division.TabIndex = 18;
            this.button_division.Text = "/";
            this.button_division.Click += new System.EventHandler(this.operations_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 405);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_equality);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.main_text_box);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_division);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        #endregion
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_equality;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox main_text_box;
        private System.Windows.Forms.Button button_addition;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
    }
}

