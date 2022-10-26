using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCake.DAL.Models
{
    public class TestDto 
    {
        public int Id { get; set; }
        public FillingDto Filling { get; set; }
        public int Name { get; set; }
        public int Cream { get; set; }
        public int Description { get; set; }
    }
}
