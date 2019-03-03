using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webAPIwithASPDotNETCore_MVC.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public string Id { get; set; }
        [Display(Name = "User Name")]
        [Required]
        [StringLength(255, MinimumLength =2)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        [StringLength(2000, MinimumLength = 2)]
        public string FullName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [StringLength(255, MinimumLength = 2)]
        public string Email { get; set; }
        [Display(Name = "Mobile No.")]
        public string Mobile { get; set; }
        [Display(Name = "User Role")]
        public string UserRole { get; set; }
        [Display(Name = "Remember Me")]
        public bool Remember { get; set; }
        [Display(Name = "Not in used")]
        public bool NotInUsed { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 2)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [FileExtensions(Extensions = "jpg",ErrorMessage = "Specify a JPG file. (Comma-separated values)")]
   
        

    }
}