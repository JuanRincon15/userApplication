using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public interface IDepartmentRepository
    {
        Task<int> insertdepartment(Department department);
    }
}
