using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebloginNew.Models
{

    public class User
    {
        [Required]
        [Display(Name ="User ID")]
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User First name is required")]
        public String Fname { get; set; }
        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "User Last name is required")]
        public string Lname { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "User Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public int Password { get; set; }
        [Compare("Password", ErrorMessage = "Please Confirm Password")]
        [DataType(DataType.Password)]

        [Display(Name = "Confirm Password")]
        public int CPasword { get; set; }

    }
}