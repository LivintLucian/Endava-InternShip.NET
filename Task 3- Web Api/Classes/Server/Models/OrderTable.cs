using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class OrderTable
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [MaxLength(ErrorMessage = "First name supposed to be max 32 characters")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd")]
        public DateTime? ReservationTime { get; set; }

        public int DinnerGuests { get; set; }

        public int RestaurantBranchId { get; set; }
    }
}