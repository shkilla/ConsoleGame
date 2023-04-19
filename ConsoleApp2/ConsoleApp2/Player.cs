using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Player
    {
        public string _Name { get; set; }
        public int _Health { get; set; }
        public int _MaxHealth { get; set; }
        public int _Damage { get; set; }
        public int _coin { get; set; }
        public double _chanceMissPlayer { get; set; }
        public int _lvlPlayer { get; set; }

        public Player(string name = "%NAME%", int health = 100, int maxHealth = 100, int damage = 15, int coin = 0, int lvlPlayer = 1)
        {
            _Name = name;
            _Health = health;
            _MaxHealth = maxHealth;
            _Damage = damage;
            _coin = coin;
            _chanceMissPlayer = 1.05;
            _lvlPlayer = lvlPlayer;
        }
        public void BeginGame(Player player)
        {
            Console.WriteLine("Добро пожаловать в небольшое путешествие!");
            Console.WriteLine("Вот краткая информация о твоём персонаже: ");
            Console.WriteLine(player.GetInfoChar(player));
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
        }
        public void ChangeHpChar(int count, Player player)
        {
            if (count + player._Health >= player._MaxHealth)
            {
                player._Health = player._MaxHealth;
            }
            else
            {
                player._Health = player._Health + count;
            }

        }
        public string GetInfoChar(Player player)
        {
            return $"Имя: {player._Name}, Здоровье: {player._Health}, урон: {player._Damage}, монеты: {player._coin}, уровень персонажа: {player._lvlPlayer}.";
        }
    }
}
