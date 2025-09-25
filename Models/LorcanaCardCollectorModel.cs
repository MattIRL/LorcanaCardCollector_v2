using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
namespace LorcanaCardCollector.Models
{
    public class LorcanaCardCollectorModel
    {
        [Required(ErrorMessage = "<p class='text.danger'>Please enter some text to search.</p>")]
        public string? CardName { get; set; }
        // This will become a dynamic search return based on the https://lorcana-api.com/
        public string FetchCard()
        {
            string? cardName = CardName;
            string CardResults = "~/Images/rhino-motivational_speaker-large.png";
            return CardResults;
        }
    }
}
// [DatabaseGenerated(DatabaseGeneratiedOption.None)]