using userApplication.Application.ports.output;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Infrastructure.adapters.output.persistance
{
    

    public class DepartmentPersistanceAdapter : DepartmentPersistencePort
    {
        private IDepartmentRepository deptrepository;

        public DepartmentPersistanceAdapter(IDepartmentRepository deptrepository)
        {
            this.deptrepository = deptrepository;
        }

        public  async Task<Department> saveDepartmentDB(Department department)
        {
            int id = await deptrepository.insertdepartment(department);
            department.id = id;
            return department;
        }
    }
}
