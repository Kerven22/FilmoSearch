using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

namespace FilmoSearch.Service
{
    public sealed class ActorService:IActorService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly ILoggerManager loggerManager;

        public ActorService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            this.repositoryManager = repositoryManager;
            this.loggerManager = loggerManager;
        }
    }
}
