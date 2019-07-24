using System;

namespace Demo_C_
//Tim so fibonacci thu n
{
    public class fibonacci
    {
        //ham main chi dam nhan nhap-xuat cua chuong trinh
        static void Main(String[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So fibonacci thu "+n+" la: "+Fibo(n));

        }

        //tach biet cac chuc nang --> viet ra 1 ham khac
        static int Fibo(int n)
        {
            if (n == 1 || n == 2) return 1;
            if (n == 3) return 2;
            int x1 = 1, x2 = 1, x3 = 2;
            for (int i = 4; i <=n; i++)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
            }
            return x3;

        }
    }
}