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
                if (input.ToLower() == "debugon" || input.ToLower() == "debugoff")
                {
                    _debug.ToggleDebug(input);
                    continue;
                }

                _debug.Log($"[DEBUG] Input: '{input}' pro '{prompt}'");

                return input;
            }
        }

        public string SelectOption(string heading, string[] options)
        {
            Console.WriteLine(heading);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {options[i]}");
            }

            while (true)
            {
                string choose = GetInput($"Vyber číslo (1-{options.Length}, nebo název: ");

                // Debug toggle v inputu
                if (choose.ToLower() == "debugon" || choose.ToLower() == "debugoff")
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
                foreach (string option in options)
                {
                    if (choose.ToLower() == option.ToLower())
                    {
                        _debug.Log($"Vybráno: '{choose}' (text)");
                        return option;
                    }
                }

                Console.WriteLine("Neplatná volba!");
            }
        }
    }
}
