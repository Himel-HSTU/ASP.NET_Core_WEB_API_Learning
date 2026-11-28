using System.ComponentModel.DataAnnotations;

namespace ProtectingApi.Models
{
    public class UserModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Id must be a non-negative integer.")]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long.")]
        [MaxLength(15, ErrorMessage = "First name cannot exceed 15 characters.")]
        public string FirstName { get; set; }


        [Required]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long.")]
        [MaxLength(15, ErrorMessage = "Last name cannot exceed 15 characters.")]
        public string LastName { get; set; } 
        
        
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }


        [Phone]
        public string PhoneNumber { get; set; }


        [Url]
        public string PortfolioWebsite { get; set; }



        [Range(0, 20, ErrorMessage = "Number of vehicles must be a non-negative integer.")]
        public int NumberOfVehicle { get; set; }    
    }   
}
