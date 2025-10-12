namespace Adventure
{

    // Universální class, ještě před výběrem specializace
    internal class BaseClass
    {
        public int MaxHP;
        public int CurrentHP;
        public int Armor;



        public BaseClass(int maxHP, int currentHP, int armor)
        {
            MaxHP = maxHP;
            CurrentHP = currentHP;
            Armor = armor;
        }
    }
}
