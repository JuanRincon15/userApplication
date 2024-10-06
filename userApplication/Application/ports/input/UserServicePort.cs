using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface UserServicePort
    {
        public User saveUser(User user);
    }
}
