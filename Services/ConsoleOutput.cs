namespace Adventure
{
    internal class BaseConsoleOutput : IBaseOutputUI
    {
        public void StartMessage()
        {
            Console.WriteLine("Vítej ve hře.");
        }
        public void EndMessage()
        {
            Console.WriteLine("Hra skončila, měj se!");
        }
    }
}
