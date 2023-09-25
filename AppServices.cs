using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InternshipDI.Program;

namespace InternshipDI.Services
{
    internal class AppServices
    {
        private readonly Dataclass dataclass;
        public AppServices(Dataclass dataclass)
        {
            this.dataclass = dataclass;
        }

        public void Searching()
        {
            // the search function 
            var internships = dataclass.SearchInternships().ToList();


            // Display the results as specified in the task
            if (internships.Count == 0)
            {
                Console.WriteLine("No internships match the criteria.");
            }
            else
            {
                foreach (var internship in internships)
                {
                    foreach (var item in internship)
                    {
                        Console.WriteLine($"Id : {item.Id}");
                        Console.WriteLine($"Internship Name: {item.Name}");
                        Console.WriteLine($"Company Name: {item.Company.Name}");
                        Console.WriteLine($"Location: {item.Company.Location}");
                        Console.WriteLine($"Industry: {item.Company.Industry}");
                        Console.WriteLine($"Salary: ${item.Details.Salary}");
                        Console.WriteLine($"Duration: {item.Details.Duration}");
                        Console.Write("Skills: ");
                        foreach (var skills in item.Details.Skills)
                        {
                            Console.Write(skills + ",");
                        }
                        foreach (var rating in item.Reviews)
                        {
                            Console.Write("\nRating : " + rating.Rating + " " + "Comment : " + rating.Comment);
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
