﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInventory.Models
{
    public class UserModel
    {
        /*
         TODO:Data Annotation Validation can be implemented
             */
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}