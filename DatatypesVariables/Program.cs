using System;

namespace DatatypesVariables
{
    class Program
    {
        public class NumberVariables
        {
            /// <summary>
            /// We use summary on top of a method to create a description developers will be able to see when hovering over the method
            /// </summary>
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

        /// <summary>
        /// We use a shortcut for writing the summary sintax just by putting 3 / on top of a method, and our editor will autocomplete
        /// </summary>
        public class StringClass
        {
            public void ManipulatingStrings()
            {
                string myName = "Salome";
                string message = "My name is " + myName;
                Console.WriteLine(message);

                string capsMessage = message.ToUpper();
                Console.WriteLine(capsMessage);

                string lowerMessage = message.ToLower();
                Console.WriteLine(lowerMessage);

                int age = 543;
                Console.WriteLine("String Concatenation");
                Console.WriteLine(message + ", I am " + age + " years old");

                Console.WriteLine("String Formatting");
                Console.WriteLine("Hello, my name is {0}, I am {1} years old", myName, age);

                Console.WriteLine("String Interpolation");
                Console.WriteLine($"Hello, my name is {myName}, I am {age} years old");

                Console.WriteLine("String Verbatim");
                Console.WriteLine(@"Mauris molestie condimentum est, eu tincidunt nunc consequat eu. Morbi iaculis nec dui at pellentesque. Curabitur commodo urna enim, sit amet sollicitudin erat porta sit amet. Etiam vitae ante in sapien pellentesque accumsan tristique a nisi. Sed pretium eu nibh in lacinia. Curabitur et nunc sed sapien imperdiet volutpat. Fusce eget blandit massa. Nullam a tempor ex.

                Nulla accumsan sapien non tellus fringilla, id congue velit auctor. Aliquam vitae odio efficitur, tempus orci non, ornare arcu. 
                Mauris porta elementum ipsum sagittis fringilla. Mauris at tincidunt tellus.");
            }

            public void StringFunctions()
            {
                string firstName = "Clark";
                string lastName = "Kent";
                string fullName = string.Concat(" ", firstName, lastName, " ");
                Console.WriteLine(fullName);
                Console.WriteLine(firstName.Substring(2));
                Console.WriteLine(firstName.ToLower());
                Console.WriteLine(firstName.ToUpper());
                Console.WriteLine(fullName.Trim());
                Console.WriteLine(firstName.IndexOf('r'));
                Console.WriteLine(String.IsNullOrWhiteSpace(firstName));

                //To use special characters inside a string we just have to put a \ before said character
                Console.WriteLine("Some phrase with \"Quotation marks\" and others like \n to insert line break");
                //Use String.Format to save string formatting in variables
                string formatMessage = String.Format("Hello, my name is {0}, and my last name is {1}", firstName, lastName);
                Console.WriteLine(formatMessage);
            }
        }

        public class ValueTypeAndReferenceType
        {
            public void valueVSReference()
            {
                //Data types categorize in two groups based on how they occupy memory location
                Console.WriteLine("VALUE TYPE");
                Console.WriteLine("Store actual data directly");
                Console.WriteLine("Include int, float, long, double, char, bool, decimal, struct, enum");
                Console.WriteLine("Nullable versions available (we can use int?, double?, etc)");
                Console.WriteLine("Can be stored in heap if part of a reference type");

                Console.WriteLine("REFERENCE TYPE");
                Console.WriteLine("Stores the memory location of the actual data");
                Console.WriteLine("Stores the memory reference of the data and not the data itself");
                Console.WriteLine("Includes string, classes, arrays, etc");
                Console.WriteLine("When we copy the reference type it just copies the memory address of the data so we will then have two variables pointing at the same data");
            }
        }

        public class ConsoleClass
        {
            public void consoleClassMethods()
            {
                // Prints and keeps the cursor on the next line
                Console.WriteLine("this is a line with line break");

                // Prints and keeps the cursor on the same line
                Console.Write("this is a line ");
                Console.Write("without line break");

                // Takes a string or integer input and returns its value
                Console.Write("Enter value to get value: ");
                string inputValue = Console.ReadLine();
                Console.WriteLine("Value is {0}", inputValue);

                // Takes a single input of type string and returns its ASCII value
                Console.Write("Enter value to get ASCII: ");
                int asciiValue = Console.Read();
                Console.WriteLine("ASCII value is {0}", asciiValue);

                // Takes a single input of type string and returns its key info
                Console.ReadKey();
            }
        }

        // class names should follow pascal which means like AnyClassName and are usually nouns
        public class NamingConventions
        {
            // method names should follow pascal which means like AnyMethodName
            // method argument names should follow camel case which means like anyArgumentName
            public void MethodName(int numberVariable)
            {
                // variable names should follow camel case which means like anyVariableName
                string variableName = "String";
            }
        }

        public class ImplicitExplicitConversion
        {
            public void Conversions()
            {
                //Implicit conversion
                int numb = 32340329;
                long bigNumb = numb;
                Console.WriteLine(bigNumb);

                float myFloat = 32.76f;
                double myNewDouble = myFloat;
                Console.WriteLine(myNewDouble);

                //Explicit conversion
                double myDouble = 12.432;
                int myInt;
                myInt = (int)myDouble;
                Console.WriteLine(myInt);

                //Type conversion
                string myString = myDouble.ToString();
                Console.WriteLine(myString);

                //Parsing variables
                string stringForFloat = "0.85";
                string stringFotInt = "12345";

                float floatFromString = float.Parse(stringForFloat);
                int intFromString = int.Parse(stringFotInt);
                Console.WriteLine(floatFromString);
                Console.WriteLine(intFromString);

            }
        }


        static void Main(string[] args)
        {
            //NumberVariables numbers = new NumberVariables();
            //numbers.typesOfNumberVariables();

            StringClass strings = new StringClass();
            strings.ManipulatingStrings();
            strings.StringFunctions();

            //ValueTypeAndReferenceType types = new ValueTypeAndReferenceType();
            //types.valueVSReference();

            //ConsoleClass console = new ConsoleClass();
            //console.consoleClassMethods();

            //ImplicitExplicitConversion conversion = new ImplicitExplicitConversion();
            //conversion.Conversions();

            Console.Read();
        }
    }
}
