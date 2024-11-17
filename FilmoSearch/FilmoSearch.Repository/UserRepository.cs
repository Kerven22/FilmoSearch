using FilmoSearch.Contracts;
using FilmoSearch.Entities.Models;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public class UserRepository:RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryMsSqlContext repositoryMsSqlContext):base(repositoryMsSqlContext)
        {
            
        }
    }
}
