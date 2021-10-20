using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World Again!");


            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A'; //char uses single quotes
            string firstName = "Moira"; //string uses double quotes
            bool isWorking = true;
            //all of these variables can also be declared using var and Studio Code will detect the type-? however all numbers will default to integer type which is gererally safe to use

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            //NOTES
            //run with control +F5
            // to build an application command + B
            //type cw then tab(twice) to get the console.writeline
            //hovering over key words and using command + click opens the Assembly Browser
            //command +x deletes a line
            //templates are placed within curly braces and double quotes
            //to generate try catch blcok press try and click enter


            //CONVERSION EXAMPLES with Excplicit and non casting
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            try
            {
                var number2 = "1234";
                byte b = Convert.ToByte(number2);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool boo = Convert.ToBoolean(str);
                Console.WriteLine(boo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The string could not be converted to a boolean");
            }

        }
    }
}
  