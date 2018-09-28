﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Assignment_1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
    }
}