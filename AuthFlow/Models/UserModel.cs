using System.ComponentModel.DataAnnotations;
using AuthFlow.Enums;

namespace AuthFlow.Models;

public class UserModel
{
    [Key]
    public int IdUser { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public TypeUserEnum TypeUser { get; set; }
    public GenderEnum Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Password { get; set; }
}