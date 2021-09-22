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

        public string Name { get; set; }

        public string TableType { get; set; }

        public DateTime? ReservationDate { get; set; }
        public string UserEmail { get; set; }
    }
}