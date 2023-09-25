namespace InternshipDI
{
    partial class Program
    {
        public class Internship
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Company Company { get; set; }
            public InternshipDetails Details { get; set; }
            public List<Review> Reviews { get; set; }
            public string CompanyName { get; set; }
            public IEnumerable<IGrouping<string, Internship>> Industry { get; set; }
        }
} }
    

