using FilmoSearch.Contracts;
using FilmoSearch.Entities.Models;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public class CommentRepository:RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(RepositoryMsSqlContext repositoryMsSqlContext):base(repositoryMsSqlContext)
        {
            
        }
    }
}
