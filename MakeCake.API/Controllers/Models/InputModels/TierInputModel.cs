using System.ComponentModel.DataAnnotations;

namespace MakeCake.API.Controllers.Models.InputModels
{
    public class TierInputModel
    {
        [Required]
        public int Diametr { get; set; }
        [Required]
        public int BiscuitId { get; set; }
        [Required]
        public int CreamId { get; set; }
        [Required]
        public int FillingId { get; set; }
    }
}
