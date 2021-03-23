using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AddOrder
    {
        [Required]
        public string Book_name { get; set; }
        [Required]
        public string Book_description { get; set; }
        [Required]
        public decimal Book_price { get; set; }
        [Required]
        public string ISBN { get; set; }
    }
}