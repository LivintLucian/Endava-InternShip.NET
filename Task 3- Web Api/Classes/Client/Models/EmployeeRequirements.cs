﻿using System.Collections.Generic;

namespace Client.Models
{
    public class EmployeeRequirements
    {
        public int Ids { get; set; }

        public double MinimumAge { get; set; }

        public string JobTitle { get; set; }

        public double PricePerHour { get; set; }

        public string JobDescription { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
