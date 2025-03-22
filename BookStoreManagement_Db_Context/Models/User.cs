using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Phone]
    public string Phone { get; set; }

    [Required]
    public string Password { get; set; }

    public string Address { get; set; }

    // Relationship: One User can have many Records
    public ICollection<Record> Records { get; set; }
}
