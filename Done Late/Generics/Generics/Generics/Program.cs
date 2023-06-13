using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Generics.Program;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task4
            List<Character> list = new List<Character>();
            Character character1 = new Character()
            {
                health = 100,
                score = 50
            };
            Character character2 = new Character()
            {
                health = 80,
                score = 85
            };
            Character character3 = new Character()
            {
                health = 120,
                score = 75
            };
            list.Add(character1);
            list.Add(character2);
            list.Add(character3);
            MaxHealth(list);
        }
        public class Character
        {
            public int health { get; set; }
            public int score { get; set; }
        }
        //-----------------------------------------------------------------------------
        //Task1
        public class GameObjects<T>
        {
            List<T> list = new List<T>();

            public void Add(T item)
            {
                list.Add(item);
            }

        }
        //-----------------------------------------------------------------------------
        //Task2
        interface Generic<T>
        {
            void Attacking(T item);
            void TakeDamage(T item);
            void Healing(T item);
        }
        //-----------------------------------------------------------------------------
        //Task3
        public class Inventory<T>
        {
            List<T> list = new List<T>();

            public void Add(T item)
            {
                list.Add(item);
            }
            public void RemoveItem(T item)
            {
                list.Remove(item);
            }
            public void Sort(List<T> list)
            {
                list.Sort();

            }
        }
        //-----------------------------------------------------------------------------
        //Task4
        public static T MaxHealth<T>(List<T> Charcater) where T : Character
        {
            T MaxHealthCharacter = default;
            for (int i = 0; i < Charcater.Count; i++)
            {
                if (Charcater[i].health > MaxHealthCharacter.health)
                {
                    MaxHealthCharacter.health = Charcater[i].health;
                }

            }
            return MaxHealthCharacter;
        }


    }
}