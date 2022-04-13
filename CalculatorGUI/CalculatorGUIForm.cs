using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        /// <summary>
        /// 1.	Return a string without the Whitespaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            resultTextbox.Text = input.Replace(" ", "");
        }
        /// <summary>
        /// 2.	Reverse a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            char[] input = inputTextBox.Text.ToCharArray();
            Array.Reverse(input);
            string output = new string(input);
            resultTextbox.Text = output;
        }
        /// <summary>
        /// 3.	Display quotient and the remainder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int divident = int.Parse(inputTextBox.Text);
            int divisor = int.Parse(inputTextBox2.Text);
            int result = divident / divisor;
            int remainder = divident % divisor;
            resultTextbox.Text = $"{result} r:{remainder}";
        }
        /// <summary>
        ///  4.	Find the logarithm of a specified number to base 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inputTextBox.Text);
            double result = Math.Log10(number);

            resultTextbox.Text = $"Log({number}) base 10 = {result}";
        }
        /// <summary>
        /// 5.	Find the logarithm of a specified number to a specified base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int number = int.Parse(inputTextBox.Text);
            Console.WriteLine("Enter the base: ");
            int logBase = int.Parse(inputTextBox2.Text);
            double result = Math.Log(number, logBase);
            resultTextbox.Text = $"Log({number}) base {inputTextBox2.Text} = {result}";

        }
        /// <summary>
        /// 6.	Display the minimum and maximum of the two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputTextBox.Text);
            int num2 = int.Parse(inputTextBox2.Text);

            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            resultTextbox.Text = $"Minimum = {min} Maximum = { max }";
        }
        /// <summary>
        /// 7.	Find the specified number to the specified power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            int num = int.Parse(inputTextBox.Text);
            int power = int.Parse(inputTextBox2.Text);

            double result = Math.Pow(num, power);

            resultTextbox.Text = $"{result}";
        }
        /// <summary>
        /// 8. Quadratic equation. Solves the roots for the quadratic equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            int a, b, c;

            double d, x1, x2;
            

            a = Convert.ToInt32(inputTextBox.Text);
            b = Convert.ToInt32(inputTextBox2.Text);
            c = Convert.ToInt32(inputTextBox3.Text);

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                resultTextbox.Text = $"Root 1 = {x1} Root 2 = {x2}";
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                resultTextbox.Text = $"Root 1 = {x1} Root 2 = {x2}";
            }
            else
                resultTextbox.Text = "Root are imeainary. No Solution.";
        }
    
        /// <summary>
        /// 9. Sqrt-Square Root. This function returns the square root of the given number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            double number7 = double.Parse(inputTextBox.Text);
            resultTextbox.Text = Math.Sqrt(number7).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //input text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //result text box
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void inputTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/