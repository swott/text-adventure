namespace Adventure
{
    internal interface IDebugUI
    {
        void Log(string message);

        void ShowLastActions();

        void ToggleDebug(string command);

        bool IsDebugEnabled();
    }
}
