using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Demo_C_
{
    public abstract class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product()
        {
        }

        public Product(int id, string name, decimal price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc; 
            this.gallery = new List<string>();
            
        }

        //Hien thi thong tin product
        public virtual void GetInfo()//them virtual de override o lop Shoe
        {
            Console.WriteLine("ID: " +id);
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Price: " +price);
            Console.WriteLine("Quantity: " +qty);
            Console.WriteLine("Image: " +image);
            Console.WriteLine("Description: " +desc);
            foreach (string s in gallery)
            {
                Console.WriteLine(s);
            }
        }

        //Kiem tra xem con hang hay khong
        public bool CheckQty()
        {
            if (qty > 0)
            {
                return true;
            }

            return false;
        }

        //Them anh vao gallery: Cach 1 --> Co tinh ung dung cao hon 
        public bool AddGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
                return true;
            }

            Console.WriteLine("Qua so anh cho phep");
            return false;
        }
        
        //Them anh vao gallery: Cach 2
        public void AddGallery2()
        {
            if (gallery.Count > 10)
            {
                string img = Console.ReadLine();
                gallery.Add(img);
                return;
            }
            Console.WriteLine("Qua so anh cho phep");
            return;
        }
        
        //Xoa anh khoi gallery: Cach 1
        public bool RemoveGallery(int n)
        {
            if (n < gallery.Count)
            {
                gallery.RemoveAt(n);
                return true;
            }

            Console.WriteLine("Khong tim thay anh hoac khong the xoa.");
            return false;
        }

        //Xoa anh khoi gallery: Cach 2
        public void RemoveGallery2()
        {
            int i = 0;
            foreach (string s in gallery)
            {
                Console.WriteLine(i+". " +s);
                i++;
            }

            Console.WriteLine("Nhap vi tri anh muon xoa");
            int n = Convert.ToInt16(Console.ReadLine());
            gallery.RemoveAt(n);
        }

        public abstract void TinhTien();

        public string this[int index]
        {
            get { return gallery[index]; }
            set { gallery[index] = value; }
        }

        public virtual void TinhTien2()
        {
            Product p = new Product();
            
        }

    }
}