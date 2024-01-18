using System;

namespace Project.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private bool _selected { get; set; }

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                NotifyObservers();
            }
        }

        private List<ICheckboxObserver> observers = new List<ICheckboxObserver>();
        public MedicationInfo medInfo { get; set; }

        public void AddObserver(ICheckboxObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ICheckboxObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnCheckboxChanged(this);
            }
        }
    }
}