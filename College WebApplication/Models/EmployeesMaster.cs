
using System.ComponentModel.DataAnnotations;

namespace CollegeWebApplication.Models
{

    public class EmployeesMaster
    {
        [Key]
        public int EmployeesId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Employee Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "Employee City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }

        [Display(Name = "Year of Joining")]
        public DateTime DateOfJoining { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }

        [Display(Name = "Desigation")]
        public string Desigation { get; set; }

        [Required(ErrorMessage = "Please enter employee Salary")]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }
    }
}