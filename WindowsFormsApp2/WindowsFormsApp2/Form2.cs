using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private int targetNumber;
        private const int MinNumber = 1;
        private const int MaxNumber = 1000;
        private bool gameActive;
      
        public Form2()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {

            Random random = new Random();
            targetNumber = random.Next(MinNumber, MaxNumber + 1);
            gameActive = true;

            textBoxGuess.Enabled = true;
            buttonSubmit.Enabled = true;
            textBoxGuess.Text = "";
            BackColor = DefaultBackColor;

        }

     
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            int userGuess;
            if (int.TryParse(textBoxGuess.Text, out userGuess))
            {
                if (userGuess == targetNumber)
                {
                    label1.Text = "Correct!";
                    this.BackColor = Color.Green;
                    textBoxGuess.Enabled = false;
                    buttonSubmit.Enabled = false;
                }
                else
                {
                    if (userGuess > targetNumber)
                    {
                        label1.Text = "Too High,try another number";
                        this.BackColor = Color.Blue;
                        label1.Enabled = true;
                    }
                    else
                    {
                        label1.Text = "Too Low, try another number";
                        this.BackColor = Color.Red;
                        label1.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
    }

