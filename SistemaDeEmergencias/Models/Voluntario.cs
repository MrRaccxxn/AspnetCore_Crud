using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEmergencias.Models
{
    public class Voluntario
    {
        public int VoluntarioID { get; set; }

        public string NombreVoluntario { get; set; }

        public List<RolEmergencia> RolesEmergencia { get; set; }

    }
}
