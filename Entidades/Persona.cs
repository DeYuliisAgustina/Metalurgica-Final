using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string NombreyApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
    }
}
