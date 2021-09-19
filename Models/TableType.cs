using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bilijar.Models
{
    public class TableType
    {
        public int Id { get; set; }
        public short TableFee { get; set; }
        public string Name { get; set; }
    }
}