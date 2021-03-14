using System.Collections.Generic;

namespace GuessingGame.View
{
    public interface IMindNumbersView
    {
        int HumanGuess { get; set; }
        int HumanPositive { get; set; }
        int HumanNegative { get; set; }
        int CompGuess { get; set; }
        int Comppositive { get; set; }
        int CompNegative { get; set; }

        string Result { get; set; }

        Presenter.MindnumberPresenter Presenter { set; }
    }
}
