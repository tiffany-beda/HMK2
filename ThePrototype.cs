/*namespace ThePropotype 
{
    public class Prototype 
    {
        private int hunterNumber = -100;
        private int pilotNumber = -100;
        
        public int HunterNumber 
        {
            get {return this.hunterNumber;}
            set {this.hunterNumber = value;}
        }
        public int PilotNumber 
        {
            get {return this.pilotNumber;}
            set {this.pilotNumber = value;}
        }
        
        public Prototype (): this (-100,-100){}
        public Prototype (int _hunterNumber,int _pilotNumber)
        {
            this.HunterNumber = _hunterNumber;
            this.PilotNumber = _pilotNumber;
        }
        
        public string CheckGuess()
        {
            if (HunterNumber > PilotNumber)
            {
                return "Too High!";
            }
            else if (HunterNumber < PilotNumber)
            {
                return "Too Low!";
            }
            else 
        
            {return "you guess the number !";}
        }

       
    }
    public class Program
    {
static void Main (string [] args)

    {
        
        
        Prototype game1 = new Prototype ();

        int pilotSecret;
            
            do 
            {
                Console.Write("User 1 enter a number between 0 and 100: ");
               pilotSecret = Convert.ToInt32(Console.ReadLine());
            }
            while( pilotSecret <0 || pilotSecret >100);

                game1.PilotNumber = pilotSecret;

            Console.Clear();
            Console.WriteLine("User 2, guess the number.");

            int hunterGuess;
            while (true)
            {
                Console.WriteLine ("What is the your next guess ?");
               hunterGuess = Convert.ToInt32(Console.ReadLine());
               game1.HunterNumber = hunterGuess;

               Console.WriteLine(game1.CheckGuess());

               if (hunterGuess ==  game1.PilotNumber)
               break;
            }
            Console.WriteLine("Game over!");
    }

    }
        
}
*/