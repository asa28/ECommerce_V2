using System;
using System.ComponentModel.DataAnnotations;

namespace V2.BLL.ViewModels
{
    public class ProductVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Category_Id { get; set; }

        public string SerialNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}