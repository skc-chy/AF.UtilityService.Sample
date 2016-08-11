﻿using System;

namespace AF.UtilityServices.Sample
{
    public sealed class EmployeeEntity
    {
        public Guid EmployeeID { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }

        public Double Salary { get; set; }
    }
}
