// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets celcius temperature from fahrenheit temperature

using System;

class Program
{
    public static void Main(string[] args)
    {
        //this function accept user input
        double fahrenheit;
        double celcius;

        Console.WriteLine("This program gets celcius temperature from fahrenheit temperature.");
        Console.Write("Enter fahrenheit temperature : "); fahrenheit = Convert.ToInt32(Console.ReadLine());

        celcius = (fahrenheit - 32) * 5 / 9;

        // this function prints the result
        Console.WriteLine("\nThe celcius temperature is : " + celcius.ToString("0.00") + " °C ");
        Console.WriteLine("\ndone.");
    }
}