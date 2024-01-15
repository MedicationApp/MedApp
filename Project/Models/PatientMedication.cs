using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Project.Models;

public class PatientMedication
{
    [ForeignKey("Patient")]
    public int PatientId;
    [ForeignKey("Medication")]
    public int MedId;
    [ForeignKey("Medication")]
    public Medication Med;
}