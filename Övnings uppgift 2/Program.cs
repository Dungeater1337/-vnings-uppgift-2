using System; 

namespace Uppgigt_3_11
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en katogori.");
            Console.WriteLine("1. Musik");
            Console.WriteLine("2. Geografi");
            Console.WriteLine("3. Historia");

            string katogori = Console.ReadLine();
            string rättsvar = ""; 

            switch (katogori)
            {
                case "1":
                    Console.WriteLine("Från vilket land kom ABBA?");
                    rättsvar = "sverige";
                    break; 

                case "2":
                    Console.WriteLine("Vad heter Norges huvudstad");
                    rättsvar = "oslo";
                    break; 

                case"3":
                    Console.WriteLine("När började andravärldskriget?");
                    rättsvar = "1939";
                    break;  
                        
                       default:
                    break; 
            }

            string svar = Console.ReadLine().ToLower();

            if (svar == rättsvar)
            {
                Console.WriteLine("Du svare rätt!");
            }

            else
            {
                Console.WriteLine("Du svarade fel!"); 
            }
        }
    }
}