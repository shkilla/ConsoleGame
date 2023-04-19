using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest quest1 = new Quest("Одолеть Ящера!", "Это довольно трудная задача, поэтому тебя ждёт большая награда за выполнение этого квеста!", 25);
            Quest quest2 = new Quest("Одолеть Гнома!", "Будьте осторожны в бою, гном довольно хитрый и ловкий!", 30);
            Quest quest3 = new Quest("Одолеть Дракона!", "Дракон очень опасен, его огонь способен прожечь любую броню!", 50);
            Quest quest4 = new Quest("Одолеть Орка!", "Орк очень глупый и не мобильный, но у него много урона и здоровья!", 60);

            GameObject enemylvl1 = new GameObject("Гоблин", "Страшное мифическое создание, которое живёт в пещерах", 50, 50, 5);
            GameObject enemylvl2 = new GameObject("Ящерица", "Небольшая чешуйчатая рептилия, обладает хорошей броней", 80, 80, 3);
            GameObject enemylvl3 = new GameObject("Гном", "Старый маленький гном, живёт под землей, может украсть ваши деньги!", 30, 30, 8);
            GameObject enemylvl4 = new GameObject("Дракон(БОСС)", "Страшное мифическое создание, которое обладает большим уроном", 100, 100, 20);
            GameObject enemylvl5 = new GameObject("ОРК(БОСС)", "Страшное мифическое создание, которое живёт в пещерах и обладает большим кол-вом здоровья", 200, 200, 4);
            Console.WriteLine("Введите имя персонажа: ");
            string nameChar = Console.ReadLine();
            Console.Clear();

            Player newPlayer = new Player();
            newPlayer._Name = nameChar;
            newPlayer.BeginGame(newPlayer);
            Console.ReadKey();
            Battle battle = new Battle();
            battle.StartBattle(newPlayer, enemylvl1);

            Console.WriteLine("Поступило новое задание!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(quest1.Name);
            Console.WriteLine(quest1.Description);
            Console.ReadKey();
            Console.Clear();
            battle.StartBattle(newPlayer, enemylvl2);
            quest1.Complete(newPlayer);

            Console.WriteLine("Поступило новое задание!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(quest2.Name);
            Console.WriteLine(quest2.Description);
            Console.ReadKey();
            Console.Clear();
            battle.StartBattle(newPlayer, enemylvl3);
            quest2.Complete(newPlayer);
            Console.ReadKey();

            Console.WriteLine("Поступило новое задание!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(quest3.Name);
            Console.WriteLine(quest3.Description);
            Console.ReadKey();
            Console.Clear();
            battle.StartBattle(newPlayer, enemylvl4);
            quest3.Complete(newPlayer);

            Console.WriteLine("Поступило новое задание!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(quest4.Name);
            Console.WriteLine(quest4.Description);
            Console.ReadKey();
            Console.Clear();
            battle.StartBattle(newPlayer, enemylvl5);
            quest4.Complete(newPlayer);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Поздравляю! Вы одолели всех боссов и достигнули максимального уровня!");
            Console.WriteLine("Вот краткая информация о твоём персонаже: ");
            Console.WriteLine(newPlayer.GetInfoChar(newPlayer));
            Console.WriteLine("Конец игры!");
            Console.ReadKey();
            Environment.Exit(0);
            /*

            Console.WriteLine("Нажмите 1 чтобы продолжить или 2 чтобы вернуться: ");
            int continueGame = int.Parse(Console.ReadLine());
            if(continueGame == 1)
            {
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine($"ДОБРО ПОЖАЛОВАТЬ В ПРИКЛЮЧЕНИЕ {nameChar}!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Вы появились в маленькой деревушке с населением 1200 человек");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("В последнее время на деревню стали часто нападать охотники");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ваша цель защитить деревню от следующего нападения!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            int hpHunter1 = 100;

            Console.WriteLine("На деревню напал Охотник 1 уровня!");
            Console.WriteLine($"Здоровье охотника: {hpHunter1}");
            Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть охотника!");
            Console.ReadKey();
            Console.Clear();
            while(hpHunter1 > 0)
            {
                Console.WriteLine($"Здоровье охотника: {hpHunter1}");
                Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть охотника!");
                Console.ReadKey();
                hpHunter1 = hpHunter1 - damageChar;
                Console.Clear();
            }
            Console.WriteLine("Поздравляю с победой над первым соперником!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Не стоит радоваться, ведь он даже не наносил вам урона!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ваш следующий соперник гораздо сильнее, будьте осторожней в бою!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            hpHunter1 = 100;
            int damageHunter1 = 5;
            Console.WriteLine($"Здоровье противника: {hpHunter1}");
            Console.WriteLine($"Ваше здоровье: {healthChar}");
            Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть противника!");
            Console.ReadKey();
            Console.Clear();
            while (hpHunter1 > 0)
            {
                Console.WriteLine($"Здоровье охотника: {hpHunter1}");
                Console.WriteLine($"Ваше здоровье: {healthChar}");
                Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть противника!");
                Console.ReadKey();
                ChangeHpChar(-damageHunter1);
                hpHunter1 = hpHunter1 - damageChar;
                Console.Clear();
            }
            coinChar = coinChar + 20;
            Console.WriteLine("Победа!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Вы получили 20 монет за победу над противником!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("После этой нелёгкой схватки вам необходимо подлечиться!");
            Console.WriteLine($"Ваше здоровье: {healthChar}");
            Console.WriteLine($"Монеты: {coinChar}");
            Console.WriteLine("Нажмите 1 чтобы восстановить здоровье за 10 монет или 2 чтобы продолжить без восстановления: ");
            continueGame = int.Parse(Console.ReadLine());
            Console.Clear();
            if (continueGame == 1)
            {
                ChangeHpChar(100);
                Console.WriteLine("Отлично! Теперь вы готовы к следующему бою!");
                Console.WriteLine($"Ваше здоровье: {healthChar}");
                Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Continue");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();*/
        }
    }
}
