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
        }
    }
}
