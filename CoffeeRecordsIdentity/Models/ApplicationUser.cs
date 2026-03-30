using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoffeeRecordsIdentity.Models;

public class ApplicationUser : IdentityUser
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
