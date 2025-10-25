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
                    ID = "ARI-001",
                    CardName = "Rhino - Motivational Speaker",
                    GemColor = GemColor.AmberSteel,
                    SetName = "Archazia's Island",
                    Quantity = 1,
                    InADeck = true,
                    ImgUrl = "https://lorcana-api.com/images/rhino/motivational_speaker/rhino-motivational_speaker-large.png"
                },

                new Cards
                {
                    ID = "ARI-002",
                    CardName = "Perdita - Playful Mother",
                    GemColor = GemColor.AmberSapphire,
                    SetName = "Archazia's Island",
                    Quantity = 1,
                    InADeck = false,
                    ImgUrl = "https://lorcana-api.com/images/perdita/playful_mother/perdita-playful_mother-large.png"
                },

                new Cards
                {
                    ID = "AIR-003",
                    CardName = "King Stefan - New Father",
                    GemColor= GemColor.Amber,
                    SetName = "Archazilia's Island",
                    Quantity = 2,
                    InADeck = true,
                    ImgUrl = "https://lorcana-api.com/images/king_stefan/new_father/king_stefan-new_father-large.png"
                }
            );
        }
    }
}
