using System;
using System.Collections.Generic;

namespace Demo

{
    public class demo2
    {
        public static void Main(string[] args)
        {
         List<int> intArr = new List<int>();
         Console.WriteLine("Nhap 10 so");
         for (int i = 0; i < 10; i++)
         {
             int x = Convert.ToInt32(Console.ReadLine());
             intArr.Add(x);
         }
         
         int max = intArr[0];
         foreach (int i in intArr)
         {
             if (max < i)
             {
                 max = i;
             }
                 
         }
         Console.WriteLine("So lon nhat la: " +max);
        }
    }
}