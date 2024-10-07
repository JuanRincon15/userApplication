using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface UserServicePort
    {
        public Task<User> saveUser(User user);
    }
}
