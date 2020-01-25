﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {

                var line = Console.ReadLine();
                var parts = line.Split(", ");
                var name = parts[0];
                var age = int.Parse(parts[1]);
                var person = new Person(name, age);
                people.Add(person);
            }
            var conditionString = Console.ReadLine();
            var conditionParameter = int.Parse(Console.ReadLine());

            Func<Person, bool> predicate = p => true;
            if (conditionString == "older")
            {
                predicate = p => p.Age >= conditionParameter; 
            }
            else if(conditionString == "younger")
            {
                predicate = p => p.Age < conditionParameter;
            }
            var filteredPeople = people.Where(predicate);
            var format = Console.ReadLine();
            foreach (var person in filteredPeople)
            {
                if (format == "name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else if (format == "age")
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
        }
        class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }
       
    }
}
