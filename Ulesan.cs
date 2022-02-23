using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstart
{
    class Ulesan
    {
        static void Main(string[] args)
        {



            //1
            List<int> alguses = new List<int>();
            List<int> lopus = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.Add(int.Parse(Console.ReadLine()));
            }
            int a1 = alguses[0];
            int an = alguses[alguses.Count - 1];
            alguses.Insert(0, an);
            alguses.Add(a1);
            
            //2
            Random rnd = new Random();
            LinkedList<int> nums = new LinkedList<int>();
            for (int i = 0; i < 20; i++)
            {
                int arv = rnd.Next(1, 50);
                int newnums = arv % 2;
                if (newnums == 0)
                {
                    nums.AddFirst(arv);
                }
                else
                {
                    nums.AddLast(arv);
                }
            }
            foreach (int arv in nums)
            {
                Console.Write(arv + " ");
            }

            Console.ReadLine();
        }
    }
}
