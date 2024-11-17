using FilmoSearch.Contracts;
using FilmoSearch.Repository.Contexts;

namespace FilmoSearch.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryMsSqlContext repositoryMsSqlContext;

        private readonly Lazy<IFilmRepository> _filmRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<ICommentRepository> _commentRepository;
        private readonly Lazy<IActorRepository> _actorRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryMsSqlContext repositoryMsSqlContext)
        {
            this.repositoryMsSqlContext = repositoryMsSqlContext;

            _filmRepository = new Lazy<IFilmRepository>(() => new FilmRepository(repositoryMsSqlContext));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(repositoryMsSqlContext));
            _commentRepository = new Lazy<ICommentRepository>(() => new CommentRepository(repositoryMsSqlContext));
            _actorRepository = new Lazy<IActorRepository>(() => new ActoryRepository(repositoryMsSqlContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryMsSqlContext));
        }


        public IFilmRepository Film => _filmRepository.Value;

        public IReviewRepository Review => _reviewRepository.Value;

        public IUserRepository User => _userRepository.Value;

        public ICommentRepository Comment => _commentRepository.Value;

        public IActorRepository Actor => _actorRepository.Value;

        public void Save() => repositoryMsSqlContext.SaveChanges();
    }
}
