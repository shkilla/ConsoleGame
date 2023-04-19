using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Battle
    {
        public void StartBattle(Player player, GameObject enemy)
        {
            Console.Clear();
            Console.WriteLine($"На вас напал {enemy.Name}! Обороняйтесь!");

            while (player._Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"Ваше здоровье: {player._Health}");
                Console.WriteLine($"Здоровье {enemy.Name}: {enemy.Health}");
                Console.WriteLine("Чтобы атаковать врага, нажмите на любую клавишу...");
                Console.ReadKey();
                player._Health = player._Health - enemy.Damage;
                enemy.Health = enemy.Health - player._Damage;
                Console.Clear();
            }

            if (enemy.Health <= 0 && player._Health > 0)
            {
                Console.WriteLine("Вы победили " + enemy.Name + "!");
                Console.WriteLine($"Награда за победу: +{enemy.Damage + 5} монет!");
                player._coin = player._coin + enemy.Damage + 5;
                player._lvlPlayer = player._lvlPlayer + 1;
                player._MaxHealth = player._MaxHealth + 15;
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Информация о вашем состоянии: ");
                Console.WriteLine(player.GetInfoChar(player));
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Вам необходимо подлечится!");
                Console.ReadKey();
                Console.Clear();
                player._coin = player._coin - 5;
                player.ChangeHpChar(100, player);
                Console.WriteLine($"Вы потратили 5 монет чтобы вылечится!");
                Console.WriteLine("Информация о вашем состоянии: ");
                Console.WriteLine(player.GetInfoChar(player));
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Вы проиграли битву.");
                Console.WriteLine("Конец игры!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
