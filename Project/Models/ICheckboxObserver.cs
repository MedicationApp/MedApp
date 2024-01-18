namespace Project.Models
{
    public interface ICheckboxObserver
    {
        void OnCheckboxChanged(Medication medication);
    }
}

