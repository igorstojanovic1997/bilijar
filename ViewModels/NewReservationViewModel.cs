using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bilijar.Models;

namespace bilijar.ViewModels
{
    public class NewReservationViewModel
    {
        public IEnumerable<TableType> TableTypes { get; set; }
        public Reservation Reservation { get; set; }
    }
}