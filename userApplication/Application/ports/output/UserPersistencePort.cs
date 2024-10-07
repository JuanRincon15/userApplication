using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface UserPersistencePort
    {
        public Task<User> saveUserDB(User user);
    }
}
