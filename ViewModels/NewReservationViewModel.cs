using System;
using System.Collections.Generic;
using bilijar.Models;

namespace bilijar.ViewModels
{
    public class NewReservationViewModel
    {
        public IEnumerable<TableType> TableTypes { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int TableTypeId { get; set; }
        public string UserId { get; set; }
        public DateTime? ReservationDate { get; set; }
    }
}