using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InternshipDI.Program;

namespace InternshipDI.Services
{
    internal class ChooseService
    {
        public List<IGrouping<string, Internship>> SearchInternships {get; }
    }
}
