namespace Adventure
{
    internal class BaseGame
    {
        private readonly IInputUI _input;

        private readonly IBaseOutputUI _output;
        private readonly IDebugUI _debug;

        

        public BaseGame(IInputUI input, IDebugUI debug, IBaseOutputUI output)
        {
            _input = input;
            _debug = debug;
            _output = output;
        }

        public void GameStart()                                 // Zatím v podstatě  jen název hry, zapnutí hráče a vypsání jeho nickname
        {
            _output.StartMessage();
            Player pchar = Player.CreateNew(_input);
            _debug.Log($"Vytvořen hráč: {pchar.Nickname}");
            Console.WriteLine($"Vítej, {pchar.Nickname}!");
            _output.EndMessage();

        }
    }
}
