using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    public class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void Display()
        {
            Console.WriteLine($"Title: { title }");
            Console.WriteLine($"Author: { author }");
            Console.WriteLine($"Price: { price }");
        }
    }
}
