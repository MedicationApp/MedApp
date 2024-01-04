using System;

namespace Project.Models
{
    public class UserState
    {
        private Patient currentPatient {set; get;}

        public void Initialize()
        {
            currentPatient = null;
        }

        public void setUser(Patient patient){
            currentPatient = patient;
            //Console.WriteLine(currentPatient.patientInfo.Name);
        }

        public Boolean isSet(){
            if(currentPatient == null){
                return false;
            }
            return true;
        }


        public Patient getPatient(){
            return currentPatient;
        }
    }
}