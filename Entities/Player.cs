namespace Adventure
{
    internal class Player
    {
        public string Nickname;
        public string Gender;
        /*public CharacterStats Stats;*/

        private Player(string nickname, string gender)
        {
            Nickname = nickname;
            Gender = gender;
        }

        public static Player CreateNew(IInputUI input)
        {
            string nickname = input.GetInput("Vidím jen stín, kdo jsi?\n");

            string[] genders = ["On", "Ona", "Ono"];
            string gender = input.SelectOption("Vyber pohlaví: ", genders);

            return new Player(nickname, gender);
        }
    }
}
