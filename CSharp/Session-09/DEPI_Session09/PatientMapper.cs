using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session09
{
    public static class PatientMapper
    {
        public static PatientDto MapFromModelToDto(Patient patient)
            => new PatientDto(patient.Id, patient.FullName, patient.PhoneNumber);
    }
}
