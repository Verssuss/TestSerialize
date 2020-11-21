using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using NETClass;
using System.Dynamic;

namespace TestSerialize
{
    class Program
    {

      
        static void Main(string[] args)
        {
            Person tom = new Person() { Name = "Tom", Age = 35, Money = 3242.324M };
            var str = Serializer.Serialize(tom);
            Console.WriteLine(str);
            var restoredPerson = Serializer.Deserialize<Person>(str);
            Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Money { get; set; }
    }
}
