using EndersDragon;

namespace EndersDragon
{
    class Encounters
    {
        //Encounters Generic

        //Encounters

        public static void FirstEncounter(){
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging toward your captor");
            Console.WriteLine("He turn...");
            Console.ReadKey();
        }

        //Encounters Tools

        public static void Combat(bool random, string name, int power, int health){
            string n = "";
            int p = 0;
            int h = 0;
            if (random){

            }
            else{
                n = name;
                p = power;
                h = health;

            }

            while (h > 0){
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|    (R)un (H)eal   |");
                Console.WriteLine("=====================");
                Console.WriteLine(" Potions: " + Program.currentPlayer.potion +"  Health:" + Program.currentPlayer.health );
                string input = Console.ReadLine();
            }


        }


    }
}