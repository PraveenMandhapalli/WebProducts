using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace WebProducts.Server.Models
{
    public class CurrencyExchangeRate
    {
        [Key]
        public int Id { get; set; } 

        public decimal ExchaneRate { get; set; }   
        
        public string CurrencyCode { get; set; }    

        public DateTime ValidFromDate { get; set; }

        public DateTime ValidToDate { get; set; }
    }
}
