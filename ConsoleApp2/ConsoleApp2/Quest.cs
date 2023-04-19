using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int getCoin { get; set; }

        public Quest(string name, string description, int coins)
        {
            Name = name;
            Description = description;
            Completed = false;
            getCoin = coins;
        }

        public void Complete(Player player)
        {
            Completed = true;
            Console.WriteLine("Вы завершили задание " + Name + "!");
            Console.WriteLine($"Поздравляю! Ваша награда: +{getCoin} монет");
            player._coin = player._coin + getCoin;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Информация о вашем состоянии: ");
            Console.WriteLine(player.GetInfoChar(player));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
