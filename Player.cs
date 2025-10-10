using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    internal class Player
    {
        public string Nickname;
        public string Sex;
        /*public CharacterStats Stats;*/


        private Player(string nickname, string sex) 
        {
            this.Nickname = nickname;
            this.Sex = sex;
        }

        public static Player CreateNew()
        {
            string nickname = InputHelper.InputDebug("Vidím jen stín, kdo jsi?\n");

            string[] genders = [ "On", "Ona", "Ono" ];
            string sex = InputHelper.SelectOption("Vyber pohlaví: ", genders);

            return new Player(nickname, sex);
        }

    }

}
