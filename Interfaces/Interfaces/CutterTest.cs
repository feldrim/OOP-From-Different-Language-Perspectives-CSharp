namespace Interfaces
{
    public class CutterTest
    {
        public static void Main(string[] args)
        {
            var cutterFactory = new CutterFactory();

            for (var i = 0; i < 5; i++)
            {
                var cutter = cutterFactory.CreateCutter();
                cutter.Cut();
            }
        }
    }
}