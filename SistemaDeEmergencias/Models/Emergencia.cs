using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeEmergencias.Models
{
    public class Emergencia
    {

        public int folio { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public string OficialTurno { get; set; }

        public string Vigia { get; set; }

        public string RecepcionTelefono { get; set; }

        public string NombreDenunciante { get; set; }

        public string TelefonoDenunciante { get; set; }

        public string DireccionEmergencia { get; set; }

        public string DespachadoPor { get; set; }

        public List<DetalleEmergencia> DetallesEmergencia { get; set; }

        public List<TipoEmergencia> TiposEmergencia { get; set; }

        public List<Dotacion> Dotaciones { get; set; }

    }
}
