using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_Number
{
    internal class clsRepteadNumber
    {
        public byte targetNumber { get; private set; } = 0;
        public byte totalRounds { get; private set; }
        public byte timerCountdown { get; private set; } = 10;
        public byte currentRound { get; private set; } = 0;
        public byte targetNumberCount { get; private set; } = 0;
        public byte correctAnswersCount { get; private set; } = 0;
        public byte wrongAnswersCount { get; private set; } = 0;
        bool IsGameOver => currentRound > totalRounds;

        public clsRepteadNumber(byte TotalRound) => totalRounds = TotalRound;

        public void SetupNewRound(List<byte> ButtonNumber)
        {
            var random = new Random();
            targetNumber = ButtonNumber[random.Next(0, ButtonNumber.Count)];
            targetNumberCount = (byte)ButtonNumber.Count(num => num == targetNumber);
        }

        public bool SubmitAnswer(byte userAnswer)
        {
            bool isCorrect = userAnswer == targetNumberCount;

            if (isCorrect) correctAnswersCount++;
            else wrongAnswersCount++;

            currentRound++;
            return isCorrect;
        }


        public void RegisterTimeOut()
        {
            wrongAnswersCount++;
            currentRound++;
        }
    }
}
