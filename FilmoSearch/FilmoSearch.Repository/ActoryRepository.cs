using FilmoSearch.Entities.Models;
using FilmoSearch.Contracts;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public class ActoryRepository:RepositoryBase<Actor>, IActorRepository
    {
        public ActoryRepository(RepositoryMsSqlContext repositoryMsSqlContext):base(repositoryMsSqlContext)
        {
            
        }
    }
}
