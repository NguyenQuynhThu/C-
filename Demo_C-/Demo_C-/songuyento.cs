using System;

namespace Demo_C_
{
    class Songuyento
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Nhap mot so nguyen bat ky: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to nho hon "+x+" la: ");
            for (int i = 0; i < x; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.WriteLine(i+ " ");
                }
            }
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
            
        }
    }
}


