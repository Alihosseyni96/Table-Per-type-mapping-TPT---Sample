using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("People")]
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
