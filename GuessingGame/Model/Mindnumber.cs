using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.Model
{
    public class Mindnumber
    {
        public int HumanGuess { get; set; }
        public int HumanPositive { get; set; }
        public int HumanNegative { get; set; }
        public int CompGuess { get; set; }
        public int Comppositive { get; set; }
        public int CompNegative { get; set; }
    }
}
