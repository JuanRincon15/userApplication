using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface UserPersistencePort
    {
        public User saveUserDB(User user);
    }
}
