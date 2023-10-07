using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace halott
{
    class Program
    {
        struct alak
        {
          public  string nev;
          public  int helyezes;
          public  double tavolsag;
           public bool sikerult;
        }

        static void Main(string[] args)
        {
            string[] fajbol = File.ReadAllLines("bevitel.txt");
            List<alak> maraton = new List<alak>();
            alak seged = new alak();


            for(int i = 0;i<fajbol.Length;i++)
            {
                string[] darabol = fajbol[i].Split(';');
                seged.nev = darabol[0];
                seged.helyezes =Convert.ToInt32(darabol[1]);
                seged.tavolsag = Convert.ToDouble(darabol[2]);
                seged.sikerult = Convert.ToBoolean(darabol[3]);
                maraton.Add(seged);
            }
            Console.WriteLine($"\n A futok száma: {maraton.Count}");
            Console.Write("Kérek a futo helyezésétt.: ");
            int heleztk = Convert.ToInt32(Console.ReadLine());
            int k =maraton.Count;
            int m = 0;
            while (maraton[m].helyezes != heleztk || maraton.Count < m)
            {
                m++;
            }
            if (maraton[m].helyezes ==heleztk)
            {
                Console.WriteLine("Van ilyen helyezés");
            }
            else
            {
                Console.WriteLine("Nincs ilyen helyezés");
            }
            Console.Write("Kérek egy számott 1-től 9-ig : ");
            int woolf = Convert.ToInt32(Console.ReadLine());
            int mi = 0;
            int helyet = 0;
            for (int i = 0; i < maraton.Count; i++)
            {
                if (woolf == maraton[i].helyezes)
                {
                    helyet = maraton[i].helyezes;
                }
                else
                {
                    mi = maraton[i].helyezes;
                }
            }
            Console.WriteLine($"Az keresés értéke {helyet} igaz vagy {mi} hamis");
            Console.ReadKey();
        }
    }
}
