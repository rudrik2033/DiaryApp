using System.ComponentModel.DataAnnotations;

namespace DairyApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter A Title")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please Enter Content")]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please Select Valid Date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
