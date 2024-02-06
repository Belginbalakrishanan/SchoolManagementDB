using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDatabase.Models
{
    [Table("Classes")]
    public class Classes
    {
        [Key]
        public string? Name { get; set; }    
        public string? Section { get; set; }
    }
}
