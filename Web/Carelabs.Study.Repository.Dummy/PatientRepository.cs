using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carelabs.Study.Data.Model.Patients;
using Carelabs.Study.Data.Repositories.Patients;

namespace Carelabs.Study.Repository.Dummy
{
    public class PatientRepository : IPatientRepository
    {
        static PatientRepository()
        {
            _datas.Add(new Patient() { PatientId = 1, Name = "홍길동1" });
            _datas.Add(new Patient() { PatientId = 2, Name = "홍길동2" });
            _datas.Add(new Patient() { PatientId = 3, Name = "홍길동3" });
        }

        private static List<Patient> _datas = new List<Patient>();


        public Patient Get(int patientId)
        {
            if (_datas.Any(e => e.PatientId == patientId))
            {
                return _datas.First(e => e.PatientId == patientId);
            }

            return null;
        }

        public void Upsert(Patient patient)
        {
            var finded = this.Get(patient.PatientId);

            if (finded != null) _datas.Remove(finded);            
            _datas.Add(patient);            
        }

        public void Delete(int pateintId)
        {
            var finded = this.Get(pateintId);
            if (finded != null) _datas.Remove(finded);
        }
    }
}
