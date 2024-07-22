using GameStore.api.Data;
using GameStore.api.Entities;
using GameStore.api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.api.Endpoints;

public static class GenreEndpoints
{
    public static RouteGroupBuilder MapGenreEndPoints(this WebApplication app)
    {

        var group = app.MapGroup("genres").WithParameterValidation();

        //GET /genres
        group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Genre.Select(genre => genre.ToDto()).AsNoTracking().ToListAsync()
        );

        return group;
    }

}
