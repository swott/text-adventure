namespace Adventure
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            IDebugUI debug = new ConsoleDebug();
            IInputUI input = new ConsoleInput(debug);
            IBaseOutputUI output = new BaseConsoleOutput();

            BaseGame game = new BaseGame(input, debug, output);
            game.GameStart();
        }
    }
}
