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
    public partial class RegistrarHabitacion : Form
    {
        conexion conector=new conexion();
        public RegistrarHabitacion()
        {
            InitializeComponent();
            dataGridView1.Width = 0;

            /*
            if(conector.abrir()) MessageBox.Show("abierta");
            else MessageBox.Show("no abierta");
            //*/
            /*
            if (conector.cerrar()) MessageBox.Show("cerrada");
            else MessageBox.Show("no cerrada");
            //*/
            //dataGridView1.DataSource = conector.cargarDatos("select * from habitaciones;");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //String consulta = "insert into habitaciones values(" + txbClave.Text + ",'" + txbNombre.Text + "','" + txbDescripcion.Text + "'," + txbTarifa.Text + ",'Libre')";
            String consulta = "insert into habitaciones (nombre,descripcion,tarifa,status) values('" + txbNombre.Text + "','" + txbDescripcion.Text + "'," + txbTarifa.Text + ",'Libre')";
            //String consulta = "insert into habitaciones (nombre,descripcion,tarifa,status) values(nombre='H1',descripcion='Habitacion1',tarifa=100,status='Libre')";

            if (conector.ejecutarquery(consulta))
            {
                //MessageBox.Show("Habitacion registrada");
                Console.WriteLine("Habitacion registrada");
            }
            else
            {
                //MessageBox.Show("Habitacion no registrada");
                Console.WriteLine("Habitacion no registrada");
            }

            //dataGridView1.DataSource = conector.cargarDatos("select * from habitaciones;");

            this.Close();
        }
    }
}
