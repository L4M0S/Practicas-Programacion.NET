using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL
{
    public partial class Reservar : Form
    {
        conexion conector = new conexion();

        string habitacion;
        public Reservar(string Habitacion)
        {
            InitializeComponent();
            habitacion = Habitacion;

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string entrada = EntradaAno.Text + "-" + EntradaMes.Text + "-" + EntradaDia.Text;
            string salida = SalidaAno.Text + "-" + SalidaMes.Text + "-" + SalidaDia.Text;

            String consulta = "insert into reservaciones (habitacion,entrada,salida) values('" + habitacion + "','" + entrada + "','" + salida + "')";


            if (conector.ejecutarquery(consulta))
            {
                //MessageBox.Show("Reservada");
                Console.WriteLine("reservada");
                String consulta2 = "update habitaciones set status='Ocupado' where clave='" + habitacion + "';";


                if (conector.ejecutarquery(consulta2))
                {
                    //MessageBox.Show("ocupada");
                    Console.WriteLine("ocupada");
                }
                else
                {
                    //MessageBox.Show("No ocupada");
                    Console.WriteLine("no ocupada");
                }
            }
            else
            {
                //MessageBox.Show("No reservada");
                Console.WriteLine("reservada");
            }

            this.Close();

            
        }
    }
}
