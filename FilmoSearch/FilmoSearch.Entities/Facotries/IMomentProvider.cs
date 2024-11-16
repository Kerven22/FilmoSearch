namespace FilmoSearch.Entities.Facotries
{
    internal interface IMomentProvider
    {
        DateTimeOffset Now { get; }
    }
}
