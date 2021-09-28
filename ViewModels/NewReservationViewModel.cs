using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bilijar.Models;

namespace bilijar.ViewModels
{
    public class NewReservationViewModel
    {
        public IEnumerable<TableType> TableTypes { get; set; }
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Choose table")]
        public int TableTypeId { get; set; }
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Choose Date")]
        public DateTime? ReservationDate { get; set; }
    }
}