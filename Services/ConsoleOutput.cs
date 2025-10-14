namespace Adventure
{
    internal class BaseConsoleOutput : IBaseOutputUI
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowTitle(string title)
        {
            Console.WriteLine($"=== {title} ===");
            Console.WriteLine();
        }
    }

    // Všechny možné výstupy o hráči, co se netýkají enemy
    internal class PlayerConsoleOutput : IPlayerOutputUI
    {
        private readonly PlayerTextDB _genderText;

        public PlayerConsoleOutput(PlayerTextDB genderText)
        {
            _genderText = genderText;
        }

        public void PlayerWelcome(string gender)
        {
            string text = _genderText.GetAction(gender, "welcome");
            Console.WriteLine($"{text}");
        }
    }
}
