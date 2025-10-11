namespace Adventure
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            IDebugUI debug = new ConsoleDebug();
            IInputUI input = new ConsoleInput(debug);
            // TODO: Udělat output
            // IOutputUI output = new ConsoleOutput();

            BaseGame game = new BaseGame(input, debug);
            game.GameStart();
        }
    }
}
