using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session09
{
    public class Patient(int Id, string FullName, string PhoneNumber, string MedicalHistory)
    {
        public int Id { get; set; } = Id;
        public string FullName { get; set; } = FullName;
        public string PhoneNumber { get; set; } = PhoneNumber;
        public string MedicalHistory { get; set; } = MedicalHistory;

        public override string ToString()
            => $"Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} :: MedicalHistory: {MedicalHistory}";
    }
}
