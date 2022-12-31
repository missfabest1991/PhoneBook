using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }  
        public string Title { get; set; }
        public int Code { get; set; }
    }
}
