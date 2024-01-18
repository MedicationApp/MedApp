using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace Project.Models
{
    public class MedicationInfo
    {
        [Required]
        public MedType medType {get; set;}

        public DosageType? dosageType {get; set;}

        public TimeOfDay? timeOfDay {get; set;}
        
    }

}