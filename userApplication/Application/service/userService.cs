using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Domain;

namespace userApplication.Application.service
{
    public class userService : UserServicePort
    {
        UserPersistencePort persistenceport {  get; set; }

        public userService(UserPersistencePort persistenceport)
        {
            this.persistenceport = persistenceport;
        }

        public User saveUser(User user)
        {
            return persistenceport.saveUserDB(user);
        }
    }
}
