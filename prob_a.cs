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
            var nums = Console.ReadLine().Split(' ');
            var bonus = Console.ReadLine();
            var mynums = Console.ReadLine().Split(' ');
 
            bool hasBonus = false;
            int res = 0;
 
            foreach (var num in nums)
            {
                foreach (var mynum in mynums)
                {
                    if (num == mynum) res++;
                    if (mynum == bonus) hasBonus = true;
                }
            }
 
            switch (res)
            {
                case 3: Console.WriteLine("5"); break;
                case 4: Console.WriteLine("4"); break;
                case 5: 
                    if(hasBonus) Console.WriteLine("2");
                    else Console.WriteLine("3"); break;
                case 6: Console.WriteLine("1"); break;
                default: Console.WriteLine("0"); break;
            }
        }
    }
}