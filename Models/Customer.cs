namespace CustomerManagementApi.Models;
using System.ComponentModel.DataAnnotations;

public class Customer{

    public int Id{get; set;}
[Required(ErrorMessage = "First name is required.")]
[StringLength(50, MinimumLength = 3,
    ErrorMessage = "First name must be between 3 and 50 characters.")]
public string FirstName { get; set; }
  [Required(ErrorMessage = "Last name is required.")]
    public string LastName{get; set;}
[Required(ErrorMessage = "Email is required.")]
[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
public string Email { get; set; }
    public bool Active {get; set;}
    


}