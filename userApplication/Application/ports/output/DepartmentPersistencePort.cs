using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface DepartmentPersistencePort
    {
        public Task<Department> saveDepartmentDB(Department department);
    }
}
