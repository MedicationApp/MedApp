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

        public void AddPatient(Patient patient)
        {
            patientList.Add(patient);
        }

        public void DeletePatient(Patient patient)
        {
            patientList.Remove(patient);
        }

        public Patient GetPatient(int id)
        {
            return patientList.Find(patient => patient.patientInfo.Id == id);
        }

        public Medication GetMed(Patient patient, int medId)
        {
            return patient.medList.Find(med => med.Id == medId);
        }

        public void EditMed(Patient patient, Medication med)
        {
            int index = patient.medList.FindIndex(m => m.Id == med.Id);
            patient.medList[index] = med;
        }

        public void AddMed(Patient patient, Medication med)
        {
            med.AddObserver(patient);
            patient.medList.Add(med);
            patient.leftForToday.Add(med);
        }

        public void DeleteMed(Patient patient, Medication med)
        {
            patient.medList.Remove(med);
        }
    }
}