using System;

namespace GameJamRegistro.Models
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Hobbies { get; set; }
        public bool PagoMatricula { get; set; }
    }
}