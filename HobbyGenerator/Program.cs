using System.Collections.Generic;
using System.Text;

namespace HobbyGenerator
{
    internal class Program
    {
        static string[] Hobbies = { "sjonglør", "kattepasser", "car-tuner", "nål-i-høystakk-finner", "politiker" };
        static Dictionary<string, string> HobbyInfo = new Dictionary<string, string>(); //denne er redundant, men jeg ville øve på dictionaries. Men dersom vi ønsket å ta vare på og tilordne hobby til et person-objekt, så er dette nyttig.
        static string text = "initialize";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {   
                Console.WriteLine("Skriv inn et navn...");
                text = Console.ReadLine();
                initializeDictionary(); //Kjører den her på nytt siden den kjører med initialize name og forblir det dersom den ikke oppdateres

                if (string.IsNullOrWhiteSpace(text))
                {
                    break;
                }
                Random random = new Random();
                Console.WriteLine(HobbyInfo[Hobbies[random.Next(Hobbies.Length)]]); //Henter en tilfeldig verdi fra Hobbies som brukes til key for HobbyInfo 

            }
        }
        
        public static void initializeDictionary()
        {
            HobbyInfo.Clear();
            HobbyInfo.Add("sjonglør", $"Haha, {text}, nå kan du sjonglere!");
            HobbyInfo.Add("kattepasser", $"Så koselig. {text} passer katter.");
            HobbyInfo.Add("car-tuner", $"Sykt tøft, {text}, jeg kan ikke tro at du er into car-tuning!");
            HobbyInfo.Add("nål-i-høystakk-finner", $"{text} er litt sær, de er glade i å lete etter nåler i høystakker.");
            HobbyInfo.Add("politiker", $"{text} er en politiker. Ti still er du grei.");
        }

    }
}