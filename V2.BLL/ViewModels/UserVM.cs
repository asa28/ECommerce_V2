using System;
using System.ComponentModel.DataAnnotations;

namespace V2.BLL.ViewModels
{ 
    public class UserVM
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Is_Active { get; set; }
    }
}