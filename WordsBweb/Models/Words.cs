using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordsBweb.Models
{
    public class Words
    {
        public int WordsID { get; set; }
        public string WordEng { get; set; }
        public string WordPol { get; set; }

        public string Wypisz()
        {
            return "Słowo";
        }
    }
}
