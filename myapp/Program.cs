using System;
using System.IO;
using System.Linq;

namespace myapp
{
    class Program
    {
        static string path = @"../data/data.txt";
        const int SIZE = 1000;
        static void Main(string[] args)
        {
            if (args.Count() != 1)
            {
                Console.WriteLine("Wrong amount of arguments used");
                return;
            }
            switch (args[0])
            {
                case "AO":
                    MergerAO();
                    break;
                case "AD":
                    break;
                case "LO":
                    break;
                case "LD":
                    break;
                default:
                    Console.WriteLine("Wrong argument");
                    break;
            }
        }
        public static void MergerAO ()
        {
            Container people = new Container(SIZE);
            ReadToArray(people);
            Console.WriteLine("Start");
            Console.WriteLine(people.GetPerson(0).Weight);
            Console.WriteLine("End");
        }
        public static void ReadToArray(Container people)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string input;
                while((input = reader.ReadLine()) != null && input != "")
                {
                    String []values = input.Split(' ');
                    int heigth = int.Parse(values[0]);
                    int weight = int.Parse(values[1]);
                    Person person1 = new Person(heigth, weight);
                    people.AddPerson(person1);
                }
            }
        }
    }
}
