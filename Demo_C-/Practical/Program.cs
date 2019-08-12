using System;
using System.Collections.Generic;

namespace Practical
{
    class Program
    {
        static List<Product> productList = new List<Product>();
        static void Main(string[] args)
        {
            bool start = true;
                
            while (start)
            {
                ShowMenu();
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2: 
                        Display();
                        break;
                    case 3: 
                        Delete();
                        break;
                    case 4: 
                        start = false;
                        break;
                }
                
            }
            
        }
        
        static void ShowMenu()
        {
            Console.WriteLine("SELECT FUNCTION");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------");
        }
        
        static void AddProduct()
        {
            Console.WriteLine("Product ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            
            Product p = new Product(id, name, price);
            productList.Add(p);
        }

        static void Display()
        {
            Console.WriteLine("| {0, -13} | {1, -13} | ${2, -13} |","Produc ID", "Product Name", "Price");
            foreach (Product p in productList)
            {
                Console.WriteLine("| {0, -13} | {1, -13} | ${2, -13} |",p.Id, p.Name, p.Price);
            }
        }

        static void Delete()
        {
            Console.WriteLine("Nhap ID san pham muon xoa:");
            int id = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            
            foreach (Product p in productList)
            {
                if (id == p.Id)
                {
                    productList.Remove(p);
                    Console.WriteLine("Xoa san pham thanh cong.");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Khong tim thay san pham muon xoa.");
            }
        }

    }
}