using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangszerek
{
    public class Hangszer
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
        public bool hasonlit(Hangszer h2)
        {
            if(this.nev==h2.nev)
                return true;
            else return false;
        }

        public override bool Equals(object? obj)
        {
            return this.nev==((Hangszer)obj).nev;
        }

        public bool anyagegyezes(string h3)
        {
            if (this.anyag == h3)
                return true;
            else return false;
        }
    }
}
