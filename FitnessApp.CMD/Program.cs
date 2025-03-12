using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.BL.Controller;

namespace FitnessApp.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is FitnessApp.");
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your gender: ");
            var gender = Console.ReadLine();

            Console.Write("Enter your birth date: ");
            var birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter your weight: ");
            var weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
