using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
#nullable disable
    public class User
    {
        public int Userid { get; set; }
        [Required]
        public string Username { get; set; } 
        public string Address { get; set; } 
        [Required]
        [Phone]


        public string MobileNo { get; set; } 
        [Required]
        [EmailAddress]
        public string Emailid { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and confirm password do not match.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}