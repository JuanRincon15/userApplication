using userApplication.Application.ports.output;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Infrastructure.adapters.output.persistance
{
    public class userPersistanceAdapter : UserPersistencePort
    {
        IUserRepository repository;

        public userPersistanceAdapter(IUserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<User> saveUserDB(User user)
        {
            int id = await repository.insertUser(user);
            user.id = id;
            return user;
        }
    }
}
