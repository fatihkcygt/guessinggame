namespace GuessingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.HumanGuessLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.HumanGuessTextbox = new System.Windows.Forms.TextBox();
            this.CompGuessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CompNegativeTbox = new System.Windows.Forms.TextBox();
            this.CompPositiveTBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.HumanPositiveBox = new System.Windows.Forms.NumericUpDown();
            this.HumanNegativeBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HumanPositiveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanNegativeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HumanGuessLabel
            // 
            this.HumanGuessLabel.AutoSize = true;
            this.HumanGuessLabel.Location = new System.Drawing.Point(132, 184);
            this.HumanGuessLabel.Name = "HumanGuessLabel";
            this.HumanGuessLabel.Size = new System.Drawing.Size(37, 13);
            this.HumanGuessLabel.TabIndex = 1;
            this.HumanGuessLabel.Text = "Guess";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(672, 13);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // HumanGuessTextbox
            // 
            this.HumanGuessTextbox.Enabled = false;
            this.HumanGuessTextbox.Location = new System.Drawing.Point(99, 200);
            this.HumanGuessTextbox.MaxLength = 4;
            this.HumanGuessTextbox.Name = "HumanGuessTextbox";
            this.HumanGuessTextbox.Size = new System.Drawing.Size(112, 20);
            this.HumanGuessTextbox.TabIndex = 3;
            this.HumanGuessTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HumanGuessTextbox_KeyPress);
            // 
            // CompGuessLabel
            // 
            this.CompGuessLabel.AutoSize = true;
            this.CompGuessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompGuessLabel.Location = new System.Drawing.Point(609, 194);
            this.CompGuessLabel.Name = "CompGuessLabel";
            this.CompGuessLabel.Size = new System.Drawing.Size(40, 25);
            this.CompGuessLabel.TabIndex = 6;
            this.CompGuessLabel.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Number Is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "+";
            // 
            // CompNegativeTbox
            // 
            this.CompNegativeTbox.Enabled = false;
            this.CompNegativeTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompNegativeTbox.Location = new System.Drawing.Point(175, 253);
            this.CompNegativeTbox.Name = "CompNegativeTbox";
            this.CompNegativeTbox.Size = new System.Drawing.Size(50, 30);
            this.CompNegativeTbox.TabIndex = 11;
            // 
            // CompPositiveTBox
            // 
            this.CompPositiveTBox.Enabled = false;
            this.CompPositiveTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompPositiveTBox.Location = new System.Drawing.Point(81, 253);
            this.CompPositiveTBox.Name = "CompPositiveTBox";
            this.CompPositiveTBox.Size = new System.Drawing.Size(50, 30);
            this.CompPositiveTBox.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "1. ROUND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(351, 79);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 15;
            // 
            // HumanPositiveBox
            // 
            this.HumanPositiveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanPositiveBox.Location = new System.Drawing.Point(559, 253);
            this.HumanPositiveBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HumanPositiveBox.Name = "HumanPositiveBox";
            this.HumanPositiveBox.Size = new System.Drawing.Size(38, 30);
            this.HumanPositiveBox.TabIndex = 16;
            // 
            // HumanNegativeBox
            // 
            this.HumanNegativeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanNegativeBox.Location = new System.Drawing.Point(658, 253);
            this.HumanNegativeBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HumanNegativeBox.Name = "HumanNegativeBox";
            this.HumanNegativeBox.Size = new System.Drawing.Size(37, 30);
            this.HumanNegativeBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HumanNegativeBox);
            this.Controls.Add(this.HumanPositiveBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CompNegativeTbox);
            this.Controls.Add(this.CompPositiveTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompGuessLabel);
            this.Controls.Add(this.HumanGuessTextbox);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.HumanGuessLabel);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.HumanPositiveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanNegativeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HumanGuessLabel;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.TextBox HumanGuessTextbox;
        private System.Windows.Forms.Label CompGuessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CompNegativeTbox;
        private System.Windows.Forms.TextBox CompPositiveTBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.NumericUpDown HumanPositiveBox;
        private System.Windows.Forms.NumericUpDown HumanNegativeBox;
    }
}

