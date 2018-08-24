using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Carelabs.Study.Data.Model.Patients;
using Carelabs.Study.Data.Repositories.Patients;
using Carelabs.Study.Repository.Dummy;

namespace Carelabs.Study.Web.Controllers.Apis
{
    public class PatientController : ApiController
    {
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        IPatientRepository _patientRepository;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Patient Get(int id)
        {
            return _patientRepository.Get(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(Patient value)
        {
            _patientRepository.Upsert(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _patientRepository.Delete(id);
        }

        
    }
}