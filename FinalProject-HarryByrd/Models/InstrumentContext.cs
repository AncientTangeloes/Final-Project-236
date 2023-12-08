using Microsoft.EntityFrameworkCore;

namespace FinalProject_HarryByrd.Models
{
    public class InstrumentContext : DbContext
    {
        public InstrumentContext() { }

        public InstrumentContext(DbContextOptions<InstrumentContext> options) : base(options) { }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "B", Name = "Brass" },
                new Category { CategoryId = "H", Name = "Hybrid" },
                new Category { CategoryId = "K", Name = "Keyboard" },
                new Category { CategoryId = "M", Name = "Misc" },
                new Category { CategoryId = "N", Name = "Psudeoinstrument" },
                new Category { CategoryId = "P", Name = "Percussion" },
                new Category { CategoryId = "S", Name = "String" },
                new Category { CategoryId = "W", Name = "Woodwind" }
            );

            modelBuilder.Entity<Instrument>().HasData(
                new Instrument
                {
                    InstrumentId = 1,
                    Name = "Organ Pipe Mud Dauber's Nest",
                    Year = "45,000,000 BC",
                    Description = "Organ Pipe Mud Dauber nests look like pan flutes. Woah.",
                    CategoryId = "N"
                },
                new Instrument
                {
                    InstrumentId = 2,
                    Name = "Stroviol",
                    Year = "1899",
                    Description = "Product of string and brass copulation.",
                    CategoryId = "H"
                },
                new Instrument
                {
                    InstrumentId = 3,
                    Name = "Cello Banjo",
                    Year = "1889",
                    Description = "Banjo, but big.",
                    CategoryId = "S"
                },
                new Instrument
                {
                    InstrumentId = 4,
                    Name = "Jazzophone",
                    Year = "1920",
                    Description = "Saxy figure, trumpet mechanics, two horns, one with built-in wah wah.",
                    CategoryId = "B"
                },
                new Instrument
                {
                    InstrumentId = 5,
                    Name = "Serpent",
                    Year = "1590",
                    Description = "Trombone-like mouthpiece, woodwind-like tone holes, long curvy body. Snake? Snake?! SNAAAAAAAAAAKE!",
                    CategoryId = "B"
                },
                new Instrument
                {
                    InstrumentId = 6,
                    Name = "Triolin",
                    Year = "1991",
                    Description = "Violin, but three-player.",
                    CategoryId = "S"
                },
                new Instrument
                {
                    InstrumentId = 7,
                    Name = "Loophonium",
                    Year = "1960",
                    Description = "Half euphonium, half lyre, half toilet.",
                    CategoryId = "H"
                },
                new Instrument
                {
                    InstrumentId = 8,
                    Name = "Badgermin",
                    Year = "2011",
                    Description = "It's a theremin inside a badger.",
                    CategoryId = "M"
                },
                new Instrument
                {
                    InstrumentId = 9,
                    Name = "Hyperbass Flute",
                    Year = "2001",
                    Description = "Flute, but REALLY big 4.",
                    CategoryId = "W"
                },
                new Instrument
                {
                    InstrumentId = 10,
                    Name = "Pikasso Guitar",
                    Year = "1984",
                    Description = "42-stringed multi-necked guitar.",
                    CategoryId = "S"
                },
                new Instrument
                {
                    InstrumentId = 11,
                    Name = "Vibraslap",
                    Year = "1967",
                    Description = "Stiff bent wire, one end wooden ball, the other end hollow wooden box with loose metal \"teeth\". Smack ball to rattle.",
                    CategoryId = "P"
                },
                new Instrument
                {
                    InstrumentId = 12,
                    Name = "Quijada",
                    Year = "55,000,000 BC",
                    Description = "Ancestor to the vibraslap, just a fuckin jawbone of a beast of burden or related species. Still smack to rattle.",
                    CategoryId = "P"
                },
                new Instrument
                {
                    InstrumentId = 13,
                    Name = "The Great Stalacpipe Organ",
                    Year = "1956",
                    Description = "A 3.5-acre electrically acutated lithophone in Luray Caverns, Virginia. Tap keys at the console, stalactites get tapped.",
                    CategoryId = "K"
                }
            );
        }
    }
}
