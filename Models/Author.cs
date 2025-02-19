using System.ComponentModel.DataAnnotations;
namespace Moment3.Models
{
    public class Author
    {
        //Properties för Author
        public int Id { get; set; }

        [Required(ErrorMessage ="Fyll i författare")]
        [Display(Name ="Författare")]
        public string? AuthName { get; set; }

        public List<Book>? Books { get; set; }

    }
}
