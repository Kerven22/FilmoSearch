using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

namespace FilmoSearch.Service
{
    public sealed class ReviewService:IReviewService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;

        public ReviewService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
        }
    }
}
