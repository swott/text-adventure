namespace Adventure
{
    internal class ConsoleDebug : IDebugUI
    {
        private bool _debugEnable = false;
        private List<string> _lastActions = new List<string>();

        private void WriteLineColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /*
        private void WriteColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        */

        public void Log(string message)
        {
            if (_debugEnable)
            {
                WriteLineColor($"[DEBUG] {message}", ConsoleColor.Yellow);

                _lastActions.Add(message);                       // Zprávu zapíše do listu
                if (_lastActions.Count > 10)                     // Pokud jich bude víc jak 10
                    _lastActions.RemoveAt(0);                    // Smaže nejstarší zprávu
            }
        }

        public void ShowLastActions()
        {
            if (!_debugEnable) return;                       // Když je debug zapnutý

            WriteLineColor("\n[DEBUG] Last actions before the game ends: ", ConsoleColor.Yellow);

            foreach (string action in _lastActions)
            {
                WriteLineColor($" * '{action}' ", ConsoleColor.Yellow);
            }
        }

        public void ToggleDebug(string command)
        {
            if (command == "debugon")
            {
                _debugEnable = true;
                WriteLineColor("Debug mode ON", ConsoleColor.Red);
            }
            else if (command == "debugoff")
            {
                WriteLineColor($"[DEBUG] Last actions before debug was turned off:\n", ConsoleColor.Yellow);
                ShowLastActions();

                _debugEnable = false;
                WriteLineColor("Debug mode OFF", ConsoleColor.Red);
            }
        }

        public bool IsDebugEnabled()
        {
            return _debugEnable;
        }
    }
}
