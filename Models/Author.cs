using System.ComponentModel.DataAnnotations;
namespace Moment3.Models
{
    public class Author
    {
        //Properties för Author
        public int Id { get; set; }

        [Required]
        public string? AuthName { get; set; }

    }
}
