using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;

namespace Demo_C_
{
    public class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery = new List<string>();
        
        //Constructor ko co tham so
        public Product()
        {
            
        }
        
        //Constructor day du tham so
        public Product(int id, string name, int price, int qty, string image, string desc, List<string> gallery)
        {
            
        }
        
        //Phuong thuc hien thi thong tin product
        public void GetInfo()
        {
            Console.WriteLine("ID: " +id);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Price: " +price);
            Console.WriteLine("Quantity: " +qty);
            Console.WriteLine("Image: " +image);
            Console.WriteLine("Description: " +desc);
            foreach (string g in gallery) 
            {
                Console.WriteLine("Gallery: "+g);
            }
                
        }
        
        //Phuong thuc thong bao con hang hay het hang
        public void ShowStock()
        {
            if (qty == 0)
            {
                Console.WriteLine(name+ " is out of stock");
            } else
            {
                Console.WriteLine(name+ " is in stock");
            }
            
        }
        
        //Phuong thuc them anh vao gallery (toi da 10 anh)
        public void AddGallery()
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("Galley da du 10 anh. Vui long xoa bot anh truoc khi them.");
                
            }
            else
            {
                string g = Console.ReadLine();
                gallery.Add(g);
            }
        }
        
        //Phuong thuc xoa anh trong gallery
        public void RemoveGallery()
        {
            foreach (string g in gallery)
            {
                Console.WriteLine("Gallery: "+g);
            }
            
            Console.WriteLine("Chon anh muon xoa: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            gallery.RemoveAt(x);
            
        }

        public static void Main(String[] args)
        {
            Product p = new Product();
            p.id = 1;
            p.name = "Tivi";
            p.price = 10000000;
            p.qty = 15;
            p.image = "image.jpeg";
            p.desc = "Samsung 55 inches";
            p.gallery.Add("anh1");
            p.gallery.Add("anh2");
            p.gallery.Add("anh3");
            p.gallery.Add("anh4");
            p.gallery.Add("anh5");
            p.gallery.Add("anh6");
            p.gallery.Add("anh7");
            p.gallery.Add("anh8");
            p.gallery.Add("anh9");
            p.gallery.Add("anh10");
                
            p.GetInfo();
            p.ShowStock();
            p.AddGallery();
            p.RemoveGallery();
            
        }
        
        
    }
}