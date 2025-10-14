namespace Adventure
{
    // Základní zprávy (Čau, Měj se)
    internal interface IBaseOutputUI
    {
        void ShowMessage(string message);

        void ShowTitle(string title);
    }

    /* Bude volat postupně všechno možné co se týče hráče,
       ale není společné s enemy */

    internal interface IPlayerOutputUI
    {
        void PlayerWelcome(string gender); //Test message -> pozdrav podle pohlaví
    }
}
