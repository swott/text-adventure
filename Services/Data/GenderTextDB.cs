namespace Adventure
{
    internal class GenderTextDB
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
                ("Ona", "welcometest") => "Ahoj ženo.",
                ("Ono", "welcometest") => "Ahoj ono.",
                (_, "welcometest") => "Ahoj muži.",
                _ => "Default nápis"
            };
        }
    }
}
