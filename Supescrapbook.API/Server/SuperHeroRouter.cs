using SupesScrapbook.Application.Services;

namespace SupesScrapbook.API.Server;
public static class SuperHeroRouter
{
    public static void MapSuperHeroRoutes(this RouteGroupBuilder group)
    {
        var superHeroGroup = group.MapGroup("/v1/supes/");
        superHeroGroup.MapGet("/", async (ISupeService service) =>
        {
            var response = await service.GetSupeById(1);
            if (response == null) return Results.NotFound();
            return Results.Ok(response);
        });
    }
}