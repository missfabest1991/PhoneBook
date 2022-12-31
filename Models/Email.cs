using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }
        public string Title { get; set; }
        public List<EmailType> EmailType { get; set; }
    }


    public enum EmailType
    {
        Personal,
        Company
    }
}
