using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace Project.Models
{
    public class MedicationInfo
    {
        [Required]
        public string MedType {get; set;}

        public string? DosageType {get; set;}

        public string? TimeOfDay {get; set;}
        
    }

}