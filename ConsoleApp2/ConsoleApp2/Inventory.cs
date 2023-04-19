using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Inventory
    {
        public List<GameObject> Items { get; set; }

        public Inventory()
        {
            Items = new List<GameObject>();
        }

        public void AddItem(GameObject item)
        {
            Items.Add(item);
            Console.WriteLine("Вы получили " + item.Name + " в инвентарь.");
        }

        public void UseItem(GameObject item, Player player)
        {
            Console.WriteLine("Вы использовали " + item.Name + ".");
            player._Health = player._Health + item.Health;
            player._MaxHealth = player._MaxHealth + 5;
        }

        public void RemoveItem(GameObject item)
        {
            Items.Remove(item);
            Console.WriteLine($"Вы потратили предмет: {item.Name}");
        }
    }
}
