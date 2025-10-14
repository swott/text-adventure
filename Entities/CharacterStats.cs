namespace Adventure
{
    internal class CharacterStats
    {
        public int MaxHP;
        public int CurrentHP;
        public int Armor;

        public CharacterStats(BaseClass baseClass)
        {
            MaxHP = baseClass.MaxHP;
            CurrentHP = baseClass.CurrentHP;
            Armor = baseClass.Armor;
        }
    }
}
