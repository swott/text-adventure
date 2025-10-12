namespace Adventure
{
    internal class BaseGame
    {
        private readonly IInputUI _input;
        private readonly IBaseOutputUI _baseOutput;
        private readonly IDebugUI _debug;
        private readonly IPlayerOutputUI _playerOutput;



        public BaseGame(IInputUI input, IDebugUI debug, IBaseOutputUI baseOutput, IPlayerOutputUI playerOutput)
        {
            _input = input;
            _debug = debug;
            _baseOutput = baseOutput;
            _playerOutput = playerOutput;
        }

        // Zatím v podstatě  jen název hry, zapnutí hráče a vypsání jeho nickname
        public void GameStart()
        {
            _baseOutput.StartMessage();
            Player pchar = Player.CreateNew(_input);
            _debug.Log($"Vytvořen hráč: {pchar.Nickname}, pohlavím {pchar.Gender}");

            _playerOutput.PlayerWelcome(pchar.Gender);
            _baseOutput.EndMessage();

            if(_debug.IsDebugEnabled())
            {
                _debug.ShowLastActions();
            }
        }
    }
}
