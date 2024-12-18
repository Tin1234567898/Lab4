namespace Lab4_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [StringLength(10)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Gender { get; set; }

        public double AverageScore { get; set; }

        public int? FacultyID { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
