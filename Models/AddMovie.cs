using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Travflix.Models
{
    public class AddMovie
    {
        //This model will be used for shows also
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Icon { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Actor Actor {  get; set; }
        public Producer Producer { get; set; }
    }
}
