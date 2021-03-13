using System.ComponentModel.DataAnnotations;

namespace V2.BLL.ViewModels
{
    public class CategoryVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }
        
        public string Products { get; set; } // comma-seperated string for products
        public string Companies { get; set; } // comma-seperated string for compaines 
    }
}