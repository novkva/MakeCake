using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Models
{
    public class TierDto
    {
        public int Id { get; set; }
        public int Diametr { get; set; }
        public int Position { get; set; }
        public BiscuitDto Biscuit { get; set; }
        public CreamDto Cream { get; set; }
        public FillingDto Filling { get; set; }
    }
}
