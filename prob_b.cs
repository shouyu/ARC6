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
            var arg = Console.ReadLine().Split(' ');
            var line = int.Parse(arg[1]);
            var width = int.Parse(arg[0]);
 
            string[] amida = new string[line];
            for (int i = 0; i < line; i++)
            {
                amida[i] = Console.ReadLine();
            }
 
            string goal = Console.ReadLine();
            int goalpos = goal.IndexOf('o');
 
            int posy = line - 1;
            int posx = goalpos;
 
            while (true)
            {
                if(posy < 0) break;
                int move = 0;
 
                if (posx < (width-1)*2)
                {
                    if (amida[posy][posx+1] == '-')
                        move = 2;
                }
                if (posx > 0)
                {
                    if (amida[posy][posx - 1] == '-')
                        move = -2;
                }
 
                posx += move;
                posy--;
            }
 
            Console.WriteLine(posx / 2 + 1);
        }
    }
}