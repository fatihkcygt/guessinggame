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

namespace GuessingGame.View
{
    internal partial class Form1 : Form, View.IMindNumbersView
    {
        
        public Presenter.MindnumberPresenter Presenter
        { private get; set; }

        public int HumanGuess
        {
            get { return Int16.Parse(this.HumanGuessTextbox.Text); }
            set { this.HumanGuessTextbox.Text = value.ToString(); }
        }
        public int HumanPositive
        {
            get { return Int16.Parse(this.HumanPositiveBox.Value.ToString()); }
            set { this.HumanPositiveBox.Value = value; }
        }
        public int HumanNegative
        {
            get { return Int16.Parse(this.HumanNegativeBox.Value.ToString()); }
            set { this.HumanNegativeBox.Value = value; }
        }
        public int CompGuess
        {
            get 
            {
                try
                {
                    return Int16.Parse(this.CompGuessLabel.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set { this.CompGuessLabel.Text = value.ToString(); }
        }
        public int Comppositive
        {
            get { return Int16.Parse(this.CompPositiveTBox.Text); }
            set { this.CompPositiveTBox.Text = value.ToString(); }
        }
        public int CompNegative
        {
            get { return Int16.Parse(this.CompNegativeTbox.Text); }
            set { this.CompNegativeTbox.Text = value.ToString(); }
        }

        public string Result
        {
            get { return this.ResultLabel.Text; }
            set { this.ResultLabel.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanGuessTextbox.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Presenter.reset_game();
            button3.Text = "1. ROUND";
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int round = Int16.Parse(button3.Text.Split('.')[0].ToString()) + 1;
            if (Presenter.process())
            {
                Presenter.reset_game();
            }
            button3.Text = round.ToString() + ". ROUND";
        }

        private void HumanGuessTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '0') & ((sender as TextBox).Text.Length == 0) & e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else if ((!char.IsDigit(e.KeyChar) || ((TextBox)sender).Text.Contains(e.KeyChar)) & e.KeyChar != (char)8)
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
