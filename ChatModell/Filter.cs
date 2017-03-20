using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModell
{
    class Filter
    {
        private List<String> CensoredWords;
        private String[] nachrichtsplit;
        private int nachrichtlength;

        public String pruefen(String nachricht)
        {
            nachrichtsplit = nachricht.Split();
            nachricht = null;
            for(int i = 0; i<=nachrichtsplit.Rank; i++)
            {
                if (nachrichtsplit[i].Equals(CensoredWords))
                {
                    nachrichtlength = nachrichtsplit[i].Length;
                    nachrichtsplit[i].Remove(0, nachrichtlength);
                    nachrichtsplit[i] = "*****";
                }
                nachricht = nachricht + " " + nachrichtsplit[i];
            }
            return nachricht;
        }
    }
}
