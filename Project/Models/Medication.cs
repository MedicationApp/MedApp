using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
        [ForeignKey("MedicationInfo")] public int medInfoId;
        public MedicationInfo medInfo { get; set; }
    }
}