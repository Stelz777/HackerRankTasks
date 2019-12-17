using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(string title, String author)
        {
            this.title = title;
            this.author = author;
        }

        public abstract void Display();
    }
}
