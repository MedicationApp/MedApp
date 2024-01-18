using System;

namespace Project.Models
{
    public class Patient : ICheckboxObserver
    {
        public PatientInfo patientInfo { get; set; }
        public List<Medication> medList { get; set; }

        public List<Medication> leftForToday { get; set; }

        public Medication GetMedication(int id)
        {

            return medList.Find(med => med.Id == id);
        }

        public void EditMedication(Medication med)
        {
            int index = medList.FindIndex(m => m.Id == med.Id);
            medList[index] = med;
        }

        public void AddMedication(Medication med)
        {
            medList.Add(med);
        }

        public void DeleteMedication(Medication med)
        {
            medList.Remove(med);
        }

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