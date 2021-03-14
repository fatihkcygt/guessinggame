using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuessingGame.Presenter
{
    public class MindnumberPresenter
    {
        private readonly View.IMindNumbersView _view;

        public List<string> possible_numbers_as_string = new List<string> { };
        public int computer_in_mind_number = 0;

        public MindnumberPresenter(View.IMindNumbersView view)
        {
            _view = view;
            view.Presenter = this;
            fill(possible_numbers_as_string);
        }

        /// <summary>
        /// Fill possible numbers to guessing and add list of possible_numbers_as_string.
        /// 9*9*8*7 Combination. So count equal to 4536.
        /// </summary>
        public void fill(List<string> PossibleList)
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
                            PossibleList.Add(cnt);
                        }
                    }
                }
            }
            computer_in_mind_number = GenerateFromPossibleList();
        }

        /// <summary>
        /// Check whole list and remove Possible list.
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

        /// <summary>
        /// Set to Comppositive and CompNegative values.
        /// </summary>
        /// <param name="val1">value</param>
        public void set_comp_positive_negative_tbox(string value)
        {
            _view.Comppositive = Int16.Parse(value.Split(',')[0].ToString());
            _view.CompNegative = Int16.Parse(value.Split(',')[1].ToString());
        }

        /// <summary>
        /// Generate random number from Possible List.
        /// </summary>
        public int GenerateFromPossibleList()
        {
            Thread.Sleep(200); //  for avoid generate same random int
            Random _rdm = new Random();
            int index_of_array = _rdm.Next(0, possible_numbers_as_string.Count);
            try
            {
                return Convert.ToInt16(possible_numbers_as_string[index_of_array]);
            }
            catch
            {
                _view.Result = "You entered wrong data \n for positive negative values. \n Please click 'New Game'";
                return 0;
            }
        }

        /// <summary>
        /// Main Process.
        /// </summary>
        public Boolean process()
        {
            set_comp_positive_negative_tbox(compare_two_numbers(_view.HumanGuess, computer_in_mind_number));
            if (possible_numbers_as_string.Count == 1 || _view.HumanPositive == 4)
            {
                _view.Result = "COMPUTER WIN";
                return true;
            }
            else if (_view.HumanGuess == computer_in_mind_number)
            {
                _view.Result = "YOU WIN";
                return true;
            }

            if (_view.CompGuess != 0)
            {
                for (int j = 0; j < possible_numbers_as_string.Count; j++)
                {
                    if (!check(possible_numbers_as_string.ElementAt(j), _view.CompGuess.ToString(), _view.HumanNegative, _view.HumanPositive))
                    {
                        possible_numbers_as_string.RemoveAt(j);
                        j--;
                    }
                }
            }

            _view.CompGuess = GenerateFromPossibleList();

            return false;
        }

        /// <summary>
        /// Rest when want to new game.
        /// </summary>
        public void reset_game()
        {
            _view.Result = "";
            _view.Comppositive = 0;
            _view.CompNegative = 0;
            _view.CompGuess = 0;
            _view.HumanGuess = 0;
            _view.HumanNegative = 0;
            _view.HumanPositive = 0;
            fill(possible_numbers_as_string);
        }


    }
}
