using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<int> stacks = new List<int>();
            for (int i = 0; i < length; i++)
            {
                int box = int.Parse(Console.ReadLine());
                int index = -1;
                for (int j = 0; j < stacks.Count; j++)
                {
                    if (stacks[j] >= box)
                    {
                        if (index == -1) index = j;
                        else
                        {
                            if (stacks[j] < stacks[index]) index = j;
                        }
                    }
                }
                if (index == -1) stacks.Add(box);
                else stacks[index] = box;
            }
 
            Console.WriteLine(stacks.Count);
        }
    }
}