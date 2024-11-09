using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travflix.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        //[Column(TypeName = "nvarchar[20]")]
        public string FirstName { get; set; }

        //[Column(TypeName = "char[25]")]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public byte[] passwordhash { get; set; }
        public byte[] passwordsalt { get; set; }
    }
}
