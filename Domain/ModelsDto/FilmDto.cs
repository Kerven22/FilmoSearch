namespace Domain.ModelsDto
{
    public record FilmDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateOnly CreationDateDto { get; set; }
    }
}
