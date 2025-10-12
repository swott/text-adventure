namespace Adventure
{

    // Základní zprávy (Čau, Měj se)
    internal interface IBaseOutputUI
    {
        void StartMessage();
        void EndMessage();
    }

    /* Bude volat postupně všechno možné co se týče hráče,
       ale není společné s enemy */
    internal interface IPlayerOutputUI
    {
        void PlayerWelcome(string gender); //Test message -> pozdrav podle pohlaví
    }

}
