using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMOMVC.Models
{
   [ Table ("Person")]
    public class Person
{
    [Key]
    public string? CCCDID { get; set; }
    public string? hoVaten { get; set; }
    public string? queQuan { get; set; }
}
}