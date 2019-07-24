using System;

namespace Demo_C_
//Tim so fibonacci thu n
{
    public class fibonacci
    {
        public static void Main(String[] args)
        {
         Console.WriteLine("Nhap so thu tu so fibonacci muon hien thi: ");
         int n = Convert.ToInt32(Console.ReadLine());
         int x1 = 0;
         int x2 = 1;
         int x = 1;

         for (int i = 3; i <= n; i++)
         {
             x = x1 + x2;
             x1 = x2;
             x2 = x;
         }
         
         Console.WriteLine("So fibonacci thu "+n+ " la: " +x);
        }
        
    }
}