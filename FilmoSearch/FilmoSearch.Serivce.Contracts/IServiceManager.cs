namespace FilmoSearch.Serivce.Contracts
{
    public interface IServiceManager
    {
        IFilmService FilmService { get; }
        IReviewService ReviewService { get; }
        ICommentService CommentService { get; }
        IActorService ActorService { get; }
        IUserService UserService { get; }
    }
}
