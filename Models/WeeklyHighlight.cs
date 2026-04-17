using System;
using System.ComponentModel.DataAnnotations;

namespace KJO.PED.Models
{
    public class WeeklyHighlight
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        public string? SubmittedBy { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        public bool IsApproved { get; set; } = false;

        public string? ReviewedBy { get; set; }

        public DateTime? ReviewedAt { get; set; }
    }
}
