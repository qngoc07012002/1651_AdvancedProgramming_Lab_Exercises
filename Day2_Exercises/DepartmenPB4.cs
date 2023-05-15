using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Exercises
{
    internal class DepartmenPB4
    {
        private string name;
        private List<PatientPB4> listPatient = new List<PatientPB4>();

        public string Name { get { return name; } set { name = value; } }
        public List<PatientPB4> ListPatient { get { return listPatient; } set { listPatient = value; } }

        public DepartmenPB4(string name)
        {
            this.name = name;
        }

        public void addPatientToDepartment(PatientPB4 patient)
        {
            if (listPatient.Count <= 60)
            {
                listPatient.Add(patient);
            }
        }

        public void displayPatientDepartment()
        {
            foreach (var patient in listPatient)
            {
                Console.WriteLine(patient.Name);
            }
        }

        public void displayPatientRoom(int room)
        {
          
            listPatient.Sort((x, y) => string.Compare(x.Name, y.Name));
            for (int i = (room*3)-3; i < room*3; i++)
            {
                Console.WriteLine(listPatient[i].Name);
            }
        }

        public List<PatientPB4> displayPatientDoctor(List<PatientPB4> listPatientDoctor, string doctor)
        {
            
            foreach (var patient in listPatient)
            {
           
                if (patient.Doctor.Equals(doctor))
                {
                    listPatientDoctor.Add(patient);
                }
            }
            return listPatientDoctor;
        }
    }
}
