using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    //https://www.hackerrank.com/challenges/30-inheritance/problem
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        public char Calculate()
        {
            double average = testScores.Average();
            if (average >= 90 && average <= 100)
            {
                return 'O';
            }
            else if (average >= 80 && average < 90)
            {
                return 'E';
            }
            else if (average >= 70 && average < 80)
            {
                return 'A';
            }
            else if (average >= 55 && average < 70)
            {
                return 'P';
            }
            else if (average >= 40 && average < 55)
            {
                return 'D';
            }
            else if (average < 40)
            {
                return 'T';
            }
            return '\x0000';
        }
    }
}
