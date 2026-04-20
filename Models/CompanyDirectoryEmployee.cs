using System;

namespace KJO.PED.Models
{
    public class CompanyDirectoryEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string OfficeExtension { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}".Trim();

        public string SearchIndex => string.Join(" | ", new[]
        {
            FullName,
            Position,
            Section,
            Email,
            PhoneNumber,
            OfficeExtension
        });
    }
}
