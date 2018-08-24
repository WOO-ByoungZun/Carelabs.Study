using Carelabs.Study.Data.Repositories.Patients;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carelabs.Study.Repository.Dummy
{
    public class Module
    {
        private IKernel _kernel;

        public Module(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Initialize()
        {
            Initialize_Patient();
        }

        private void Initialize_Patient()
        {
            _kernel.Bind<IPatientRepository>().To<PatientRepository>();
        }
    }
}
