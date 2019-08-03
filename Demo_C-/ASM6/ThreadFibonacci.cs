using System;
using System.Diagnostics;
using System.Threading;
using System.Xml;

namespace ASM6
{
    public class ThreadFibonacci
    {
        private static bool flag = true;
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Thread t1 = new Thread(FindFibonacci);
            t1.Start(n);
            
            Thread t2 = new Thread(CountTime);
            t2.Start();
        }

        static void FindFibonacci(object o)
        {
            int n = (int) o;
            int[] f = new [] { 0, 1 };
            while(f[1] <= n) 
            {
                Console.Write("{0,-3}", f[1]);    
                f = new[] { f[1], f[0] + f[1] };
                Thread.Sleep(100);
            }
            flag = false;
        }

        static void CountTime()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (flag)
            {
            }
            sw.Stop();
            Console.WriteLine("Thoi gian tinh la: " +sw.Elapsed);

        }
        
        
        
    }
}