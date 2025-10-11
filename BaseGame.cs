namespace Adventure
{
    internal class BaseGame
    {
        private readonly IInputUI _input;

        // NOTE : Output zde
        // private readonly IOutputUI _output;
        private readonly IDebugUI _debug;

        private string GameName = "Název hry";

        public BaseGame(IInputUI input, IDebugUI debug)
        {
            _input = input;
            _debug = debug;
        }

        public void GameStart()                                 // Zatím v podstatě  jen název hry, zapnutí hráče a vypsání jeho nickname
        {
            Console.WriteLine($"Vítej ve hře: {GameName}");
            Player pchar = Player.CreateNew(_input);
            _debug.Log($"Vytvořen hráč: {pchar.Nickname}");
            Console.WriteLine($"Vítej, {pchar.Nickname}!");
        }
    }
}
