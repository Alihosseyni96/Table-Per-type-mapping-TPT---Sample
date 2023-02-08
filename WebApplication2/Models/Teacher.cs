using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Teachers")]
    public class Teacher:Person
    {
        public DateTime HireDate { get; set; }
    }

}
