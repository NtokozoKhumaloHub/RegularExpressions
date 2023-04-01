using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Regex regex = new Regex(@"\d");

            string text = "Hi there, my number is 123344";

            MatchCollection MC = regex.Matches(text);

            Console.WriteLine($"{MC.Count} hits fount:\n {text}");

            foreach (Match m in MC)
            {
                GroupCollection group = m.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }

            */


            /*------------------------------------------------------

            Console.WriteLine("Please enter the Day you were born in this format yyyy-mm-dd");

            string BirthDate = Console.ReadLine();
            DateTime myBirthDay;

            if (DateTime.TryParse(BirthDate, out myBirthDay))
            {
                TimeSpan Daysbetween = DateTime.Now.Subtract(myBirthDay);

                Console.WriteLine($"it has been {Daysbetween} since the day you were born");
            }
            */

            float myfloat = ApplyOperation(4, 5, Add);


            Console.WriteLine(myfloat);

            Console.ReadKey();



        }


        public delegate float OperationDelegate(float P, float A);



        public static float ApplyOperation(float P, float A, OperationDelegate OD)
        {
            return OD(P, A);
        }

        public static float Add(float P, float A)
        {
            return P + A;
        }

        public static float Subtract(float P, float A)
        {
            return P - A;
        }

        public static float Multiply(float P, float A)
        {
            return P + A;
        }

        public static float Divide(float P, float A)
        {
            return P / A;
        }

    }
}
