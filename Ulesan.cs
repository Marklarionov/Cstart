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
            int size = 20;
            Random rnd = new Random();
            int[] num = new int[size];
            for (int i = 0; i < size; i++)
            {
                num[i] = rnd.Next(-5, 5);
            }
            Console.WriteLine(num);


            //1
            /*LinkedList<int> alguses = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.AddLast(int.Parse(Console.ReadLine()));
            }
            LinkedList<int>.Enumerator ahel1 = alguses.GetEnumerator();
            while(ahel1.MoveNext())
            {
                Console.WriteLine(ahel1.Current);
            }
            int j = 0;
            foreach (int item in alguses)
            {
                if (j==0)
                {      
                    
                }
                j++;
            }*/
            Console.ReadLine();
        }
    }
}
