using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFunc = (name, startsWithString) => name.StartsWith(startsWithString);
            Func<string, string, bool> endsWithFunc = (name, pattern) => name.EndsWith(pattern);

            var names = Console.ReadLine()
                 .Split()
                 .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] splitedCommannd = command.Split(" ");
                string action = splitedCommannd[0];
                string condition = splitedCommannd[1];
                string param = splitedCommannd[2];

                if (action == "Double")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(param);

                        var tempNames = names.Where(name => lengthFunc(name, length)).ToList();
                        names.AddRange(tempNames);

                        foreach (var curreNtname in tempNames)
                        {
                            int index = names.IndexOf(curreNtname);
                            names.Insert(index, curreNtname);
                        }
                    }
                    else if (condition == "StartsWith")
                    {
                        var temp = names.Where(name => startsWithFunc(name, param)).ToList();
                        names.AddRange(temp);
                    }
                    else if (condition == "EndsWith")
                    {
                        var temp = names.Where(name => endsWithFunc(name, param)).ToList();
                        names.AddRange(temp);
                    }
                }
                else if (action == "Remove")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(param);

                        names = names.Where(name => !lengthFunc(name, length)).ToList();
                    }
                    else if (condition == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, param)).ToList();
                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(name => !endsWithFunc(name, param)).ToList();
                    }
                }
            }
            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
    }
}
