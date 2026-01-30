using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangszerek
{
    public class Gyujtemeny
    {
        private List<Hangszer> Hangszerek;

        public Gyujtemeny()
        { 
            Hangszerek = new List<Hangszer>();  
        }
        public void Hozzaad(Hangszer h)
        {
            bool vanE = false;
               foreach(var i in Hangszerek)
                if(h.hasonlit(i))
                    vanE = true;

            if (vanE == false)
            {
                Hangszerek.Add(h);
            }


        }
    }
}
