using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Platform.IceTasks.Models;
public class Books
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? BookIsbnNumber { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]

    public DateTime ReleaseDate { get; set; }
    public string? BookAuthor { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}

