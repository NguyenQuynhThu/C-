using System;
using System.Collections.Generic;

namespace Demo_C_
{
    class Program
    {
        public static int age;
        public int year;
        public const int day = 7;
        
        static void Main(string[] args)
        {
            int x;
            string a;
            a = Console.ReadLine();
            x = Convert.ToInt32(Console.ReadLine());

            double y;
            y = Convert.ToDouble(Console.ReadLine());
            
            if (x >= 10)
            {
                Console.WriteLine(x+" > 10");   
            }
            else
            {
                Console.WriteLine(x+" < 10");
            }
            Console.WriteLine(a);
            
            List<int> intArr = new List<int>();
            intArr.Add(item:2);
            intArr.Add(item:3);
            intArr.Add(item:4);
            
            List<string> strArr = new List<string>();
            strArr.Add(item:"Hello");
            strArr.Add(item:"World");
            strArr.Add(item:"Everyone");

            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }
            
        }
    }
}