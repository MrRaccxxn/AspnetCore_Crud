using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEmergencias.Models
{
    public class Dotacion
    {
        public int DotacionID { get; set; }

        public DateTime HoraSalida { get; set; }

        public DateTime LLegadaLugar { get; set; }

        public DateTime EmergenciaControlada { get; set; }

        public DateTime HoraBase { get; set; }

        public List<Voluntario> Voluntarios { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }

    }
}
