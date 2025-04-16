using Domain.UseCases.UserUseCases;
using Entity.Repositories;

namespace Entity.Storages
{
    public class UserStorage:IUserStorage
    {
        private readonly MsDatabaseContext _msDatabaseContext;

        public UserStorage(MsDatabaseContext msDatabaseContext)
        {
            _msDatabaseContext = msDatabaseContext;
        }
    }
}
