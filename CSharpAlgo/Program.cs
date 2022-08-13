using System;

namespace CSharpAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 20, b = 25;
            string ifelse = "if else";
            string wlse = "else";
            Console.WriteLine(newstring(ifelse));
            Console.WriteLine(newstring(wlse));
            //Console.WriteLine("result is {0}", response);
            double x = 10;
            double y = 7;
        }
        public static int ComputeSum(int a, int b)
        {
            int sum = 0;
            int result = 0;
            sum = a + b;
            result = sum;
            if (a == b)
            {
                result = 3 * sum;
                return result;
            }
            return result;
        }

        public static int AbsoluteDifference(int n)
        {
            int diff = 0;
            diff =Math.Abs( n - 51);
            if (n > 51) { 
                diff= 3 * diff; 
                return diff;
            }
            return diff;
        }
        public static bool Is30(int a, int b)
        {
            int sum = 0;
            sum = a + b;
            if(a == 30 || b == 30 || sum ==30)
            {
                return true;
            }
            return false;
        }
        public static string newstring(string word)
        {
            string result = "if";
            var response = word.StartsWith("if") ? word : $"if {word}";
            //if (word.StartsWith("if"))
            //{
            //    result = word;
            //    return result;
            //}
            //return result + " " + word;
            return response;
        }
   
        public static void Addition(double x, double y)
        {
            Console.WriteLine($"result is {x+y}");

        }

        public static string Adder(int a, int b)
        {
           int sum = a+ b;
            return $"the sum of two numbers is {sum}";
        }
    }


}
