using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;

namespace ALXCSharpCourse.Demo

{
    public class ArraysAndListDemo
    {
        public static void Run()
        {
            int x = 4;
            int[] array1 = new int[7];
            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;



            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };
            Console.WriteLine("array1");
            foreach (int number in array1)
            {
                Console.Write($"{number},");

            }
            Console.WriteLine();
            Console.WriteLine("array2");
            foreach (int number in array2)
            {
                Console.Write($"{number},");

            }
            Console.WriteLine();

            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "Golden Retriver");
            dogArray[1] = new Dog("Azor", "Doberman");
            dogArray[2] = new Dog("Boorek", "Jack Russel Terrier ");

            Dog westieDog = new Dog("Skiper", "HWWT");
            Dog dobermanDog = new Dog("Misio", "Doberman");
            Dog[] dogArray2 = { westieDog, dobermanDog, new Dog("Jack", "Huskey") };
            foreach (Dog dog in dogArray2)
            {
                dog.Present();
                dog.Bark();
            }


        }

        public static void RunList()
        {
            Dog dog1 = new Dog("Mickey", "Golden Retriver");
            Dog dog2 = new Dog("Azor", "Doberman");
            Dog dog3 = new Dog("Boorek", "Jack Russel Terrier ");
            Dog dog4 = new Dog("Jack", "Huskey ");
            //Liat<ListElementClass>listName= new ListElementClass>()
            //List<Dog> dogs = new List<Dog>();
            var dogs = new List<Dog>();
            Console.WriteLine($"List size: {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"List size: {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"List size: {dogs.Count}");
            dogs.Add(dog4);
            Console.WriteLine($"List size: {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"List size: {dogs.Count}");


            foreach (Dog dog in dogs)
            {
                dog.Present();
            }
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(35);
            numbers.Add(121);
            numbers.Add(1200);
            Console.WriteLine(numbers[1]);




        }


    }
}
