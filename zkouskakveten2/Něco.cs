using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zkouskakveten2
{
    internal class Něco
    {
        public int jídlo { get; set; }
        public int zvíře { get; set; }
        public int Uživatel { get; set; }
        
        public Něco()
        {
            Console.WriteLine("Objekt vytvořen");
        }
        public void info()
        {
            Console.WriteLine($"{jídlo}, {zvíře}, {Uživatel}");
;        }
    }
}
