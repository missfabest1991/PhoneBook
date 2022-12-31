using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address? Address { get; set; }

        public int PhoneId { get; set; }
        [ForeignKey("PhoneId")]
        public virtual Phone? Phone { get; set; }


       
        public List<Address> AddressDsc { get; set; }
        public List<Phone> PhoneNumber { get; set; }
        public List<Email> Email { get; set; }
    }
}
