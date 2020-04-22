using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
                    MergerLO();
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
            Person[] people = new Person[SIZE];
            int peopleSize = 0;
            ReadToArray(people, ref peopleSize);
            MergeSortArray merger = new MergeSortArray();
            merger.mergeSortArray(people, 0, peopleSize);
            PrintArray(people, peopleSize);
        }
        
        public static void ReadToArray(Person [] people, ref int peopleSize)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string input;
                while((input = reader.ReadLine()) != null && input != "")
                {
                    String []values = input.Split(' ');
                    int heigth = int.Parse(values[0]);
                    int weight = int.Parse(values[1]);
                    people[peopleSize++] = new Person(heigth, weight);
                }
            }
        }
        public static void PrintArray (Person [] people, int peopleSize)
        {
            for (int i = 0; i < peopleSize; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }
        public static void MergerLO ()
        {
            node head = ReadToLinkedList();
            MergeSortList a = new MergeSortList();
            node temp = a.mergeSort(head);
            while (temp != null)
            {
                Console.WriteLine(temp.person.ToString());
                temp = temp.next;
            }
        }

        public static node ReadToLinkedList ()
        {
            node value = null;
            using (StreamReader reader = new StreamReader(path))
            {
                string input;
                while((input = reader.ReadLine()) != null && input != "")
                {
                    String []values = input.Split(' ');
                    int heigth = int.Parse(values[0]);
                    int weight = int.Parse(values[1]);
                    Person a = new Person(heigth, weight);
                    node temp = new node(a);
                    temp.next = value; 
                    value = temp; 
                }
            }
            return value;
        }
    }
}
