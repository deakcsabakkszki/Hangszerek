namespace Hangszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hangszer h = new Hangszer("fuvola", "fa");
            h.Info();
            VonosHangszer g = new VonosHangszer("hegedű", "fa", 4);
            g.Info();
            g.hangolas();

            Console.WriteLine("---------");

            Gyujtemeny gy = new Gyujtemeny();
            gy.Hozzaad2(h);
            gy.Hozzaad2(g);
            gy.Hozzaad2(new Hangszer("fuvola", "fém"));
            gy.Listaz(null);
            


        }
    }
}
