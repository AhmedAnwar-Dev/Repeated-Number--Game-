using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeated_Number_Logic
{
    internal class clsRepteadNumber
    {
        //Start Varibales
        public byte targetNumber { get; private set; } = 0;
        
        // Number of rounds the user chose
        public byte totalRounds { get; private set; }

        // Timer starting value
        public byte timerCountdown = 10;

        public byte currentRound { get; private set; } = 1;

        // How many times the target number is repeated
        public byte targetNumberCount { get; private set; } = 0;
        
        // Count of correct answers entered by the user
        public byte correctAnswersCount { get; private set; } = 0;

        // Count of wrong answers by the user
        public byte wrongAnswersCount { get; private set; } = 0;

        // Determine whether the user has finished (game over)
        public bool IsGameOver => currentRound > totalRounds;
        //End Varibales


        //Start Functions
        private byte _CounterNumberTarget(List<byte> Nums)
        {
            byte Counter = 0;
            foreach (byte Num in Nums)
            {
                if (Num == targetNumber)
                    Counter++;
            }
            return Counter;
        }// Count the target number to use in comparisons

        public clsRepteadNumber(byte TotalRound) => totalRounds = TotalRound;

        public void SetupNewRound(List<byte> ButtonNumber)
        {
            var random = new Random();
            
            // Choose the target number randomly from the button numbers
            targetNumber = ButtonNumber[random.Next(0, ButtonNumber.Count)];

            // Count how many times the target number is repeated
            targetNumberCount = _CounterNumberTarget(ButtonNumber);
        }
        public bool SubmitAnswer(byte userAnswer)
        {
            // Check if the target number count equals the user's input
            bool isCorrect = userAnswer == targetNumberCount;

            if (isCorrect)
            {
                correctAnswersCount++;
                timerCountdown = 10;
            } 
            /*
            We start increasing the number if it is the answer,
            and reset the counter again to move to the next round
            */
            else
            {
                wrongAnswersCount++;
                timerCountdown = 10;
            }

            currentRound++; // Each time this method is called we advance to the next round
            return isCorrect;
        }

       
        public void RegisterTimeOut()
        {
            timerCountdown = 10;
            wrongAnswersCount++;
            currentRound++;
        } // Called when time Round out
        //End Functions

    }
}
