using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMvc.Models{

    [Table("Employee")]
    public class Employee{

        [Key]
        public String? FullName { get; set;}
        public String? PersonId { get; set;}
        public String? Address { get; set;}
    }
}

