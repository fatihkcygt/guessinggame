using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public class MindNumbers
        {
            public List<int> GuessedNumbers = new List<int>();
            int _digit_one;
            int _digit_two;
            int _digit_three;
            int _digit_four;
            public int digit_one
            {
                get { return _digit_one; }   // get method
                set { _digit_one = value; }  // set method
            }
            public int digit_two
            {
                get { return _digit_two; }   // get method
                set { _digit_two = value; }  // set method
            }
            public int digit_three
            {
                get { return _digit_three; }   // get method
                set { _digit_three = value; }  // set method
            }
            public int digit_four
            {
                get { return _digit_four; }   // get method
                set { _digit_four = value; }  // set method
            }

            public void set_from_full_numbers(int value) // set digits value from full 4 digits number
            {
                this.digit_one = Int32.Parse(value.ToString()[0].ToString());
                this.digit_two = Int32.Parse(value.ToString()[1].ToString());
                this.digit_three = Int32.Parse(value.ToString()[2].ToString());
                this.digit_four = Int32.Parse(value.ToString()[3].ToString());
            }

            public int get_as_full_number()  // get whole digits as 4 digits number
            {
                return this.digit_one * 1000 + this.digit_two * 100 + this.digit_three * 10 + this.digit_four;
            }
        }

        MindNumbers computer_number = new MindNumbers();
        MindNumbers human_number = new MindNumbers();



        public List<string> possible_numbers_as_string = new List<string> {};


        /// <summary>
        /// Fill possible numbers to guessing and add list of possible_numbers_as_string.
        /// 9*9*8*7 Combination. So count equal to 4536.
        /// </summary>
        public void fill()
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    if (b == a) continue;
                    for (int c = 0; c <= 9; c++)
                    {
                        if (c == b || c == a) continue;
                        for (int d = 0; d <= 9; d++)
                        {
                            if (d == a || d == b || d == c) continue;
                            String cnt = "" + a + b + c + d;
                            possible_numbers_as_string.Add(cnt);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fill possible numbers to guessing and add list of possible_numbers_as_string.
        /// 9*9*8*7 Combination. So count equal to 4536.
        /// </summary>
        /// <param name="ans">Possible list element to check guess for remove</param>
        /// <param name="guess">Guess</param>
        /// <param name="negative">Negative value for guess</param>
        /// <param name="positive">Positive value for guess</param>
        public Boolean check(String ans, String guess, int negative, int positive)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                int indis = ans.IndexOf(guess[i]);
                if (indis == i) positive--;
                else if (indis >= 0) negative--;
            }
            return (positive == 0) & (negative == 0);
        }

        /// <summary>
        /// Compare two numbers and return negative and positive values together in string split bt ','
        /// </summary>
        /// <param name="val1">Number one to compare.</param>
        /// <param name="val2">Number two to compare.</param>
        public string compare_two_numbers(int val1, int val2)
        {
            string val1_as_string = val1.ToString();
            string val2_as_string = val2.ToString();
            int positive = 0;
            int negative = 0;
            foreach (char c in val1_as_string)
            {
                if (val2_as_string.Contains(c.ToString()))
                {
                    if (val2_as_string.IndexOf(c) == val1_as_string.IndexOf(c))
                    {
                        positive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
                Console.WriteLine(c);
            }
            return positive.ToString() + "," + negative.ToString();

        }

        public void set_comp_positive_negative_tbox(string value)
        {
            CompPositiveTBox.Text = value.Split(',')[0].ToString();
            CompNegativeTbox.Text = value.Split(',')[1].ToString();
        }

        /// <summary>
        /// Generate a random number from possible list.
        /// </summary>
        public int GenerateFromPossibleList()
        {
            Random _rdm = new Random();
            int index_of_array = _rdm.Next(0, possible_numbers_as_string.Count);
            return Convert.ToInt16(possible_numbers_as_string[index_of_array]);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill();
            HumanGuessTextbox.Enabled = true;
            button1.Enabled = false;
            computer_number.set_from_full_numbers(GenerateFromPossibleList());
            Thread.Sleep(200); // for avoid generate same random int
            human_number.set_from_full_numbers(GenerateFromPossibleList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int round = Int16.Parse(button3.Text.Split('.')[0].ToString()) + 1;
            int HumanGuess = 0;
            if (round == 2)
            {
                CompGuessLabel.Text = human_number.get_as_full_number().ToString();
                HumanGuess = Int16.Parse(HumanGuessTextbox.Text);
                set_comp_positive_negative_tbox(compare_two_numbers(HumanGuess, computer_number.get_as_full_number()));
                ResultLabel.Text = computer_number.get_as_full_number().ToString();
            }

            if (round >= 3)
            {
                if (possible_numbers_as_string.Count == 1)
                {
                    MessageBox.Show(possible_numbers_as_string[0].ToString() + " YOUR NUMBER.");
                }

                int positive = Convert.ToInt16(HumanPositiveBox.Value);
                int negative = Convert.ToInt16(HumanNegativeBox.Value);   
                string guess = human_number.get_as_full_number().ToString();
                for (int j = 0; j < possible_numbers_as_string.Count; j++)
                {
                    if (!check(possible_numbers_as_string.ElementAt(j), guess, negative, positive))
                    {
                        possible_numbers_as_string.RemoveAt(j);
                        j--;
                    }
                }
                
                human_number.set_from_full_numbers(GenerateFromPossibleList());

                HumanGuess = Int16.Parse(HumanGuessTextbox.Text);
                set_comp_positive_negative_tbox(compare_two_numbers(HumanGuess, computer_number.get_as_full_number()));
                CompGuessLabel.Text = human_number.get_as_full_number().ToString();

                computer_number.set_from_full_numbers(GenerateFromPossibleList());
                human_number.set_from_full_numbers(GenerateFromPossibleList());
                CompGuessLabel.Text = human_number.get_as_full_number().ToString();
            }

            button3.Text = round.ToString() + ". ROUND";
        }

        private void HumanGuessTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '0') & ((sender as TextBox).Text.Length == 0))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) || ((TextBox)sender).Text.Contains(e.KeyChar))
            {
                MessageBox.Show("Please insert valid number which has 4 different digits...");
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }
    }
}
