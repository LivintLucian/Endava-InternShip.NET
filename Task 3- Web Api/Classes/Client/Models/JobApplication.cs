﻿using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        [Display(Name = "Phone numberr"), DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your adress")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select a job title.")]
        public int EmployeeRequirementsId { get; set; }

        [Display(Name = "Job titlee")]
        public virtual EmployeeRequirements EmployeeRequirements { get; set; }
    }
}
