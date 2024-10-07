using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Domain;

namespace userApplication.Application.service
{
    public class DepartmentService : DepartmentServicePort
    {
        private DepartmentPersistencePort persistenceport;

        public DepartmentService(DepartmentPersistencePort persistenceport)
        {
            this.persistenceport = persistenceport;
        }

        public Task<Department> saveDepartment(Department department)
        {
            return persistenceport.saveDepartmentDB(department);
            
        }
    }
}
