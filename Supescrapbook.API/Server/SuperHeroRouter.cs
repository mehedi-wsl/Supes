namespace Supescrapbook.API.Server;

public static class SuperHeroRouter
{
    public static void MapSuperHeroRoutes(this RouteGroupBuilder group)
    {
        var superHeroGroup = group.MapGroup("/v1/supes/");
        superHeroGroup.MapGet("/", () => "Hello World");
    }
}