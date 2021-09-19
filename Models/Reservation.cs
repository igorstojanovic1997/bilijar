using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bilijar.Models
{
    public class Reservation
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Choose table")]
        public int TableTypeId { get; set; }
        public TableType TableType { get; set; }


        //public ApplicationUser User { get; set; }
        
        //public string UserId { get; set; }

        [Required]
        [Display(Name ="Choose Date")]
        public DateTime? ReservationDate { get; set; }
    }
}