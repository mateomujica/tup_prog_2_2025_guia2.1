using Ejercicio_Automotor.Models;

namespace Ejercicio_Automotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular depRegistros = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form2 registar = new Form2();


            if (registar.ShowDialog() == DialogResult.OK)
            {
                string dni = registar.tbxDNI.Text;

                string nombre = registar.tbxNombre.Text;

                Persona propietario = new Persona(dni, nombre);

                RegistroVehiculo registro = depRegistros.RegistrarVehiculo(propietario);

                lsbRegistrar.Items.Add(registro.Patente);
                lsbRegistrar.Items.Add(registro.Serie);
                lsbRegistrar.Items.Add($"{propietario.DNI}-{propietario.Nombre}");
            }
            

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (int i=0; i< depRegistros.CantidadRegistros; i++)
            {
                RegistroVehiculo registro = depRegistros.VerRegistro(i);
                lsbListar.Items.Add(registro.VerDetalle());
            }
        }
    }
}
