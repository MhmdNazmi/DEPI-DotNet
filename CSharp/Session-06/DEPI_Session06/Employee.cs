using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session06
{
    public enum Gender { M, F }

    public enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,

        SecurityOfficer = Guest | Developer | Secretary | DBA
    }

    internal class Employee
    {


        int _id;
        string _name;
        double _salary;
        Gender _gender;

        public int ID { get { return _id; } set { _id = value > 0? value : _id = 1; } }

        public string Name { get { return _name; } set { _name = value ?? "Unknown"; } }

        public double Salary { get { return _salary; } set {_salary = value > 0 ? value : _salary = 0; } }

        public Gender Gender { get; set; }

        public HiringDate HireDate { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public Employee()
        {
            ID = 1;
            Name = "Unknown";
            Salary = 0;
            Gender = Gender.M;
            SecurityLevel = SecurityLevel.Guest;
            HireDate = new HiringDate();
        }

        public Employee(int id, string name, double salary, Gender gender,
            HiringDate hireDate, SecurityLevel securityLevel)
        {
            ID = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"""
                ID: {ID} 
                Name: {Name}
                Salary {Salary}
                Gender: {Gender}
                HireDate: {HireDate}
                Security Level: {SecurityLevel}
                """;
        }
    }




}
