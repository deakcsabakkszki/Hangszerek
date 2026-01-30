using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangszerek
{
    internal class Hangszer
    {
        protected string nev;
        private string anyag;

        public Hangszer(string nev, string anyag)
        {
            this.nev = nev;
            this.anyag = anyag;
        }
        public void Info()
        {
            Console.WriteLine($"A hangszer neve: {nev}, anyaga: {anyag}");
        }
    }
}
