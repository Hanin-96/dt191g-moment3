using System.ComponentModel.DataAnnotations;

namespace Moment3.Models
{
    public class Book
    {
        //Properties för Book
        public int Id { get; set; }

        [Required(ErrorMessage = "Fyll i titel på boken")]
        [Display(Name = "Boktitel")]
        public string? Title { get; set; }

        [Display(Name = "Beskrivning")]
        public string? Description { get; set; }

        //Koppla Author till books
        [Display(Name = "Författare")]
        public int? AuthorId { get; set; }
        [Display(Name = "Författare")]
        public Author? Author { get; set; }





    }
}
