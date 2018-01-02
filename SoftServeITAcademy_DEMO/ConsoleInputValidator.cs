using System;
using System.Runtime.Serialization;

namespace SoftServeITAcademy_DEMO
{
    [Serializable]
    [DataContract]
    public class ConsoleInputValidator : IValidatable
    {
        public double GetDoubleInput(string inputQuery, double min, double max)
        {
            Console.WriteLine(inputQuery);

            double inputValue;

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.Write("Enter valid double value: ");
                }
                else if (inputValue < min || inputValue > max)
                {
                    Console.Write($"Enter double in range from {min} to {max}: ");
                }
                else
                {
                    break;
                }
            }

            return inputValue;
        }
    }
}
