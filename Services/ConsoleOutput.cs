namespace Adventure
{
    internal class BaseConsoleOutput : IBaseOutputUI
    {
        public void StartMessage()
        {
            Console.WriteLine("Vítej ve hře.");
        }
        public void EndMessage()
        {
            Console.WriteLine("Hra skončila, měj se!");
        }
    }

    // Všechny možné výstupy o hráči, co se netýkají enemy
    internal class PlayerConsoleOutput : IPlayerOutputUI
    {
        private readonly GenderTextDB _genderText;

        public PlayerConsoleOutput(GenderTextDB genderText)
        {
            _genderText = genderText;
        }

        public void PlayerWelcome(string gender)
        {
            string text = _genderText.GetAction(gender, "welcometest");
            Console.WriteLine($"{text}");
        }
    }
}
