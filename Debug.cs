using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public static class Debug
    {                                                               // Privátní funkce - jen debug systém ví, jestli je ten bool zapnut, a list je též jen pro něj.
        private static bool debugEnable = false;                    // Obě dvě věci jsou chráněny před externím přístupem
        private static List<string> LastActions = new List<string>();

        public static void Log(string message)
        {
            if (debugEnable)
            {                                                       // Barevné písmo v konzoli, na odlišení klasických a DEBUG zpráv
                Console.ForegroundColor = ConsoleColor.Yellow;      // Je tu použité víckrát
                Console.WriteLine($"[DEBUG] {message}");
                Console.ResetColor();

                LastActions.Add(message);                           // Přidávání  posledních akcí hráče do paměti až do deseti, když je 
                if (LastActions.Count > 10)                         // debug mód zapnutý
                    LastActions.RemoveAt(0);
            }
        }

        public static void LastActionView()                         // Výpis posledních akcí hráče, když je debug zapnutý a hra přitom skončila
        {
            if (!debugEnable) return;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPOSLEDNÍ AKCE:");
            foreach (string  action in LastActions)                 
            {
                Console.WriteLine($" * '{action}'");
            }
            Console.ResetColor();
        }

        public static void ToggleDebug(string command)              
        {
            if (command == "debugon")                                // Zapnutí debug módu
            {
                debugEnable = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debugging ON!");
                Console.ResetColor();
            }

            else if (command == "debugoff")
            {                                                       // Výpis akcí poté, co se debug mód vypne, ale hra dále běží
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[DEBUG] Last actions before debugg turned off :\n");
                Console.ResetColor();
                foreach (string action in LastActions)
                {
                    Console.WriteLine($" * '{action}'");
                }

                debugEnable = false;                                // Vypnutí debug módu
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debugging OFF");
                Console.ResetColor();
            }
        }

        public static bool IsDebugEnabled()
        { 
            return debugEnable; 
        }
    }
}
