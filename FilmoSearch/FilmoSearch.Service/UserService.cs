using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

namespace FilmoSearch.Service
{
    public sealed class UserService : IUserService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
        }
    }
}
