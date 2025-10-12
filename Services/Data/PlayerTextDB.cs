namespace Adventure
{
    internal class PlayerTextDB
    {
        public string GetAction(string gender, string actionKey)
        {
            /* Tohle je "switch expression" - modernější a čistší verze klasického switch.
               Funguje stejně, ale má lepší syntaxi.
               (gender, actionKey) switch = vezme oba parametry místo 2 switchů v sobě
               => = "vrať tuhle hodnotu"
               _ = "výchozí případ" (jako default) */

            return (gender, actionKey) switch
            {
                ("Žena", "welcome") => "Vítej, statečná ženo!",

                ("Muž", "welcome") => "Vítej, statečný muži.",

                _ => "Default nápis"
            };
        }
    }
}
