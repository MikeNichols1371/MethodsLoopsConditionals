using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class MethodsLoopsConditionals
    {
        static void Main(string[] args)
        {
            PosNeg1000();
            ByThree();
            EqualOrNot();
            EvenOrOdd();
            PositiveOrNegative();
            CanYouVote();
            IntegerCheck();
            MultiplicationTable();
        }
            #region Luke Warm 

            public static void PosNeg1000()
            {

                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            public static void ByThree()
            {
                for (int i = 3; i <= 999; i += 3)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            public static void EqualOrNot()
            {
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            var b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("The numbers are equal");
                }   
                else 
                {
                    Console.WriteLine("The numbers are not equal");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            public static void EvenOrOdd()
            {
            Console.WriteLine("Please enter a number");
            var userInput = Convert.ToInt32(Console.ReadLine());
            int num = userInput % 2; 
            var evenOdd = num == 0 ? "The number is even" : "The number is odd";
                Console.WriteLine(evenOdd);
                Console.WriteLine();
                Console.WriteLine();
            }
            public static void PositiveOrNegative()
            {
            Console.WriteLine("Please enter a number");
            var userInput2 = Convert.ToInt32(Console.ReadLine());
            var posNeg = userInput2 > 0 ? "The number is positive" : "The number is negative";
                Console.WriteLine(posNeg);
                Console.WriteLine();
                Console.WriteLine();
             }
            public static void CanYouVote()
            {
            Console.WriteLine("Please enter your age");
            var userInput3 = Convert.ToInt32(Console.ReadLine());
            var age = userInput3;
            var voterAge = age >= 18 ? "You may Vote" : "Too young too vote at this time";
                Console.WriteLine(voterAge);
                Console.WriteLine();
                Console.WriteLine();
            }

        #endregion

        #region
        public static void IntegerCheck()
        {
            Console.WriteLine("Please enter a number to check Integer");
            var userInput4 = Convert.ToInt32(Console.ReadLine());
            var checkInt = (userInput4 >= -10 && userInput4 <= 10) ? "The number is in range" : "The number is not in range";
            Console.WriteLine(checkInt);
        }

        public static void MultiplicationTable()
        {
            Console.WriteLine("Please enter a number to print Multiplication Table");
            var userInput5 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 12; i++)
            {
                var answer = userInput5 * i;
                Console.WriteLine($"{userInput5} * {i} = {answer}");  
            }
        }
          
        #endregion
    }
}
