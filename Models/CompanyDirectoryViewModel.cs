using System.Collections.Generic;
using KJO.PED.Models;

namespace KJO.PED.ViewModels
{
    public class CompanyDirectoryViewModel
    {
        public List<string> AvailableSections { get; set; } = new();
        public List<CompanyDirectoryEmployee> Employees { get; set; } = new();
    }
}
