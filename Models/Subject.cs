using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Composition;

namespace SchoolDatabase.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int Id { get; set; } 
        public string SubjectName { get; set; }
    }
}
