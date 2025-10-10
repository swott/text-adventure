namespace Adventure
{
    class MainClass
    {
        public static void Main(string[] args)                  // Zde už nic v podstatě dělat nebudu, jelikož základ hry bude psaný v BaseGame.cs 
        {                                                       // a výpočty apod. dělané v jiných třídách.
            BaseGame game = new BaseGame();
            game.GameStart();
        }
    }
}