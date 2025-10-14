namespace Adventure
{
    internal class BaseGame
    {
        private readonly IInputUI _input;
        private readonly IBaseOutputUI _baseOutput;
        private readonly IDebugUI _debug;
        private readonly IPlayerOutputUI _playerOutput;
        private readonly GameTextDB _gameTextDB;
        private readonly PlayerTextDB _playerTextDB;

        public BaseGame(IInputUI input, IDebugUI debug, IBaseOutputUI baseOutput, IPlayerOutputUI playerOutput, GameTextDB gameTextDB, PlayerTextDB playerTextDB)
        {
            _input = input;
            _debug = debug;
            _baseOutput = baseOutput;
            _playerOutput = playerOutput;
            _gameTextDB = gameTextDB;
            _playerTextDB = playerTextDB;
        }

        // Zatím v podstatě  jen název hry, zapnutí hráče a vypsání jeho nickname
        public void GameStart()
        {
            _baseOutput.ShowMessage(_gameTextDB.StartGame());
            Player pchar = Player.CreateNew(_input, _baseOutput, _gameTextDB);
            _debug.Log($"Name: {pchar.Nickname}, gender: {pchar.Gender}");
            _debug.Log($"Test: {pchar.Stats.CurrentHP}/{pchar.Stats.MaxHP} HP, {pchar.Stats.Armor} armor");
            _playerOutput.PlayerWelcome(pchar.Gender);

            if (_debug.IsDebugEnabled())
            {
                _debug.ShowLastActions();
            }
        }
    }
}
