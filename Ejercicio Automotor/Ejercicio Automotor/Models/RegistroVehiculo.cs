using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Automotor.Models
{
    internal class RegistroVehiculo
    { 
        public string Patente { get; }
        public string Serie { get; }
        public Persona Propietario { get; }
        public RegistroVehiculo (string patente,Persona propietario, int serie)
        {
            Patente = patente;
            Serie = serie.ToString("0000");
            Propietario=propietario;

        }

            public string VerDetalle()
        {
            return $"Patente: {Patente} Serie: {Serie} / Propietario: {Propietario.Nombre} - {Propietario.DNI}";
        }
    }

    
}
