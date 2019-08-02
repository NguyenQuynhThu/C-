using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Demo_C_
{
    public delegate void ChangeCart(string s);
    public class Cart
    {
        public int id;
        public string customer;
        public decimal grandTotal;
        public List<Product> productList;
        public string city;
        public string country;
        
        public event ChangeCart Alert ;

        private void Notify(string s)
        {
            Console.WriteLine(s);
        }

        //Phuong thuc them san pham vao gio hang
        public bool AddProduct(Product p)
        {
            if (!productList.Contains(p) && p.CheckQty())
            {    
                productList.Add(p);
                p.qty--;
                grandTotal += p.price;
                if (Alert == null)
                {
                    Alert += Notify;
                }
                Alert("New product was added.")
                Alert("Quality has changed.")
                Alert("Grand total has changed.")
                return true;
            }
            Alert("Already added.");
            return false;
        }

        //Phuong thuc xoa 1 san pham khoi gio hang
        public bool RemoveProduct(Product p)
        {
            if (productList.Contains(p))
            {
                productList.Remove(p);
                p.qty++;
                grandTotal -= p.price;
                return true;
            }
            Console.WriteLine("San pham khong co trong gio hang");
            return false;
        }
         
        //Phuong thuc tinh tong tien
        public decimal GetGrandTotal()
        {
            decimal finalTotal;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finalTotal = grandTotal * (decimal) 1.01;
                }
                else
                {
                    finalTotal = grandTotal * (decimal) 1.02;
                }
            }
            else
            {
                finalTotal = grandTotal * (decimal) 1.05;
            }
        }
        
        

    }
}