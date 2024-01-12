using System;

namespace Project.Models
{
    public class MedService
    {
        public List<Patient>? patientList { get; set; }

        public void Initialize()
        {
            patientList = new List<Patient>();
        }

        

    }
}