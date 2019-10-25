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
    public partial class Pagar : Form
    {
        conexion conector = new conexion();

        string habitacion;

        public Pagar(string Habitacion)
        {
            InitializeComponent();
            habitacion = Habitacion;

            dataGridH.Width = 0;
            dataGridR.Width = 0;

            dataGridH.DataSource = conector.cargarDatos("select * from habitaciones where nombre='H" + habitacion + "';");
            dataGridR.DataSource = conector.cargarDatos("select * from reservaciones where habitacion='"+habitacion+"';");

            txbHabitacion.Text = "H"+habitacion;
            txbHabitacion.ReadOnly=true;
            
            txbEntrada.Text= dataGridR.Rows[0].Cells[2].Value.ToString();
            txbEntrada.ReadOnly = true;

            txbSalida.Text= dataGridR.Rows[0].Cells[3].Value.ToString();
            txbSalida.ReadOnly = true;

            int costo = Int32.Parse(dataGridH.Rows[0].Cells[3].Value.ToString());
            txbCosto.Text = costo.ToString();
            txbCosto.ReadOnly = true;

            string entrada=dataGridR.Rows[0].Cells[2].Value.ToString();
            DateTime fentrada = Convert.ToDateTime(entrada);
            string salida = dataGridR.Rows[0].Cells[3].Value.ToString();
            DateTime fsalida = Convert.ToDateTime(salida);

            TimeSpan dias = fsalida - fentrada;

            txbNoches.Text = dias.Days.ToString();
            txbNoches.ReadOnly = true;

            int total =costo * Int32.Parse(dias.Days.ToString());
            txbTotal.Text=total.ToString();
            txbTotal.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conector.ejecutarquery("delete from reservaciones where habitacion='"+habitacion+"';");
            conector.ejecutarquery("update habitaciones set status='Limpieza' where nombre='H" + habitacion + "';");
            this.Close();
        }
    }
}