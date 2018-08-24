using Carelabs.Study.Data.Model.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carelabs.Study.Data.Repositories.Patients
{
    public interface IPatientRepository
    {
        Patient Get(int patientId);

        void Upsert(Patient patient);

        void Delete(int pateintId);
    }
}
