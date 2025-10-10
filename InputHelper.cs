using System;

namespace Adventure
{
    public static class InputHelper
    {
        /* Zlehčení inputu, aby se nemuselo psát console etc...*/

        public static string Input(string text)
        {
            Console.Write(text);

            string input;
            do
            {
                input = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Zkus psát znovu: ");
                }
            }
            while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        /* To samé co nahoře, ale propojeno s debugem, kdy po napsání
           "debugon" zapne debug a když je zapnutý, píše inputy po enteru */


        public static string InputDebug(string text)
        {
            while (true)
            {
                string inputDebug = Input(text);

                if (inputDebug.ToLower() == "debugon" || inputDebug.ToLower() == "debugoff")
                {
                    Debug.ToggleDebug(inputDebug);
                    continue;
                }
                Debug.Log($"Input: '{inputDebug}' pro '{text}'");
                return inputDebug;
            }
        }

        /* Input pro výběr možností */

        public static string SelectOption(string heading, string[] options)
        {
            Console.WriteLine(heading);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i+1} - {options[i]}");
            }

            while(true)
            {
                string choose = InputDebug($"Vyber číslo (1-{options.Length}), nebo název: ");

                /*  Zkus číselný výběr : 
                    Převod čísla v inputu na int, když neuspěje, přejde na Neplatnou volbu */

                if (int.TryParse(choose, out int number) && number >= 1 && number <= options.Length) 
                {
                    string chosen = options[number - 1];
                    Debug.Log($"Uživatel vybral: '{chosen}' (číslo {number})");
                    return chosen;
                }

                foreach (string option in options)
                {
                    if (choose.ToLower() == option.ToLower())
                    {
                        Debug.Log($"Vybráno: '{choose}' (text)");
                        return option;
                    }
                }

                Console.WriteLine("Neplatná volba!");
            }
        }

    }
}