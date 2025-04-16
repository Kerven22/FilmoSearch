namespace Domain.Exveptions
{
    public class FilmNotFoundExcetion:Exception
    {
        public FilmNotFoundExcetion(string title) : base($"Film with name {title} not foun!") { }
    }
}
