using System;
using static System.Console;

//Name: James Shoemaker
//Date: 04/04/2020
//Program Description: Week 3 HomeSales assignment part I

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            //You can declare different variables on the same line using a comma as long as they are the same type (int, double, etc.)

            string entryName, entryInitial;
            string z;
            string[] name = { "Danielle", "Danielle", "Edward", "Edward", "Francis", "Francis" };
            string[] initial = { "D", "d", "E", "e", "F", "f" };
            int counter;
            bool found = false;

            Write("Please enter the sales persons initial - enter Z to exit: ");
            entryInitial = ReadLine();

            for (counter = 0; counter < initial.Length && found == false; ++counter)
            {
                if (entryInitial == initial[counter])
                {
                    Write("Enter next sales person initial or Z to exit: ");
                    found = true;

                }

            }
            
            if(found == false)
            {
                WriteLine(" Sorry - invalid salesperson.");
                Write("Enter next sales person initial or Z to exit: ");
                found = true;
            }

           
        }
    }
}
