using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace WebApplication2.Models
{
    [Table("Students")]
    public class Student:Person
    {
        public DateTime enrolmentDate { get; set; }
    }
}
