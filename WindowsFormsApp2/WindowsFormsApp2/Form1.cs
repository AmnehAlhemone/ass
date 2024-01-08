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
    public partial class Form1 : Form
    {
        private int targetNumber;
        private bool gameActive;

        public Form1()
        {
            InitializeComponent();
        }
        private void StartNewGame()
        {
            Random randomNunbers = new Random();
            for(int count = 1; count <= 1000; ++count) 
            {
                int face = randomNunbers.Next(1, 1000);
                Console.Write($"{face}");
            }
            Console.WriteLine();
        }
            private void guessNum_TextChanged(object sender, EventArgs e)
        {
            if (!gameActive)
                return;
            MessageBox.Show("I have a number between 1 and 1000 Can you guess my number? Enter your guess : ");
            int userGuess;
            if (int.TryParse(guessNum.Text, out userGuess))
            {
                if (userGuess == targetNumber)
                {
                    MessageBox.Show("Correct!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gameActive = false;
                    guessNum.Enabled = false;
                    //buttonSubmit.Enabled = false;
                    BackColor = Color.Green;
                }
                else
                {
                    int difference = Math.Abs(targetNumber - userGuess);
                    if (difference < 10)
                    {
                        // labelResult.Text = "Warmer!";
                        BackColor = Color.Red;
                    }
                    else
                    {
                        //labelResult.Text = "Colder!";
                        BackColor = Color.Blue;
                    }
                }
            }
            else
             {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

