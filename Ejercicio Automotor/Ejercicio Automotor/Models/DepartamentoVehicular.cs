using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Automotor.Models
{
    internal class DepartamentoVehicular
    {

       Random random = new Random();


        int totregistrados = 0;
        int totserie = 0;

        ArrayList registros = new ArrayList();

        public int CantidadRegistros  { get 
            { 
                return registros.Count;       
            }
        }


        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            string patente = GenerarPatente();
            int serie = totserie++;
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, propietario, serie);

            registros.Add(nuevo);

            return nuevo; 

        }

        public RegistroVehiculo VerRegistro (int idx)
        {

            if(idx >= 0 && idx < CantidadRegistros)
            {
                return registros[idx] as RegistroVehiculo;
            }
            return null;


        }

        private string GenerarPatente()
        {
            Random random = new Random();      

            char C1 = (char)random.Next((int)'A', (int)'Z' + 1);
            char C2 = (char)random.Next((int)'A', (int)'Z' + 1);

            string patente = $"{C1}{C2}{totregistrados++:000}";

            return patente; 

        }
    }
}
