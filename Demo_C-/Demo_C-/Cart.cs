using System;
using System.Collections.Generic;

namespace Demo_C_
{
    public class Cart
    {
        public int id;
        public string customer;
        public int grandTotal;
        public List<Product> productList = new List<Product>();
        public string city;
        public string country;
        
        //Phuong thuc them san pham vao gio hang
        public void AddProduct()
        {
            Product p = new Product();
            p.id = Convert.ToInt32(Console.ReadLine());
            p.name = Console.ReadLine();
            p.price = Convert.ToInt32(Console.ReadLine());
            p.qty = Convert.ToInt32(Console.ReadLine());
            p.image = Console.ReadLine();
            p.desc = Console.ReadLine();
            string g1 = Console.ReadLine();
            string g2 = Console.ReadLine();
            p.gallery.Add(g1);
            p.gallery.Add(g2);

            productList.Add(p);

        }
        
        //Phuong thuc xoa 1 san pham khoi gio hang
        public void RemoveProduct()
        {
            Console.WriteLine("Xoa san pham co ID la: ");
            int x = Convert.ToInt32(Console.ReadLine());
            foreach (Product product in productList)
            {
                if (product.id == x)
                {
                    productList.Remove(product);
                }
            }

        }
        
        //Phuong thuc tinh tong tien
        public int GrandTotal()
        {
            int total;
            if (city = "Ha Noi" || city = "Ho Chi Minh")
            {
                return grandTotal = total + total * 1 %;
            } else if (city =! "Viet Nam")
            {
                return grandTotal = total + total * 5 %;   
            }
            else 
            {
                return grandTotal = total + total * 2 %;
            }
            Console.WriteLine("Grand Total = " +grandTotal);
        }

    }
}