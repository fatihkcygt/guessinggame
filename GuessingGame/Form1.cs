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

        public int GenerateRandomNo()
        {
            int[] exclude = new int[3];
            exclude[0] = 0;
            int digit_one;
            int digit_two;
            int digit_three;
            int digit_four;

            Random _rdm = new Random();
            do
            {
                digit_one = _rdm.Next(1, 10);
            } while (exclude.Contains(digit_one));
            exclude[0] = digit_one;

            do
            {
                digit_two = _rdm.Next(0, 10);
            } while (exclude.Contains(digit_two));
            exclude[1] = digit_two;

            do
            {
                digit_three = _rdm.Next(0, 10);
            } while (exclude.Contains(digit_three));
            exclude[2] = digit_three;

            do
            {
                digit_four = _rdm.Next(0, 10);
            } while (exclude.Contains(digit_four));

            return digit_one * 1000 + digit_two * 100 + digit_three * 10 + digit_four;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanGuessTextbox.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int round = Int16.Parse(button3.Text.Split('.')[0].ToString()) + 1;
            if (round == 2)
            {
                computer_number.set_from_full_numbers(GenerateRandomNo());
                Thread.Sleep(100); // for avoid generate same random int
                human_number.set_from_full_numbers(GenerateRandomNo());
                CompGuessLabel.Text = human_number.get_as_full_number().ToString();
                HumanNegativeTBox.Enabled = true;
                HumanPositiveTBox.Enabled = true;

                int HumanGuess = Int16.Parse(HumanGuessTextbox.Text);
                set_comp_positive_negative_tbox(compare_two_numbers(HumanGuess, computer_number.get_as_full_number()));
                ResultLabel.Text = computer_number.get_as_full_number().ToString();
            }

            if (round == 3)
            {
                computer_number.set_from_full_numbers(GenerateRandomNo());
                human_number.set_from_full_numbers(GenerateRandomNo());
                CompGuessLabel.Text = human_number.get_as_full_number().ToString();
            }

            button3.Text = round.ToString() + ". ROUND";
        }
    }
}
