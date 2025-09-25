using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LorcanaCardCollector.Models
{

    public enum GemColor
    {
        // Single colors
        Amber,
        Amethyst,
        Emerald,
        Ruby,
        Sapphire,
        Steel,

        // Two-color combinations
        [Display(Name ="Amber Amethyst")]
        AmberAmethyst,
        [Display(Name = "Amber Emerald")]
        AmberEmerald,
        [Display(Name = "Amber Ruby")]
        AmberRuby,
        [Display(Name = "Amber Sapphire")]
        AmberSapphire,
        [Display(Name = "Amber Steel")]
        AmberSteel,
        [Display(Name = "Amethyst Emerald")]
        AmethystEmerald,
        [Display(Name = "Amethyst Ruby")]
        AmethystRuby,
        [Display(Name = "Amethyst Sapphire")]
        AmethystSapphire,
        [Display(Name = "Amethyst Steel")]
        AmethystSteel,
        [Display(Name = "Emerald Ruby")]
        EmeraldRuby,
        [Display(Name = "Amethyst Sapphire")]
        EmeraldSapphire,
        [Display(Name = "Amethyst Steel")]
        EmeraldSteel,
        [Display(Name = "Ruby Sapphire")]
        RubySapphire,
        [Display(Name = "Ruby Steel")]
        RubySteel,
        [Display(Name = "Sapphire Steel")]
        SapphireSteel, 
    }
    public class Cards
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Card Name")]
        [StringLength(100, ErrorMessage ="Please enter a card name using 100 characters or less.")]
        public string? CardName { get; set; }

        [Required]
        [Display(Name = "Gem Color Identity")]
        public GemColor GemColor { get; set; }

        [Required]
        [Display(Name = "Set Name")]
        [StringLength(100, ErrorMessage ="Please enter a set name using 100 characters or less.")]
        public string? SetName { get; set; }

        [Required]
        [Display(Name = "Number Owned")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a quantity greater than zero.")]
        public int Quantity { get; set; }
        [Display(Name = "In a Deck")]
        public bool InADeck { get; set; }
    }
}
