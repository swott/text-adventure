namespace Adventure
{
    internal class Player
    {
        public string Nickname;
        public string Sex;
        /*public CharacterStats Stats;*/

        private Player(string nickname, string sex)
        {
            this.Nickname = nickname;
            this.Sex = sex;
        }

        public static Player CreateNew(IInputUI input)
        {
            string nickname = input.GetInput("Vidím jen stín, kdo jsi?\n");

            string[] genders = ["On", "Ona", "Ono"];
            string sex = input.SelectOption("Vyber pohlaví: ", genders);

            return new Player(nickname, sex);
        }
    }
}
