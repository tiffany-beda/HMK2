/*using Microsoft.VisualBasic;

namespace BuyingInventory 
{
    public class BuyingInventory
    {
        private string menuChoice = "n/a";
        private double itemCost = -1;
        
        private string customerName = "n/a";

        public string MenuChoice 
        {
            get { return this.menuChoice;}
            set { this.menuChoice = value;}

        }
        public double ItemChoice
        {
            get {return this.ItemChoice; }
            set { this.itemCost = value ;}
        }

        public string CustomerName
        {
            get {return this.customerName; }
            set { this.customerName = value ;}
        }

        public BuyingInventory (): this ("n/a",-1){}
        public BuyingInventory (string _menuChoice , double _itemCost)
        {
            this.MenuChoice = _menuChoice;
            this.ItemChoice = _itemCost;
        }
         
         public void ApplyDiscount()
         {
            itemCost/=2;
         }
        public override string ToString()
        {
            return $"{menuChoice} cost {itemCost} gold.";
        }
    }
    public class Program 
    {
        static void Main (string[]args)
        {
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice <1 || choice>7)
            {
                Console.WriteLine("Invalid Selection. Please choose another selection ");
            }

            BuyingInventory selectedItem;

            switch (choice)
        {
            case 1:  
                 selectedItem = new BuyingInventory("Rope",10);
                 break;
            case 2: 
               selectedItem = new BuyingInventory("Torches",15);
                 break; 
            case 3:
                  selectedItem = new BuyingInventory("Climbing Equipment", 25);
                 break;
            case 4:
                  selectedItem = new BuyingInventory("CleanWater", 1);
                 break;
            case 5:
                selectedItem = new BuyingInventory("Machete", 20);
                 break;
            case 6:
                selectedItem = new BuyingInventory("Canoe", 200);
                 break;
            case 7:
                selectedItem = new BuyingInventory("Food Supplies", 1);
                 break; 
            default:
            selectedItem = new BuyingInventory();
            break;

        }
        Console.WriteLine ("What is your name ?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (name == "Tiffany")
        {
            selectedItem.ApplyDiscount();
            Console.WriteLine("Since you're name is Tiffany you'll get a 50% discount ");
        }
        
    Console.WriteLine(selectedItem.ToString());
        }
    }
    

}
*/