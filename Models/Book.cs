using System.ComponentModel.DataAnnotations;

namespace Moment3.Models
{
    public class Book
    {
        //Properties för Book
        public int Id { get; set; }

        [Required(ErrorMessage = "Fyll i titel på boken")]
        public string? Title { get; set; }

        public string? Description { get; set; }

        //Koppla Author till books
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }





    }
}
