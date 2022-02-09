using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cstart
{
    class Masiivid
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int k;
            for (k = 0; k < num.Length; k++)
            {
                num[k] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            int korrutis = 1;

            //foreach (int arv in num)
            //{
            //    summa += arv;
            //    korrutis *= arv;
            //}

            for (k = 0; k < num.Length; k++)
            {
                summa += num[k];
                korrutis += num[k];
            }

            Console.WriteLine($"Summa= {summa}");
            Console.WriteLine($"Korrutis= {korrutis}");
            Console.WriteLine($"Keskmine= {summa/num.Length}");


            //Random rnd = new Random();
            //int N = rnd.Next(1, 100);
            //int M = rnd.Next(1, 100);
            //Console.WriteLine("N=", N);//2
            //Console.WriteLine("M=", M);//6
            //if (N>M)
            //{
            //    int abi = N;
            //    N = M;
            //    M = abi;
            //}

            //int[] NM = new int[M - N + 1];//2,3,4,5,6
            //for (int j = N; j < M+1; j++)//N=2
            //{
            //    NM[j-N] = j;
            //    Console.WriteLine(j* j);//^2, Math.Power(NM[j-N],2)
            //}


            //Random rnd = new Random();
            //int[] arvud = new int[10];
            //int i;
            //for (i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(1,100);

            //}
            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv,4}"); //{arv,(колличество символов)}
            //}
            //Console.WriteLine();
            //string[] nimed = new string[5] {"Anna","Olga","Mark","Timur","Jegor"};
            //int a = 0;
            //do
            //{
            //    Console.Write("Jrkordne number(tavaline inimene): ");//1,2,3,4,5    
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //} while (a < 1 || a > 5);
            //Console.WriteLine(nimed[a-1]);


            Console.ReadLine();
        }
    }
}
