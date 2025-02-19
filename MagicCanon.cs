using System.Windows.Markup;
/*
namespace MagicCanon 
{
    public class ConsolasWall
    {
        private int crankTurns = -1;
        private string  blast = "n/a";
        private string blastColor = "n/a";

        public  int CrankTurns
        {
            get { return this.crankTurns;}
            set { this.crankTurns = value;}
        }

        public string Blast
        {
            get {return this.blast;}
            set {this.blast = value;}
        }
         public string BlastColor 
         {
            get {return this.blastColor;}
            set {this.blastColor = value;}
         }
         public ConsolasWall (): this (-1,"n/a","n/a"){}
         public ConsolasWall(int _crankTurns, string _blast, string _blastColor)
         {
            this.CrankTurns = _crankTurns;
            this.BlastColor = _blastColor;
            this.Blast = _blast;
         }

         }
    }
*/
/*
namespace MagicCannon
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Loop through numbers 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Check if it's a combined blast (both Fire and Electric)
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;  // Blue for combined
                    Console.WriteLine($"{i}: Combined Blast");
                }
                // Check if it's just a fire blast
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Red for Fire
                    Console.WriteLine($"{i}: Fire Blast");
                }
                // Check if it's just an electric blast
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;  // Yellow for Electric
                    Console.WriteLine($"{i}: Electric Blast");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;  // Normal
                    Console.WriteLine($"{i}: Normal");
                }
            }

            // Reset console color
            Console.ResetColor();
        }
    }
}
/*/