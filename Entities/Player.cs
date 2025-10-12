namespace Adventure
{
    internal class Player
    {
        public string Nickname;
        public string Gender;
        public BaseClass Class;         // Data z ClassTemplate ("Co má hráč mít")
        public CharacterStats Stats;    // Funkcionalita (výpočty atd) ("Jak to funguje")

        private Player(string nickname, string gender, BaseClass playerClass)
        {
            Nickname = nickname;
            Gender = gender;
            Class = playerClass;                            // Má data o classe (HP atd)
            Stats = new CharacterStats(playerClass);        // Vezme si data od té horní, a vypočítá zbytek
        }

        public static Player CreateNew(IInputUI input)
        {
            string nickname = input.GetInput("Vidím jen stín, kdo jsi?\n");

            string[] genders = ["On", "Ona", "Ono"];
            string gender = input.SelectOption("Vyber pohlaví: ", genders);

            // Temporary, jen na vidění v DEBUG logu
            BaseClass playerClass = new BaseClass(maxHP: 20, currentHP: 10, armor: 5);

            return new Player(nickname, gender,playerClass);
        }
    }
}
