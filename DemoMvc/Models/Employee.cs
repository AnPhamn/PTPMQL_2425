using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMOMVC.Models
{
   [ Table ("Employee") ]
    public class Employee : Person
{

    public string? EmployeeID { get; set; }
    public string? Age { get; set; }
}
}