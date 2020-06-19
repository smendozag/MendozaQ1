/*
 * Sergio Mendoza Gomez  |   smendozagomez@cnm.edu
 * File: MendozaQ1
 * Date: 06//2020
 */
using System;

namespace MendozaQ1
{
    class Program
    {
        static void Main(string[] args)
        {

            string doAgain = "y";
            do
            {
                //instantiate Force
                Force newForce = new Force();

                //inputs and assigning them into the object
                Console.Write("Please type in the name of the first object: ");
                string name1 = Console.ReadLine();

                Console.Write("Please type in the mass of the first object in (Kg): ");
                double  mass = double.Parse(Console.ReadLine());
                newForce.ObjectMass1 = mass;
                newForce.ObjectName1 = name1;

                Console.Write("Please type in the name of the second object: ");
                string name2 = Console.ReadLine();

                Console.Write("Please type in the mass of the second object in (kg): ");
                double mass2 = double.Parse(Console.ReadLine());
                newForce.ObjectMass2 = mass2;
                newForce.ObjectName2 = name2;

                Console.Write("Please type in the distance apart between the objects in (meters): ");
                double distance = double.Parse(Console.ReadLine());
                newForce.Radius = distance;

                Console.WriteLine(newForce);

                //Ask to try again
                Console.WriteLine("Would you like to try again");
                doAgain = Console.ReadLine();

            } while (doAgain == "y");
            Console.WriteLine("Thank You. Have a Nice Day!");

        }
    }
}
