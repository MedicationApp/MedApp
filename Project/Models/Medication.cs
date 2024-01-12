using System;

namespace Project.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MedicationInfo medInfo { get; set; }
    }
}