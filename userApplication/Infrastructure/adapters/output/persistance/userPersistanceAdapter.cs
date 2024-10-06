using userApplication.Application.ports.output;
using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance
{
    public class userPersistanceAdapter : UserPersistencePort
    {
        public User saveUserDB(User user)
        {
            return user;
        }
    }
}
