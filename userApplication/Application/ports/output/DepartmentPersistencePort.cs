using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface DepartmentPersistencePort
    {
        public Department saveDepartmentDB(Department department);
    }
}
