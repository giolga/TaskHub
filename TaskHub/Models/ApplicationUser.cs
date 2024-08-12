using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255, ErrorMessage = "The FirstName should have a maximum of 255 characters!")]
        [Display(Name = "First Name")] //Data Annotations
        public string FirstName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The LastName should have a maximum of 255 characters!")]
        public string LastName { get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
        public  string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
