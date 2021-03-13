using System;
using System.ComponentModel.DataAnnotations;

namespace V2.BLL.ViewModels
{
    public class CompanyVM
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string FaxNumber { get; set; }
        public DateTime AddedDate { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
    }
}