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
            /*
            int q = 10;
            int korrutis = Funkts.Korrutamine(q, 5);
            Console.WriteLine(korrutis);


            int[,] tabel = new int[10, 10];
            for (int row = 1; row < 11; row++)
            {
                for (int col = 1; col < 11; col++)
                {
                    tabel[row, col] = row * col;
                    Console.Write($"{row * col,4}");
                }
                Console.WriteLine();
            }


            //string slon;
            //do
            //{
            //    Console.WriteLine("Kupi slona");
            //    slon = Console.ReadLine();
            //} while (slon!="slon");

            Array massiiv4;
            massiiv4 = Funkts.Arvud_Massiviisse(4, true);
            int[] massiiv4 = new int[4];
            for (int k = 0; k < massiiv4.Length; k++)
            {
                massiiv4[k] = int.Parse(Console.ReadLine());
            }
            Array.Sort(massiiv4); //1,2....
            int D = 0;
            int t = 0;
            foreach (int item in massiiv4)
            {
                D = (int)(D + item * Math.Pow(10, t));
                t++;
            }
            Console.WriteLine(D);


            //int tryes, ans;
            //tryes = 0;
            //Random rnd = new Random();
            //int number = rnd.Next(1, 10);
            ////Console.WriteLine(number);
            //Console.WriteLine("угадай число от 1 до 10");
            //Console.WriteLine("5 попыток");
            //do
            //{
            //    ans = int.Parse(Console.ReadLine());
            //    if (ans == number)
            //    {
            //        Console.WriteLine("правильно");
            //        break;
            //    }
            //    else if (ans < number)
            //    {
            //        tryes++;
            //        Console.WriteLine("число больше {0} , осталось " + (5 - tryes) + " попыток", ans);

            //    }
            //    else if (ans > number)
            //    {
            //        tryes++;
            //        Console.WriteLine("число меньше {0} , осталось " + (5 - tryes) + "  попыток", ańs);

            //    }
            //} while (tryes < 5);
            //if (tryes == 5)
            //{
            //    Console.WriteLine("попытки кончились");
            //}


            Array arvuD;
            arvuD = Funkts.Arvud_Massiviisse(5, true);
            Funkts.Arvud_Ekraanile(arvuD);
            int summa = 0;
            int korrutis = 1;

            //foreach (int arv in num)
            //{
            //    summa += arv;
            //    korrutis *= arv;
            //}

            //for (k = 0; k < num.Length; k++)
            //{
            //    summa += num[k];
            //    korrutis += num[k];
            //}

            //Console.WriteLine($"Summa= {summa}");
            //Console.WriteLine($"Korrutis= {korrutis}");
            //Console.WriteLine($"Keskmine= {summa/num.Length}");


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

            //Array arvud;
            //arvud = Funkts.Arvud_Massiviisse(10, false);

            //Random rnd = new Random();
            //int[] arvud = new int[10];
            //int i;
            //for (i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(1,100);

            //}

            Array arvud;
            arvud = Funkts.Arvud_Massiviisse(10, false);
            Funkts.Arvud_Ekraanile(arvud);

            Console.WriteLine();
            string[] nimed = new string[5] { "Anna", "Olga", "Mark", "Timur", "Jegor" };
            int a = 0;
            do
            {
                Console.Write("Jrkordne number(tavaline inimene): ");//1,2,3,4,5    
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (a < 1 || a > 5);
            Console.WriteLine(nimed[a - 1]);

            
            Console.ReadLine();*/
        }
    }
}
