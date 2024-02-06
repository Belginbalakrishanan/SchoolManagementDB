using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDatabase.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    
        public double Marks { get; set; } 
    }
}
