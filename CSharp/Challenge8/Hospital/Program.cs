using System;

namespace Hospital
{
    public delegate void WeightConvertDelegate(Patient thePatient);
    public class Patient
    {
        public string Name { get; private set; }
        public double WeightPounds { get; private set; }
        public double WeightKilos { get; private set; }
        public bool isAdmittedToHospital { get; set; }
        public Patient(string name, int weight)
        {
            this.WeightPounds = weight;
            this.Name = name;
            this.isAdmittedToHospital = false;
        }
        public static void ConvertToKilos(Patient thePatient)
        {
            thePatient.WeightKilos = thePatient.WeightPounds / 2.2;
            Console.WriteLine($"Weight in kilos is: {thePatient.WeightKilos:c2}kg");
        }
    }
    public class Hospital
    {
        public string HospitalName { get; private set; }
        public int NumberOfPatients { get; private set; }
        public Hospital(string name)
        {
            this.HospitalName = name;
            this.NumberOfPatients = 0;
            Console.WriteLine($"{this.HospitalName} has been created.");
        }
        public void AdmitPatient(Patient newPatient)
        {
            this.NumberOfPatients++;
            newPatient.isAdmittedToHospital = true;
            Console.WriteLine($"Patient: {newPatient.Name} with Weight: {newPatient.WeightPounds}lbs was admitted into {this.HospitalName}. The total number of patients is now {this.NumberOfPatients}");
        }

        public void GetPatientWeight(Patient admittedPatient)
        {
            Console.WriteLine($"{admittedPatient.Name}'s weight in pounds is {admittedPatient.WeightPounds}");
            WeightConvertDelegate convertWeight = Patient.ConvertToKilos;
            convertWeight(admittedPatient);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Welcome to Hospital Simulator!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Creating new hospital...\n");
            Hospital TwoPoint = new Hospital("Two Point Hospital");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Creating new patient...\n");
            Patient Bob = new Patient("Bob", 200);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Admitting Bob to the hospital...\n");
            TwoPoint.AdmitPatient(Bob);
            Console.WriteLine("----------------------------------------");
            TwoPoint.GetPatientWeight(Bob);
        }
    }
}
