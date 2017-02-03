﻿namespace _04.Elevator
{
    using System;

    public class Elevator
    {
        //// Calculate how many courses will be needed to elevate "n" persons by using an elevator 
        //// of capacity of "p" persons.The input holds two lines: the number of people "n" 
        //// and the capacity "p" of the elevator.

        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}