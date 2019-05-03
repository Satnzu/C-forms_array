using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Array
{
    class taulu
    {
        public int[] taulukko = new int[10];


        public void KokoAsetukset(int koko)
        {
            taulukko = new int[koko];
        }
        public void TungeTavaraa(int indexi, int luku)
        {
            taulukko[indexi] = luku;
        }
    }
}