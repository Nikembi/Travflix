using System.ComponentModel.DataAnnotations;

namespace Travflix.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Required]
        public string ActorPhoto { get; set; }
        public string ActorName { get; set; }
    }
}
