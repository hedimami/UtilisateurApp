﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUser.Model
{
  public  class Utilisateur
    {
        public String Id { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public int cin { get; set; }
        public int tel { get; set; }
        public String email { get; set; }
        public String sexe { get; set; }
        public String motdepasse { get; set; }
        public DateTime  datedenaissance { get; set; }
    }
}
