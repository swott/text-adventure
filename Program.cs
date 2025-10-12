namespace Adventure
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Nejprve vkládat data/služby
             * Pak UI služby (složka interface)
             * Pak herní engine (basegame)
            */

            // Data/služby
            PlayerTextDB playerText = new PlayerTextDB();
            GameTextDB gameText = new GameTextDB();

            // UI služby (Interface)
            IDebugUI debug = new ConsoleDebug();
            IInputUI input = new ConsoleInput(debug);
            IBaseOutputUI baseOutput = new BaseConsoleOutput();
            IPlayerOutputUI playerOutput = new PlayerConsoleOutput(playerText);

            // Engine (hra samotná)
            BaseGame game = new BaseGame(input, debug, baseOutput, playerOutput, gameText, playerText);
            game.GameStart();
        }
    }
}
