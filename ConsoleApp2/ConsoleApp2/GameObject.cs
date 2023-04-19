using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GameObject
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Health { get; set; }
            public  int MaxHealth { get; set; }
            public int Damage { get; set; }

            public GameObject(string name, string description, int health, int maxHealth, int damage)
            {
                Name = name;
                Description = description;
                Health = health;
                MaxHealth = maxHealth;
                Damage = damage;
            }
    }
}
