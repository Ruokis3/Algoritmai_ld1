using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace myapp
{
    class Program
    {
        static string path = @"../data/data1.txt";
        const int SIZE = 100000;
        static void Main(string[] args)
        {
            if (args.Count() != 2)
            {
                Console.WriteLine("Wrong amount of arguments used");
                return;
            }
            int n = int.Parse(args[1]);
            switch (args[0])
            {
                case "AO":
                    MergerAO(n);
                    break;
                case "AD":
                    
                    break;
                case "LO":
                    MergerLO(n);
                    break;
                case "LD":
                    break;
                default:
                    Console.WriteLine("Wrong argument");
                    break;
            }
        }
        public static void MergerAO (int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            Person[] people = new Person[SIZE];
            int peopleSize = 0;
            ReadToArray(people, ref peopleSize, n);
            MergeSortArray merger = new MergeSortArray();
            stopWatch.Start();
            merger.mergeSortArray(people, 0, peopleSize);
            stopWatch.Stop();
            PrintArray(people, peopleSize);
            Console.WriteLine(stopWatch.Elapsed.ToString());
            Console.WriteLine(merger.arrOperations);
        }
        
        public static void ReadToArray(Person [] people, ref int peopleSize, int n)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string input;
                int i = 0;
                while((input = reader.ReadLine()) != null && input != "" && i < n)
                {
                    String []values = input.Split(' ');
                    int heigth = int.Parse(values[0]);
                    int weight = int.Parse(values[1]);
                    people[peopleSize++] = new Person(heigth, weight);
                    i++;
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
        public static void MergerLO (int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            node head = ReadToLinkedList(n);
            MergeSortList a = new MergeSortList();
            stopWatch.Start();
            node temp = a.mergeSort(head);
            stopWatch.Stop();
            while (temp != null)
            {
                Console.WriteLine(temp.person.ToString());
                temp = temp.next;
            }
            Console.WriteLine(stopWatch.Elapsed.ToString());
            Console.WriteLine(a.listOperations);
        }

        public static node ReadToLinkedList (int n)
        {
            node value = null;
            using (StreamReader reader = new StreamReader(path))
            {
                string input;
                int i = 0;
                while((input = reader.ReadLine()) != null && input != "" && i < n)
                {
                    String []values = input.Split(' ');
                    int heigth = int.Parse(values[0]);
                    int weight = int.Parse(values[1]);
                    Person a = new Person(heigth, weight);
                    node temp = new node(a);
                    temp.next = value; 
                    value = temp; 
                    i++;
                }
            }
            return value;
        }
    }
}
