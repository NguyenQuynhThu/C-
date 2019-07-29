using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ASM4
{
    public class ManagePhoneBook
    {
        private static PhoneBook _phoneBook = new PhoneBook();
        public static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                ShowMenu();
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        InsertPhone();
                        break;
                    case 2: 
                        RemovePhone();
                        break;
                    case 3: 
                        UpdatePhone();
                        break;
                    case 4: 
                        SearchPhone();
                        break;
                    case 5: 
                        start = false;
                        break;
                        
                }
            }
        }
        
        static void ShowMenu()
        {
            Console.WriteLine("Select function:");
            Console.WriteLine("1. Insert Phone");
            Console.WriteLine("2. Remove Phone");
            Console.WriteLine("3. Update Phone");
            Console.WriteLine("4. Search Phone");
            Console.WriteLine("---------------");
        }
        
        static void InsertPhone()
        {
            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input phone: ");
            string phone = Console.ReadLine();
            
            _phoneBook.InsertPhone(name, phone);
            Console.WriteLine("Insert successfully!");
        }
        
        static void RemovePhone()
        {
            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();
            
            if(_phoneBook.RemovePhone(name))
            {
                Console.WriteLine("Remove successfully!");
            }
            else
            {
                Console.WriteLine("Name not found.");
            }
        }
        
        static void UpdatePhone()
        {
            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input new phone: ");
            string newphone = Console.ReadLine();

            if (_phoneBook.UpdatePhone(name, newphone))
            {
                Console.WriteLine("Update successfully!");
            }
            else
            {
                Console.WriteLine("Name not found.");
            }
        }
        
        static void SearchPhone()
        {
            Console.WriteLine("Input name: ");
            string name = Console.ReadLine();
            
            PhoneNumber result = _phoneBook.SearchPhone(name);
            if (result != null)
            {
                Console.WriteLine("Name: " +result.Name);
                Console.WriteLine("Phone: " +result.Phone);
            }
            else
            {
                Console.WriteLine("Name not found.");
            }
            
        } 
        
    }
}