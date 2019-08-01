using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM3
{
    public class News : INews
    {
        public int id;
        public string title;
        public string publicDate;
        public string author;
        public string content;
        public float avgRate;

        public News()
        {
        }

        public News(int id, string title, string publicDate, string author, string content)
        {
            this.id = id;
            this.title = title;
            this.publicDate = publicDate;
            this.author = author;
            this.content = content;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublicDate
        {
            get => publicDate;
            set => publicDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AvgRate
        {
            get => avgRate;
            set => avgRate = value;
        }

        public int this[int index]
        {
            get => rateList[index];
            set
            {
                if (value >= 1 && value <= 5)
                {
                    rateList[index] = value;
                }
                else if (value < 1)
                {
                    rateList[index] = 1;
                }
                else if (value > 5)
                {
                    rateList[index] = 5;
                }
            }
        }
        
        public void Display()
        {
            Console.WriteLine("Title: " +title);
            Console.WriteLine("Publish Date: " +publicDate);
            Console.WriteLine("Author: " +author);
            Console.WriteLine("Content: " +content);
            Console.WriteLine("Average Rate: " +avgRate);
        }
        
        public int[] rateList = new int[3];

        public void Calculate()
        {
            int total = 0;
            foreach (int i in rateList)
            {
                total += i;
            }

            avgRate = (float) total / 3;
        }
    }
} 