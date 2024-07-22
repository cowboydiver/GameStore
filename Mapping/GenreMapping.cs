using System.Security.Cryptography.X509Certificates;
using GameStore.api.Dtos;
using GameStore.api.Entities;

namespace GameStore.api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto(
            genre.Id,
            genre.Name
        );
    }
}
