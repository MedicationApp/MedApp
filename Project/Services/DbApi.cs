using Project.Models;
namespace Project.Services;
public class DbApi
{
    private Data db;
    public DbApi(Data db_)
    {
        db = db_;
    }
    public Patient? GetPatient(int id)
    {
        return new SearchDb(db).GetPatient(id);
    }

    public List<Patient> GetAllPatientsList()
    {
        return new SearchDb(db).GetAllPatientsList();
    }

    public Medication GetMedication(int id)
    {
        return new SearchDb(db).GetMedication(id);
    }

    public Medication? GetMedication(string name)
    {
        return new SearchDb(db).GetMedication(name);
    }

    public List<Medication> GetAllMedications(Patient patient)
    {
        return new SearchDb(db).GetAllMedications(patient);
    }
}