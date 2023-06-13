using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        //------------------------------------------------------------
        //Task1
        //public static Action action;
        //static void Main(string[] args)
        //{
        //    action = PrintSomething;
        //    action();
        //}
        //static void PrintSomething()
        //{
        //    Console.WriteLine("Write");
        //}

        //-------------------------------------------------------------
        //Task2
        //public static Func<int, int> func;
        //static void Main(string[] args)
        //{
        //    func = Power;
        //    int.TryParse(Console.ReadLine(), out int number);
        //    Console.WriteLine(func(number));
        //}
        //static int Power(int number)
        //{
        //    return number * number;
        //}

        //-------------------------------------------------------------
        //Task3

        //public static Predicate<int> pre;
        //static void Main(string[] args)
        //{
        //    pre += Even;
        //    List<int> list = new List<int>() { 1, 2, 3, 4 };
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (Even(list[i]))
        //        {
        //            Console.WriteLine(list[i]);
        //        }
        //    }
        //}
        //static bool Even(int number)
        //{
        //    return number % 2 == 0;
        //}

        //-------------------------------------------------------------
        //Task4
        //public static Action<int> action;
        //static void Main(string[] args)
        //{
        //    action += Increment;
        //    List<int> list = new List<int>() { 1, 2, 3, 4 };
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        action(list[i]);
        //    }
        //}
        //static void Increment(int number)
        //{
        //    Console.WriteLine(number + 1);
        //}


        //-------------------------------------------------------------
        //Task5

        //public static Action<int> action1;
        //public static Action<string> action2;
        //static void Main(string[] args)
        //{
        //    action1 += Increment;
        //    action2 += AddMr;
        //    action1+= AddSalary;
        //    ArrayList list = new ArrayList();
        //    list.Add(action1);
        //    list.Add(action2);
        //}
        //static void Increment(int number)
        //{
        //    Console.WriteLine(number + 1);
        //}
        //static void AddMr(string name)
        //{
        //    Console.WriteLine($"Mr {name}");
        //}
        //static void AddSalary(int number)
        //{
        //    Console.WriteLine($"New salary: {number + 2000}");
        //}




        //-------------------------------------------------------------
        //Task6

        //public static Predicate<string> pre;
        //static void Main(string[] args)
        //{
        //    List<string> list = new List<string>() { "sdsff", "asifhfsdfsdf", "sad", "asdf", "sd", "fsdhfasdhfgahsfadfasgfashdhf" };
        //    pre += StringLen;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (pre(list[i]))
        //        {
        //            Console.WriteLine(list[i]);
        //        }
        //    }
        //}
        //static bool StringLen(string str)
        //{
        //    return str.Length >= 5;
        //}


    }
}