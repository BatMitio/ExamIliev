using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; }

    public List<User> Users { get; set; }
}