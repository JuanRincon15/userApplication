using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface DepartmentServicePort
    {
        public Task<Department> saveDepartment(Department department);
    }
}
