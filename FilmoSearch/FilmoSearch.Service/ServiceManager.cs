using AutoMapper;
using FilmoSearch.Contracts;
using FilmoSearch.Serivce.Contracts;

namespace FilmoSearch.Service
{
    public sealed class ServiceManager:IServiceManager
    {
        private readonly Lazy<IFilmService> _filmService;
        private readonly Lazy<IReviewService> _reviewService;
        private readonly Lazy<ICommentService> _commentService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IActorService> _actorService;

        public ServiceManager(IRepositoryManager repositoryManager,  ILoggerManager loggerManager, IMapper mapper)
        {
            _filmService = new Lazy<IFilmService>(() => new FilmService(repositoryManager, loggerManager, mapper));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, loggerManager, mapper));
            _commentService = new Lazy<ICommentService>(() => new CommentService(repositoryManager, loggerManager, mapper));
            _actorService = new Lazy<IActorService>(() => new ActorService(repositoryManager, loggerManager, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, loggerManager, mapper)); 
        }

        public IFilmService FilmService => _filmService.Value;

        public IReviewService ReviewService => _reviewService.Value;

        public ICommentService CommentService => _commentService.Value;

        public IActorService ActorService => _actorService.Value;

        public IUserService UserService => _userService.Value; 
    }
}
