namespace FilmoSearch.Entities.Facotries
{
    internal class UrlFactory : IUrlFactory
    {
        public string GetUrl(string filmName)
        {
            string path = "C:\\Users\\kerve\\Desktop\\Vids\\src\\StaticFiles\\" + filmName;
            return path;
        }
    }
}
