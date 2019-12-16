using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    public class Person
    {
        #region ClassVsInstance
        //https://www.hackerrank.com/challenges/30-class-vs-instance/problem

        protected string firstName;
        protected string lastName;
        protected int id;
        
        public int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public Person(int initialAge)
        {
            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }

        public void PrintAge()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public string CalculateAge(int age)
        {
            if (age < 13)
            {
                return "You are young.";
            }
            else if (age >= 13 && age < 18)
            {
                return "You are a teenager.";
            }
            else
            {
                return "You are old.";
            }
        }

        public void IncrementAge()
        {
            age++;
        }

        #endregion
    }
}
