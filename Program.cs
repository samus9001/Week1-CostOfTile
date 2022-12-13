﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace CostOfTile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal labourSF = 20;
            const decimal labourPH = 86;
            decimal areaDecimal = 0;
            decimal flooringCost = 0;
            decimal labourCost = 0;
            decimal totalCost = 0;
            decimal totalCostRounded = 0;

            while (true)
            {
                Console.WriteLine("What is the shape of the room? Please input one of the following: rectangle, circle, triangle");
                string UserInput = Console.ReadLine();

                if (UserInput != "rectangle" && UserInput != "circle" && UserInput != "triangle")
                {
                    Console.WriteLine("\nThat is not a valid option\n");
                    continue;
                }

                Console.WriteLine("\nEnter the cost of flooring per square foot");
                decimal cost = Convert.ToDecimal(Console.ReadLine());

                if (UserInput == "rectangle")
                {
                    //user is prompted to enter a value for width and length
                    Console.WriteLine("\nEnter the width of the room flooring");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nEnter the length of the room flooring");
                    double length = Convert.ToDouble(Console.ReadLine());

                    //formula to calculate the square foot area of a rectangle
                    double area = (length * width);
                    areaDecimal = Convert.ToDecimal(area);
                }

                if (UserInput == "circle")
                {
                    //user is prompted to enter a value for the radius of the circle
                    Console.WriteLine("\nEnter the radius of the room flooring");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    //calculate the radius squared
                    double radiusSquared = radius * radius;

                    //formula to calculate the square foot area of a circle
                    double area = (Math.PI * radiusSquared);
                    areaDecimal = Convert.ToDecimal(area);
                }

                if (UserInput == "triangle")
                {
                    //user is prompted to enter a value for base length and height
                    Console.WriteLine("\nEnter the base length of the room flooring");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nEnter the height of the room flooring");
                    double height = Convert.ToDouble(Console.ReadLine());

                    //formula to calculate the square foot area of a triangle
                    double area = ((1.0 / 2.0) * length * height);
                    areaDecimal = Convert.ToDecimal(area);
                }

                //formula to calculate the cost of flooring
                flooringCost = (areaDecimal * cost);

                //formula to calculate the total labourCost
                labourCost = (areaDecimal / labourSF) * labourPH;
                totalCost = flooringCost + labourCost;

                //outputs the total cost to the user
                totalCostRounded = Math.Round(totalCost, 2);
                Console.WriteLine($"\nThe total cost to cover the flooring for the room is £{totalCostRounded}");
                break;
            }
        }
    }
}