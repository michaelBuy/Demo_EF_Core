using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EF_Core.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string? NomContact { get; set; }
        public string? PrenomContact{ get; set; }
        public string? EmailContact { get; set; }
        public DateTime Anniversaire { get; set; }
        public int Tel { get; set; }
        public int IdUtilisateur { get; set; }
    }
}
