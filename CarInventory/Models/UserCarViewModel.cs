using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInventory.Models
{
    public class UserCarViewModel
    {
        public UserCarViewModel()
        {
            Car = new CarModel();
            User = new UserModel();
            Cars = new List<CarModel>();
        }
        public UserModel User { get; set; }
        public List<CarModel> Cars { get; set; }
        public CarModel Car { get; set; }
    }
}