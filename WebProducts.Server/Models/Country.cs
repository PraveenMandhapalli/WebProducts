using System.ComponentModel.DataAnnotations;

namespace WebProducts.Server.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
    }
}
