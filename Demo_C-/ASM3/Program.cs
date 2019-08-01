using System;
using System.Collections.Generic;

namespace ASM3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<News> listNews = new List<News>();

            bool start = true;
                
            while (start)
            {
                ShowMenu();
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertNews(listNews);
                        break;
                    case 2: 
                        AvgAndView(listNews);
                        break;
                    case 3: 
                        AvgAndView(listNews, true);
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
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------");
        }

        static void InsertNews(List<News> listNews)
        {
            Console.WriteLine("ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Publish Date:");
            string publicDate = Console.ReadLine();
            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Content:");
            string content = Console.ReadLine();
            
            News ns = new News(id, title, publicDate, author, content);
            Console.WriteLine("Rate:");
            for (int i = 0; i < 3; i++)
            {
                ns[i] = Convert.ToInt32(Console.ReadLine());
            }
            listNews.Add(ns);
        }

//        static void ListNews(List<News> listNews)
//        {
//            foreach (News news in listNews)
//            {
//             news.Display();   
//            }
//        }
//
//        static void AvgRate(List<News> listNews)
//        {
//            foreach (News news in listNews)
//            {
//                news.Calculate();
//                news.Display();
//            }
//        }

        static void AvgAndView(List<News> listNews, bool func = false)
        {
            foreach (News news in listNews)
            {
                if (func)
                {
                    news.Calculate();
                }
                news.Display();
            }
        }
    }
}