using FilmoSearch.Contracts;
using FilmoSearch.Entities.Models;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public class ReviewRepository:RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(RepositoryMsSqlContext repositoryMsSqlContext):base(repositoryMsSqlContext)
        {
            
        }
    }
}
