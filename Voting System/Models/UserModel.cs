using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Voting_System.Resources;

namespace Voting_System.Models
{
    public class UserModel
    {
        [Key]
        [ValidateNever]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter Your Name pleze")]
        [MinLength(2, ErrorMessage = "Your Name invalid")]
        [MaxLength(30, ErrorMessage = "Your Name invalid")]
        public string UserName { get; set; } = "";
        [Required(ErrorMessage = "Enter Your Age")]

        [Range(10, 100, ErrorMessage = "Your Age Out Of Range")]

        public int UserAge { get; set; }
        [Required(ErrorMessage = "Enter Your Job")]
        [MaxLength(30)]
        public string UserJob { get; set; } = "";
        [Required(ErrorMessage = "Chose Your Level Of Experience From The List")]
        public string UserExperience { get; set; } = "";
        [Required(ErrorMessage = "You Should Enter Password ")]
        [MaxLength(30, ErrorMessage = "Check Your Password Again")]
        [MinLength(4, ErrorMessage = "Check Your Password Again")]
        public string UserPassword { get; set; } = "";
        [Required(ErrorMessage = "Enter Your Email Adress")]
        [EmailAddress(ErrorMessage = "Check Your Email And Try Again")]
        [MaxLength(35)]
        public string UserEmail { get; set; } = "";
      

    }
}
