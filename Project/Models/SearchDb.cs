namespace Project.Models;

public class SearchDb
{
    private Data db;
    public SearchDb(Data db)
    {
    }
    public Patient? GetPatient(int id)
    {
        return db.Patients.FirstOrDefault(patient => patient.Id == id);
    }

    public List<Patient> GetAllPatientsList()
    {
        return db.Patients.ToList();
    }

    public Medication GetMedication(int id)
    {
        return db.Medications.FirstOrDefault(med => med.Id == id);
    }

    public Medication? GetMedication(string name)
    {
        return db.Medications.FirstOrDefault(librarian => librarian.Name == name);
    }

    public List<Medication> GetAllMedications(Patient patient)
    {
        var medications = db.PatientMedications
            .Where(pm => pm.PatientId == patient.Id)  // Assuming 'Id' is the primary key of the 'Patient' entity
            .Select(pm => pm.Med)
            .ToList();

        return medications;
    }
}