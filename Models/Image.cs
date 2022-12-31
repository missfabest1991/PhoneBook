using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }    
        public string Address { get; set; }
    }
}
