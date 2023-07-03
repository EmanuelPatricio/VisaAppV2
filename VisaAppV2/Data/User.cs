using System.ComponentModel.DataAnnotations;

namespace VisaAppV2.Data;

public class User
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid option.")]
    public Enums.DocumentType DocumentType { get; set; }

    [Required]
    [StringLength(11, MinimumLength = 9, ErrorMessage = "Document number must have 9 or 11 characters.")]
    public string DocumentNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(30, MinimumLength = 7, ErrorMessage = "Name length must be greater than or equal 7 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(30, MinimumLength = 7, ErrorMessage = "Lastname length must be greater than or equal 7 characters.")]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateOnly BornDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid option.")]
    public Enums.Gender Gender { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "Must be 10 characters long", MinimumLength = 10)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email.")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid option.")]
    public Enums.MaritalStatus MaritalStatus { get; set; }

    [Required]
    public string DocumentImage { get; set; } = string.Empty;
}
