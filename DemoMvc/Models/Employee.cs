using System.ComponentModel.DataAnnotations.Schema;

namespace DEMOMVC.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        public string? Age { get; set; }
        public string? Sex { get; set; }
    }
}