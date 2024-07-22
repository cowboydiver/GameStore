using System.ComponentModel.DataAnnotations;

namespace GameStore.api.Dtos;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    int GenreId,
    [Required][Range(0, 100)] decimal Price,
    DateOnly ReleaseDate);
