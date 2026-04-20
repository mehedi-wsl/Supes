namespace SupesScrapbook.Domain.Entities;

public class Supe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public Powerstats Powerstats { get; set; }
    public Appearance Appearance { get; set; }
    public Biography Biography { get; set; }
    public Work Work { get; set; }
    public Connections Connections { get; set; }
    public Images Images { get; set; }
}

public class Powerstats
{
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }
    public int Durability { get; set; }
    public int Power { get; set; }
    public int Combat { get; set; }
}

public class Appearance
{
    public string Gender { get; set; }
    public string Race { get; set; }
    public string[] Height { get; set; }
    public string[] Weight { get; set; }
    public string EyeColor { get; set; }
    public string HairColor { get; set; }
}

public class Biography
{
    public string FullName { get; set; }
    public string AlterEgos { get; set; }
    public string[] Aliases { get; set; }
    public string PlaceOfBirth { get; set; }
    public string FirstAppearance { get; set; }
    public string Publisher { get; set; }
    public string Alignment { get; set; }
}

public class Work
{
    public string Occupation { get; set; }
    public string Base { get; set; }
}

public class Connections
{
    public string GroupAffiliation { get; set; }
    public string Relatives { get; set; }
}

public class Images
{
    public string Xs { get; set; }
    public string Sm { get; set; }
    public string Md { get; set; }
    public string Lg { get; set; }
}
