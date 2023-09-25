using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InternshipDI.Program;

namespace InternshipDI.Services
{
    internal class Dataclass
    {
        public List<Internship> Internships { get; private set; } = new List<Internship>
        {
            new Internship { Id = 1,
            Name = "dotnet developer",
            Company = new Company { Name = "JMM", Location= "peshawer", Industry ="tech" },
            Details = new InternshipDetails { Salary = 50000, StartDate = DateTime.Parse("2023-12-10"), Skills = new List<string> {"c#","SQL"},  Duration =  8, IsRemote = false },
            Reviews = new List<Review>{ new Review { Rating = 4.9, Comment = "Great internship"} }
            } };

        public List<Internship> FilteredInternships { get; private set; } = new List<Internship>();

        public List<IGrouping<string, Internship>> SearchInternships()
        {
    
            Console.WriteLine("Enter the location (or leave empty to skip): ");
            string locationFilter = Console.ReadLine();
            Console.WriteLine("Enter the industry (or leave empty to skip): ");
            string industryFilter = Console.ReadLine();
            Console.WriteLine("Enter the minimum salary (or leave empty to skip): ");
            int? minSalaryFilter = int.TryParse(Console.ReadLine(), out int minSalary) ? minSalary : (int?)null;

            FilteredInternships = Internships
                .Where(internship =>
                    (string.IsNullOrEmpty(locationFilter) || internship.Company.Location.Equals(locationFilter, StringComparison.OrdinalIgnoreCase))
                    && (string.IsNullOrEmpty(industryFilter) || internship.Company.Industry.Equals(industryFilter, StringComparison.OrdinalIgnoreCase))
                    && (!minSalaryFilter.HasValue || internship.Details.Salary >= minSalaryFilter.Value))
                .ToList();

            var sortedInternships = FilteredInternships
            .OrderByDescending(internship => internship.Reviews.Average(review => review.Rating))
            .ThenByDescending(internship => internship.Details.Salary)
            .ThenBy(internship => internship.Details.Duration)
            .ThenBy(internship => internship.Company.Name)
            .ToList();

            // Grouping  
            IEnumerable<IGrouping<string, Internship>> GroupBy = sortedInternships.GroupBy(s => s.Company.Name);
            return GroupBy.ToList();
            
        }




    }
}
