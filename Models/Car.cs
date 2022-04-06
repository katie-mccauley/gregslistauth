using System.ComponentModel.DataAnnotations;

namespace gregslistauth.Models
{
  public class Car
  {
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }
    [Required]
    [MinLength(6)]
    public string Description { get; set; }

    [Range(1950, int.MaxValue)]
    public int? Year { get; set; }

  }
}