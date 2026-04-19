namespace SupesScrapbook.Infrastructure.Documents;

public class SupeDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("id")]
    public int HeroId { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("slug")]
    public string Slug { get; set; }

    [BsonElement("powerstats")]
    public PowerstatsDocument Powerstats { get; set; }

    [BsonElement("appearance")]
    public AppearanceDocument Appearance { get; set; }

    [BsonElement("biography")]
    public BiographyDocument Biography { get; set; }

    [BsonElement("work")]
    public WorkDocument Work { get; set; }

    [BsonElement("connections")]
    public ConnectionsDocument Connections { get; set; }

    [BsonElement("images")]
    public ImagesDocument Images { get; set; }
}

public class PowerstatsDocument
{
    [BsonElement("intelligence")]
    public int Intelligence { get; set; }

    [BsonElement("strength")]
    public int Strength { get; set; }

    [BsonElement("speed")]
    public int Speed { get; set; }

    [BsonElement("durability")]
    public int Durability { get; set; }

    [BsonElement("power")]
    public int Power { get; set; }

    [BsonElement("combat")]
    public int Combat { get; set; }
}

public class AppearanceDocument
{
    [BsonElement("gender")]
    public string Gender { get; set; }

    [BsonElement("race")]
    public string Race { get; set; }

    [BsonElement("height")]
    public string[] Height { get; set; }

    [BsonElement("weight")]
    public string[] Weight { get; set; }

    [BsonElement("eyeColor")]
    public string EyeColor { get; set; }

    [BsonElement("hairColor")]
    public string HairColor { get; set; }
}

public class BiographyDocument
{
    [BsonElement("fullName")]
    public string FullName { get; set; }

    [BsonElement("alterEgos")]
    public string AlterEgos { get; set; }

    [BsonElement("aliases")]
    public string[] Aliases { get; set; }

    [BsonElement("placeOfBirth")]
    public string PlaceOfBirth { get; set; }

    [BsonElement("firstAppearance")]
    public string FirstAppearance { get; set; }

    [BsonElement("publisher")]
    public string Publisher { get; set; }

    [BsonElement("alignment")]
    public string Alignment { get; set; }
}

public class WorkDocument
{
    [BsonElement("occupation")]
    public string Occupation { get; set; }

    [BsonElement("base")]
    public string Base { get; set; }
}

public class ConnectionsDocument
{
    [BsonElement("groupAffiliation")]
    public string GroupAffiliation { get; set; }

    [BsonElement("relatives")]
    public string Relatives { get; set; }
}

public class ImagesDocument
{
    [BsonElement("xs")]
    public string Xs { get; set; }

    [BsonElement("sm")]
    public string Sm { get; set; }

    [BsonElement("md")]
    public string Md { get; set; }

    [BsonElement("lg")]
    public string Lg { get; set; }
}
