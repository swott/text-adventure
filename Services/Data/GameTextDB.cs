namespace Adventure
{
    internal class GameTextDB
    {
        public string StartGame()
        {
            return "Probudil jsi se v temnotě.";
        }

        public string CreateNicknameStart()
        {
            return "První otázka, co tě napadne je: 'Jak se jmenuji?'\n";
        }

        public string CreateNicknameEnd(string text)
        {
            return $"Vzpomeneš si, že je tvé jméno {text}.";
        }

        public string CreateGenderPrompt()
        {
            return "'Jak ale vypadám?'";
        }
    }
}
