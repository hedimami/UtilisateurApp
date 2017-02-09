using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUser.Model
{
   public class Visit
    {
        public String Id  { get; set; }
        public DateTime datedepart { get; set; }
        public DateTime datefin { get; set; }
        public Double budget { get; set; }
        public String idUtilisateur { get; set; }
    }
}
