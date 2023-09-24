using System;
namespace HospitalManagementSystem.Structs
{
    public struct Medication
    {
        public string name;
        public string company;
        public string description;

        public Medication(string name, string company, string description)
        {
            this.name = name;
            this.company = company;
            this.description = description;
        }
    }
}
