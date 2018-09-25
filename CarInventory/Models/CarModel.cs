using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInventory.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool isNew { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}