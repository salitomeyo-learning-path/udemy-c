using System;

namespace DatatypesAndVariables
{
    class Program
    {
        class NumberVariables
        {
            public void typesOfNumberVariables()
            {
                int number1;
                number1 = 1;

                int number2 = 2;
                int sum = number1 + number2;
                Console.WriteLine("number 1: " + number1 + " + number 2: " + number2 + " is " + sum);

                int number3, number4, number5;

                double d1 = 3.14159;
                double d2 = 2.34;
                double dDiv = d1 / d2;
                Console.WriteLine("d1/d2 is " + dDiv);

                float f1 = 3.14159f;
                float f2 = 2.34f;
                float fDiv = f1 / f2;
                Console.WriteLine("f1/f2 is " + fDiv);

                long number = 324872384273;
                Console.WriteLine("long is " + number);

                double dobIntDiv = d1 / number2;
                // cant implicitly cast a double division in an int variable
                //int dobIntDivInt = d1 / number2;
                Console.WriteLine("d1/number2 is " + dobIntDiv);
            }
        }

        public class Strings
        {
            public void manipulatingStrings()
            {
                string myName = "Salome";
                string message = "My name is " + myName;
                Console.WriteLine(message);

                string capsMessage = message.ToUpper();
                Console.WriteLine(capsMessage);

                string lowerMessage = message.ToLower();
                Console.WriteLine(lowerMessage);
            }
        }
        static void Main(string[] args)
        {
            NumberVariables numbers = new NumberVariables();
            numbers.typesOfNumberVariables();

            Strings strings = new Strings();
            strings.manipulatingStrings();

            Console.Read();
        }
    }
}
