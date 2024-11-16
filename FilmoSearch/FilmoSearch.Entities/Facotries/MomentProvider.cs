
namespace FilmoSearch.Entities.Facotries
{
    internal class MomentProvider : IMomentProvider
    {
        public DateTimeOffset Now => DateTimeOffset.UtcNow; 
    }
}
