﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks._30_Days_of_Code
{
    //https://www.hackerrank.com/challenges/30-scope/problem
    public class Difference
    {
        private int[] elements;

        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void ComputeDifference()
        {
            maximumDifference = Math.Abs(elements.Max() - elements.Min());
        }
    }
}
