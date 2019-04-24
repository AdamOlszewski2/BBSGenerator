using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BBSGenerator bbs = new BBSGenerator(7019, 887, 200);
            //BBSGenerator bbs = new BBSGenerator(11, 19, 4);
            List<int> tab = new List<int>();
            int licznik = 0;
            int seria1 = 0;
            int seria2 = 0;
            int seria3 = 0;
            int seria4 = 0;
            int seria5 = 0;
            int seria6 = 0;

            for (int i = 0; i < 20000; i++) {
                tab.Add((int)bbs.getRandomBit());
                Console.Write(tab[i]);
            }

            #region Test jedynek
            foreach (int i in tab) //Test jedynek 9725 < n(1) < 10275
            {
                if (i == 1) licznik++;
            }
            #endregion
            #region Test seria 1
            for (int i = 1; i < tab.Count() - 1; i++) //Testy serii: 1
            {
                if (tab[i] == 1)
                {
                    if (tab[i + 1] == 0)
                    {
                        if (tab[i - 1] == 0)
                        {
                            seria1++;
                        }
                    }
                }
            }
            #endregion
            #region Test seria 2
            for (int i = 1; i < tab.Count() - 2; i++) //Testy serii: 2
            {
                if (tab[i - 1] == 0
                    && tab[i] == 1
                    && tab[i + 1] == 1
                    && tab[i + 2] == 0)
                {
                    seria2++;
                }
            }
            #endregion
            #region Test seria 3
            for (int i = 1; i < tab.Count() - 3; i++) //Testy serii: 2
            {
                if (tab[i - 1] == 0
                    && tab[i] == 1
                    && tab[i + 1] == 1
                    && tab[i + 2] == 1
                    && tab[i + 3] == 0)
                {
                    seria3++;
                }
            }
            #endregion
            #region Test seria 4
            for (int i = 1; i < tab.Count() - 4; i++) //Testy serii: 2
            {
                if (tab[i - 1] == 0
                    && tab[i] == 1
                    && tab[i + 1] == 1
                    && tab[i + 2] == 1
                    && tab[i + 3] == 1
                    && tab[i + 4] == 0)
                {
                    seria4++;
                }
            }
            #endregion
            #region Test seria 5
            for (int i = 1; i < tab.Count() - 5; i++) //Testy serii: 2
            {
                if (tab[i - 1] == 0
                    && tab[i] == 1
                    && tab[i + 1] == 1
                    && tab[i + 2] == 1
                    && tab[i + 3] == 1
                    && tab[i + 4] == 1
                    && tab[i+5] == 0)
                {
                    seria5++;
                }
            }
            #endregion
            #region Test seria 6
            for (int i = 1; i < tab.Count() - 6; i++) //Testy serii: 2
            {
                if (tab[i - 1] == 0
                    && tab[i] == 1
                    && tab[i + 1] == 1
                    && tab[i + 2] == 1
                    && tab[i + 3] == 1
                    && tab[i + 4] == 1
                    && tab[i + 5] == 1
                    && tab[i+6]==0)
                {
                    seria6++;
                }
            }
            #endregion
            #region Wypisywanie danych na wyjscie
            Console.WriteLine("\nTest jedynek: " + licznik);
            Console.WriteLine("Test serii 1: " + seria1);
            Console.WriteLine("Test serii 2: " + seria2);
            Console.WriteLine("Test serii 3: " + seria3);
            Console.WriteLine("Test serii 4: " + seria4);
            Console.WriteLine("Test serii 5: " + seria5);
            #endregion
        }
    }
}
