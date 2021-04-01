﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace DevCars.API.InputModels
{
    public class AddCustomerInputModel
    {
        public string FullName { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
