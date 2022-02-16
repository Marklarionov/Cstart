using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstart
{
    class Loendid
    {
        static void Main(string[] args)
        {



            Dictionary<int, string> opilased = new Dictionary<int, string>(6);
            opilased.Add(74589, "Mihhail");
            opilased.Add(74590, "Aleksandr");
            opilased.Add(74591, "Edgar");
            opilased.Add(74592, "Daniil");
            opilased.Add(74593, "Alina");
            opilased.Add(74594, "Mark");
            string nimi = opilased[74590];
            opilased[74590] = "Aleksander";
            foreach (KeyValuePair<int,string> keyValue in opilased)
            {
                Console.WriteLine(keyValue.Key+"-"+keyValue.Value);
            }



            LinkedList<string> loetelu = new LinkedList<string>();
            loetelu.AddLast("Kass");
            loetelu.AddLast("Koer");
            loetelu.AddFirst("Hund");
            LinkedList<string>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.ReadLine();

            /*List<Inimesed> inimesed = new List<Inimesed>();
            inimesed.Add(new Inimesed() { Nimi = "Mati" });
            inimesed.Add(new Inimesed() { Nimi = "Kati" });
            inimesed.Add(new Inimesed() { Nimi = "Mark" });
            foreach (Inimesed inimene in inimesed)
            {
                Console.Write(inimene.Nimi+", ");
            }



            List<int> numbrid = new List<int>();
            numbrid.Add(100);
            for (int i = 0; i < 9; i++)
            {
                numbrid.Add(i + 1);
            }*/
        }
    }
}
