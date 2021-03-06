﻿namespace _08.Employee_Data
{
    using System;

    public class EmployeeData
    {
        //// A marketing company wants to keep record of its employees.
        //// Each record would have the following characteristics:

        ////    First name
        ////    Last name
        ////    Age(0...100)
        ////    Gender(m or f)
        ////    Personal ID number(e.g. 8306112507)
        ////    Unique employee number(27560000…27569999)

        //// Declare the variables needed to keep the information for a single employee using appropriate 
        //// primitive data types. Use descriptive names. Print the data at the console.

        //// Example: Input: Amanda -> Output: First name: Amanda

        public static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            float age = 27;
            string gender = "f";
            long personalID = 8306112507;
            int uniqueEmployeeNubmer = 27563571;

            //// Solution with one variable per row:

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNubmer);

            //// Solution with one CW row:

            ////  Console.WriteLine(
            ////      @"First name: {0} \r\nLast name: {1} \r\nAge: {2} \r\nGender: {3} \r\nPersonal ID: {4} \r\nUnique Employee number: {5}",
            //// firstName, 
            //// lastName, 
            //// age, 
            //// gender, 
            //// personalID, 
            //// uniqueEmployeeNubmer);
        }
    }
}