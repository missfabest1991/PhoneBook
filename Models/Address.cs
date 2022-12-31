using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// using PhoneBook.Models.Address;

namespace PhoneBook.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressDsc { get; set; } 
        public int IdCity { get; set; }
        [ForeignKey("City")]
        public virtual City? City { get; set; }
        public List<AddressType> AddressType { get; set; }

    }


    public enum AddressType
    {
            Home,
            Work
    }
}
