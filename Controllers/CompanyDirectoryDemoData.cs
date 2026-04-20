using System.Collections.Generic;
using KJO.PED.Models;

namespace KJO.PED.Data
{
    public static class CompanyDirectoryDemoData
    {
        public static List<CompanyDirectoryEmployee> GetEmployees()
        {
            return new List<CompanyDirectoryEmployee>
            {
                new CompanyDirectoryEmployee { Id = 1, FirstName = "Ahmed", LastName = "Al-Harbi", Position = "Data Management Lead", Section = "Data Management and Technology", Email = "ahmed.alharbi@kjo.com.sa", PhoneNumber = "+966 13 555 2101", OfficeExtension = "2101" },
                new CompanyDirectoryEmployee { Id = 2, FirstName = "Noura", LastName = "Al-Dossary", Position = "Digital Solutions Analyst", Section = "Data Management and Technology", Email = "noura.dossary@kjo.com.sa", PhoneNumber = "+966 13 555 2102", OfficeExtension = "2102" },
                new CompanyDirectoryEmployee { Id = 3, FirstName = "Mansour", LastName = "Al-Qahtani", Position = "Data Quality Specialist", Section = "Data Management and Technology", Email = "mansour.qahtani@kjo.com.sa", PhoneNumber = "+966 13 555 2103", OfficeExtension = "2103" },

                new CompanyDirectoryEmployee { Id = 4, FirstName = "Faisal", LastName = "Al-Otaibi", Position = "Reservoir Engineer", Section = "Reservoir Management", Email = "faisal.otaibi@kjo.com.sa", PhoneNumber = "+966 13 555 2201", OfficeExtension = "2201" },
                new CompanyDirectoryEmployee { Id = 5, FirstName = "Rania", LastName = "Al-Saeed", Position = "Senior Reservoir Engineer", Section = "Reservoir Management", Email = "rania.saeed@kjo.com.sa", PhoneNumber = "+966 13 555 2202", OfficeExtension = "2202" },
                new CompanyDirectoryEmployee { Id = 6, FirstName = "Yousef", LastName = "Al-Malki", Position = "Reservoir Surveillance Analyst", Section = "Reservoir Management", Email = "yousef.malki@kjo.com.sa", PhoneNumber = "+966 13 555 2203", OfficeExtension = "2203" },

                new CompanyDirectoryEmployee { Id = 7, FirstName = "Khaled", LastName = "Al-Anazi", Position = "Geoscientist", Section = "Geosciences", Email = "khaled.anazi@kjo.com.sa", PhoneNumber = "+966 13 555 2301", OfficeExtension = "2301" },
                new CompanyDirectoryEmployee { Id = 8, FirstName = "Lamia", LastName = "Al-Fahad", Position = "Exploration Geologist", Section = "Geosciences", Email = "lamia.fahad@kjo.com.sa", PhoneNumber = "+966 13 555 2302", OfficeExtension = "2302" },
                new CompanyDirectoryEmployee { Id = 9, FirstName = "Sara", LastName = "Al-Salem", Position = "Petrophysicist", Section = "Geosciences", Email = "sara.salem@kjo.com.sa", PhoneNumber = "+966 13 555 2303", OfficeExtension = "2303" },

                new CompanyDirectoryEmployee { Id = 10, FirstName = "Huda", LastName = "Al-Mutairi", Position = "Integrated Modeling Engineer", Section = "Integrated Modeling", Email = "huda.mutairi@kjo.com.sa", PhoneNumber = "+966 13 555 2401", OfficeExtension = "2401" },
                new CompanyDirectoryEmployee { Id = 11, FirstName = "Salem", LastName = "Al-Shammari", Position = "Simulation Specialist", Section = "Integrated Modeling", Email = "salem.shammari@kjo.com.sa", PhoneNumber = "+966 13 555 2402", OfficeExtension = "2402" },
                new CompanyDirectoryEmployee { Id = 12, FirstName = "Abdullah", LastName = "Al-Rashid", Position = "Modeling Coordinator", Section = "Integrated Modeling", Email = "abdullah.rashid@kjo.com.sa", PhoneNumber = "+966 13 555 2403", OfficeExtension = "2403" }
            };
        }
    }
}
