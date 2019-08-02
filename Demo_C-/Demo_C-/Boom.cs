using System;
using System.Threading;

namespace Demo_C_
{
    public class Boom
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(Run);
            t.Start();
        }

        public static void Run()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    Console.WriteLine(String.Format("{0:00}", i) +":"+String.Format("{0:00}", j));
                    Thread.Sleep(1000);
                }
            }
        }
    }
}