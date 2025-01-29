using System.ComponentModel.DataAnnotations;

namespace FoodStoreApp.Models
{
    public class Manufactures
    {
        [Key]
        public int ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ManufacturerDescription { get; set; }
    }
}
