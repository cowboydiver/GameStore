using System.ComponentModel.DataAnnotations;

namespace GameStore.api.Dtos;

public record class GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);