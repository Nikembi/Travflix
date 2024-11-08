using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travflix.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ActorPhoto { get; set; }
        [Column(TypeName ="nvarchar[45]")]
        public string ActorName { get; set; }
    }
}
