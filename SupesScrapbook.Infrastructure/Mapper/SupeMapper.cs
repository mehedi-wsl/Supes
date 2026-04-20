using SupesScrapbook.Domain.Entities;
using SupesScrapbook.Infrastructure.Documents;

namespace SupesScrapbook.Infrastructure.Mapper;
public static class SupeMapper
{
    public static Supe ToDomain(this SupeDocument supeDocument)
    {
        return new Supe
        {
            Id = supeDocument.Id,
            Name = supeDocument.Name,
            Slug = supeDocument.Slug,
            Powerstats = new Powerstats
            {
                Intelligence = supeDocument.Powerstats.Intelligence,
                Strength = supeDocument.Powerstats.Strength,
                Speed = supeDocument.Powerstats.Speed,
                Durability = supeDocument.Powerstats.Durability,
                Power = supeDocument.Powerstats.Power,
                Combat = supeDocument.Powerstats.Combat
            },
            Appearance = new Appearance
            {
                Gender = supeDocument.Appearance.Gender,
                Race = supeDocument.Appearance.Race,
                Height = supeDocument.Appearance.Height,
                Weight = supeDocument.Appearance.Weight,
                EyeColor = supeDocument.Appearance.EyeColor,
                HairColor = supeDocument.Appearance.HairColor
            },
            Biography = new Biography   
            {
                FullName = supeDocument.Biography.FullName,
                AlterEgos = supeDocument.Biography.AlterEgos,
                Aliases = supeDocument.Biography.Aliases,
                PlaceOfBirth = supeDocument.Biography.PlaceOfBirth,
                FirstAppearance = supeDocument.Biography.FirstAppearance,
                Publisher = supeDocument.Biography.Publisher,
                Alignment = supeDocument.Biography.Alignment            
            },
            Work = new Work
            {
                Occupation = supeDocument.Work.Occupation,
                Base = supeDocument.Work.Base
            },
            Connections = new Connections
            {
                GroupAffiliation = supeDocument.Connections.GroupAffiliation,
                Relatives = supeDocument.Connections.Relatives
            },
            Images = new Images
            {
                Xs = supeDocument.Images.Xs,
                Sm = supeDocument.Images.Sm,
                Md = supeDocument.Images.Md,
                Lg = supeDocument.Images.Lg
            },
        };
    }
}