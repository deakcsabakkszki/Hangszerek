using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangszerek
{

    public class VonosHangszer : Hangszer
    {
        private int hurSzam;
        public VonosHangszer(string nev, string anyag, int hurSzam) : base(nev, anyag)
        {
            this.hurSzam = hurSzam;
        }
        public void hangolas()
        {
            Console.WriteLine($"Hangolandó húrok száma {hurSzam}");
        }
    }
}
