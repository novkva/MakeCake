using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Models
{
    public class BiscuitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<CreamDto> Creams { get; set; }
        public List<FillingDto> Fillings { get; set; }

    }
}
