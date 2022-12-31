using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public int PhoneNummber { get; set; }
        public string CityCode { get; set; }
        public List<PhoneType> PhoneType { get; set; }
    }
    public enum PhoneType
    {
           Mobile,
           Home,
           office
    }

}
