using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        public string Title { get; set; }

        public int Code { get; set; }
    }
}
