using InternshipDI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;

namespace InternshipDI
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
        var data = new Dataclass();
            var internshipManager = new AppServices(data);
            string Password = "MUQ123";
            Console.WriteLine("Enter password..");
            string input = Console.ReadLine();

            if (input == Password)
            {
                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    //Console.WriteLine("1. Add Internship");
                    Console.WriteLine("1. Search Internships");

                    Console.WriteLine("2. Exit");

                    



                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        
                        case "1":
                            internshipManager.Searching();
                            //Console.WriteLine("two");
                            break;
                       
                        case "2":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;

                    }
                }


            }


            else
            {
                Console.WriteLine("password is invalid ! try again ");
            }

            

                    } } }
    

