using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using bilijar.Models;

namespace bilijar.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int TableTypeId { get; set; }

        [Required]
        public DateTime? ReservationDate { get; set; }
    }
}