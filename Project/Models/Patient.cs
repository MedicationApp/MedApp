using System;

namespace Project.Models
{
    public class Patient : ICheckboxObserver
    {
        public PatientInfo patientInfo { get; set; }
        public List<Medication> medList { get; set; }

        public List<Medication> leftForToday { get; set; }


        public void OnCheckboxChanged(Medication medication)
        {
            if (medication.Selected)
            {
                leftForToday.Remove(medication);
            }
            else
            {
                leftForToday.Add(medication);
            }
        }
    }
}