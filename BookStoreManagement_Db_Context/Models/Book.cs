using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public string Genre { get; set; }

    public string Publication { get; set; }

    public int PublishedYear { get; set; }

    // Relationship: One Book can have many Records
    public ICollection<Record> Records { get; set; }
}
