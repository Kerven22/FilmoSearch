using FilmoSearch.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmoSearch.Repository.Configuration
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasMany(f => f.Actors)
                .WithMany(f => f.Films);
        }
    }
}
