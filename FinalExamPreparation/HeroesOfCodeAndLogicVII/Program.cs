using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> hero = new Dictionary<string, Hero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split(" ");
                var name = commands[0];
                var hp = int.Parse(commands[1]);
                var mana = int.Parse(commands[2]);
                if (hp <= 100 && mana <= 200)
                {
                    hero.Add(name, new Hero());
                    hero[name].Hp = hp;
                    hero[name].Mana = mana;
                }
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(" - ");
                if (tokens[0] == "CastSpell")
                {
                    var name = tokens[1];
                    var manaNeeded = int.Parse(tokens[2]);
                    var spellName = tokens[3];
                    if (hero[name].Mana >= manaNeeded)
                    {
                        hero[name].Mana -= manaNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero[name].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (tokens[0] == "TakeDamage")
                {
                    var name = tokens[1];
                    var damage = int.Parse(tokens[2]);
                    var attacker = tokens[3];
                    hero[name].Hp -= damage;
                    if (hero[name].Hp > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hero[name].Hp} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        hero.Remove(name);
                    }
                }
                else if (tokens[0] == "Recharge")
                {
                    var name = tokens[1];
                    var amount = int.Parse(tokens[2]);
                    var currAmountOfMana = hero[name].Mana;
                    hero[name].Mana += amount;
                    if (hero[name].Mana > 200)
                    {
                        Console.WriteLine($"{name} recharged for {200 - currAmountOfMana} MP!");
                        hero[name].Mana = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }
                }
                else if (tokens[0] == "Heal")
                {
                    var name = tokens[1];
                    var amount = int.Parse(tokens[2]);
                    var currAmountOfHp = hero[name].Hp;
                    hero[name].Hp += amount;
                    if (hero[name].Hp > 100)
                    {
                        Console.WriteLine($"{name} healed for {100 - currAmountOfHp} HP!");
                        hero[name].Hp = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var character in hero.OrderByDescending(h => h.Value.Hp).ThenBy(h => h.Key).ToDictionary(h => h.Key, h => h.Value))
            {
                Console.WriteLine($"{character.Key}\nHP: {character.Value.Hp}\nMP: {character.Value.Mana}");
            }
        }
    }
}
