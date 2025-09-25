using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace LorcanaCardCollector.Models
{
    public class CardsContext : DbContext
    {
        public CardsContext(DbContextOptions<CardsContext> options) : base(options) 
        { 
        }
        public DbSet<Cards> Collection { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cards>().HasData(
                new Cards
                {
                    ID = 1,
                    CardName = "Rhino - Motivational Speaker",
                    GemColor = GemColor.AmberSteel,
                    SetName = "Archazia's Island",
                    Quantity = 1,
                    InADeck = true,
                },

                new Cards
                {
                    ID = 2,
                    CardName = "Perdita - Playful Mother",
                    GemColor = GemColor.AmberSapphire,
                    SetName = "Archazia's Island",
                    Quantity = 1,
                    InADeck = false,
                },

                new Cards
                {
                    ID = 3,
                    CardName = "King Stefan - New Father",
                    GemColor= GemColor.Amber,
                    SetName = "Archazilia's Island",
                    Quantity = 2,
                    InADeck = true,
                }
            );
        }
    }
}
