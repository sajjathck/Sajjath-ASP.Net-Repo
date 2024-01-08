using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movies
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Enter A Movie Name !!")]
        public string? MovieName { get; set; }
        public string? Lang { get; set;}
        //[Range(1800,2030,ErrorMessage="Invalid year")]
        [RegularExpression(@"\d{4}",ErrorMessage ="Year Not Valid")]
        public int ReleaseYear {  get; set; }

        [Required(ErrorMessage = "Enter Actor's Name !!")]
        public string? Actor { get; set; }
        [Required(ErrorMessage = "Enter Director's Name !!")]
        public string? Director { get; set; }
    }
}
