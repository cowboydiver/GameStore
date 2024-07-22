using GameStore.api.Data;
using GameStore.api.Dtos;
using GameStore.api.Entities;
using GameStore.api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.api.Endpoints;

public static class GameEndpoints
{

    const string GetGameEndPointName = "GetGame";

    public static RouteGroupBuilder MapGameEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("games").WithParameterValidation();

        // GET /games
        group.MapGet("/", async (GameStoreContext dbContext) =>

            await dbContext.Games
                .Include(game => game.Genre)
                .Select(game => game.ToGameSummeryDto())
                .AsNoTracking().ToListAsync()
        );

        // GET /games/1
        group.MapGet("/{id}", async (int id, GameStoreContext dbContext) =>
        {

            Game? game = await dbContext.Games.FindAsync(id);

            return game is null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDto());

        }
            ).WithName(GetGameEndPointName);

        // POST /games
        group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) =>
        {

            Game game = newGame.ToEntity();

            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetGameEndPointName, new { id = game.Id }, game.ToGameDetailsDto());
        });

        // PUT /games/1

        group.MapPut("/{id}", async (int id, UpdateGameDto updateGame, GameStoreContext dbContext) =>
        {
            var existingGame = await dbContext.Games.FindAsync(id);

            if (existingGame is null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingGame).CurrentValues.SetValues(updateGame.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE /games/1

        group.MapDelete("/{id}", async (int id, GameStoreContext dbContext) =>
        {

            await dbContext.Games.Where(game => game.Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });
        return group;
    }
}
