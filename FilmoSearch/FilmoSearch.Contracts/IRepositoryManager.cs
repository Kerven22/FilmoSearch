namespace FilmoSearch.Contracts
{
    public interface IRepositoryManager
    {
        IFilmRepository Film { get; }
        IReviewRepository Review { get; }
        IUserRepository User { get; }
        ICommentRepository Comment { get; }
        IActorRepository Actor { get; }

        void Save(); 
    }
}
