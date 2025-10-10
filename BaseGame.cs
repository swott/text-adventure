using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    internal class BaseGame
    {
        private string GameName = "Název hry";

        public void GameStart()                                 // Zatím v podstatě  jen název hry, zapnutí hráče a vypsání jeho nickname
        {
            Console.WriteLine($"Vítej ve hře: {GameName}");
            Player pchar = Player.CreateNew();
            Console.WriteLine($"Vítej, {pchar.Nickname}!");
        }
    }
}
