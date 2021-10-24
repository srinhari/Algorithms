using System;
using System.Collections.Generic;
using System.Text;

namespace Pythagoras
{
    public class Solution
    {
        public IList<int> QuickSort(List<int> input)
        {
            if(input == null)
            {
                return null;
            }
            
            return Sort(input);
        }

        private List<int> Sort(List<int> input)
        {
            if (input.Count < 2)
            {
                return input;
            }
            var pivotIndex = input.Count / 2;
            var pivotValue = input[pivotIndex];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> equals = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if(input[i] == pivotValue)
                {
                    equals.Add(input[i]);
                }
                else if (input[i] < pivotValue)
                {
                    left.Add(input[i]);
                }
                else
                {
                    right.Add(input[i]);
                }
            }
            left = Sort(left);
            right = Sort(right);
            left.AddRange(equals);
            left.AddRange(right);
            return left;
        }
    }
}
