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
    public partial class Editar : Form
    {
        conexion conector = new conexion();
        public Editar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String consulta = "UPDATE habitaciones SET nombre ='"+ txbNombre.Text+"', descripcion ='" + txbDescripcion.Text + "', tarifa ='"+txbTarifa.Text+"' WHERE nombre=+'"+txbNombre.Text+"'";


            if (conector.ejecutarquery(consulta))
            {
                MessageBox.Show("Habitacion editada");
            }
            else
            {
                MessageBox.Show("Habitacion no editada");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            String consulta = "delete from habitaciones where nombre='"+ txbNombre.Text + "'";


            if (conector.ejecutarquery(consulta))
            {
                MessageBox.Show("Habitacion borrada");
            }
            else
            {
                MessageBox.Show("Habitacion no borrada");
            }
        }
    }
}
