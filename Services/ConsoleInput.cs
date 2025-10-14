namespace Adventure
{
    internal class ConsoleInput : IInputUI
    {
        /* Nastavení _debug jako field
         = Proměnná  uvnitř třídy, co drží data objektu ("vnitřní paměť) */

        private readonly IDebugUI _debug;

        public ConsoleInput(IDebugUI debug)
        {
            _debug = debug;
        }

        /* Vypíše prompt (Zadej jméno:), pak čeká
           na vstup uživatele, zkontroluje, že
           vstup není prázdný / mezery a pak
           vrátí platný vstup */

        public string GetInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                string input;
                do
                {
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.Write("Zkus psát znovu: ");
                    }
                }
                while (string.IsNullOrWhiteSpace(input));

                // Debug logování
                if (string.Equals(input, "debugon", StringComparison.OrdinalIgnoreCase) || string.Equals(input, "debugoff", StringComparison.OrdinalIgnoreCase))
                {
                    _debug.ToggleDebug(input);
                    continue;
                }

                string cleanPrompt = prompt.Replace("\n", " ");
                _debug.Log($"Input: '{input}' pro '{cleanPrompt}'");

                return input;
            }
        }

        public string SelectOption(string heading, string[] options, bool numbersOnly = false)
        {
            Console.WriteLine(heading);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {options[i]}");
            }

            while (true)
            {
                // U textu s diakritikou, kde se vypíná možnost zadávat text
                string choose;
                if (numbersOnly)
                {
                    choose = GetInput($"Vyber číslo (1-{options.Length}): ");
                }
                else
                {
                    choose = GetInput($"Vyber číslo (1-{options.Length}), nebo název: ");
                }

                // Debug toggle v inputu
                if (string.Equals(choose, "debugon", StringComparison.OrdinalIgnoreCase) || choose.Equals("debugoff", StringComparison.CurrentCultureIgnoreCase))
                {
                    _debug.ToggleDebug(choose);
                    continue;
                }

                // Číselný výběr
                if (int.TryParse(choose, out int number) && number >= 1 && number <= options.Length)
                {
                    string chosen = options[number - 1];
                    _debug.Log($"Uživatel vybral: '{chosen}' (číslo {number})");
                    return chosen;
                }

                // Textový výběr
                if (!numbersOnly)
                {
                    foreach (string option in options)
                    {
                        if (string.Equals(choose, option, StringComparison.OrdinalIgnoreCase))
                        {
                            _debug.Log($"Vybráno: '{choose}' (text)");
                            return option;
                        }
                    }
                }
                // Chybové hlášky
                if (numbersOnly)
                {
                    Console.WriteLine($"Neplatná volba, zadej prosím číslo od 1 do {options.Length}.");
                }
                else
                {
                    Console.WriteLine("Neplatná volba!");
                }
            }
        }
    }
}
