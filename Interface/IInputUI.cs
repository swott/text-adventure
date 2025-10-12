namespace Adventure
{
    internal interface IInputUI
    {
        string GetInput(string prompt);

        string SelectOption(string heading, string[] options, bool numbersOnly = false);
    }
}
