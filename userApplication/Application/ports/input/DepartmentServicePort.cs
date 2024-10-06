using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface DepartmentServicePort
    {
        public Department saveDepartment(Department department);
    }
}
