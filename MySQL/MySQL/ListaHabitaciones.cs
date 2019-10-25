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
    public partial class ListaHabitaciones : Form
    {
        int botones=0;

        int x = 50;
        int y = 50;

        List<Button> Botones = new List<Button>();

        conexion conector = new conexion();

        DataGridView dataGrid = new DataGridView();
        

        public ListaHabitaciones()
        {
            InitializeComponent();
            dataGrid.Width = 0;
        }

        void limpiarBotones()
        {
            for (int i = 0; i < Botones.Count; i++)
            {
                this.Controls.Remove(Botones.ElementAt(i));
                Console.WriteLine(i);
            }
            this.Controls.Remove(dataGrid);

            Botones.Clear();

            botones = 0;
            x = 50;
            y = 50;
        }

        void cambiarStatus(int habitacion, string estadoActual)
        {
            Console.WriteLine("Habitacion: " + habitacion +" Estado: "+estadoActual);

            String nuevoEstado="";

            if (estadoActual=="Libre")
            {
                nuevoEstado = "Ocupado";
            }
            else if (estadoActual == "Ocupado")
            {
                nuevoEstado = "Limpieza";
            }
            else if (estadoActual == "Limpieza")
            {
                nuevoEstado = "Mantenimiento";
            }
            else if (estadoActual == "Mantenimiento")
            {
                nuevoEstado = "Libre";
            }

            conector.ejecutarquery("update habitaciones set status='"+nuevoEstado+"' where clave='"+habitacion+"';");

            MostrarBotones();
        }

        void CrearBotones()
        {
            limpiarBotones();

            dataGrid.DataSource = conector.cargarDatos("select * from habitaciones;");
            this.Controls.Add(dataGrid);
            //Console.WriteLine(dataGrid.Rows.Count-1);

            for (int i=1;i<=dataGrid.Rows.Count-1; i++)
            {
                Console.WriteLine(botones % 10);
                if ((botones % 12) == 0) {y = y + 60; x = 50; }
                Button btn = new Button();
                btn.Top = y;
                btn.Left = x;
                btn.Width = 50;
                btn.Height = 50;
                btn.Name = dataGrid.Rows[i - 1].Cells[0].Value.ToString();
                btn.Text = dataGrid.Rows[i-1].Cells[1].Value.ToString();

                if (dataGrid.Rows[i - 1].Cells[4].Value.ToString() == "Libre") btn.BackColor = Color.Green;
                else if (dataGrid.Rows[i - 1].Cells[4].Value.ToString() == "Ocupado") btn.BackColor = Color.Red;
                else if (dataGrid.Rows[i - 1].Cells[4].Value.ToString() == "Limpieza") btn.BackColor = Color.Blue;
                else if (dataGrid.Rows[i - 1].Cells[4].Value.ToString() == "Mantenimiento") btn.BackColor = Color.Yellow;


                //btn.Size = new Size(50, 50);
                //btn.Location = new Point(100, 100);
                x = x + 60;
                //////////////////////////////////////////////////////////////////////////////////////////////
                btn.Click += (s, e) => {    
                    string estado = dataGrid.Rows[Int32.Parse(btn.Name) - 1].Cells[4].Value.ToString();
                    //cambiarStatus(Int32.Parse(btn.Name),estado);

                    if (estado == "Libre") { Reservar reservar = new Reservar(btn.Name); reservar.ShowDialog(); }
                    else if (estado == "Ocupado") { Pagar pagar = new Pagar(btn.Name);pagar.ShowDialog(); }
                    else if (estado == "Limpieza") cambiarStatus(Int32.Parse(btn.Name), estado);
                    else if (estado == "Mantenimiento") cambiarStatus(Int32.Parse(btn.Name), estado);



                };
                ////////////////////////////////////////////////////////////////////////////////////////////////
                Botones.Add(btn);
                botones++;
                //Botones.ElementAt(0);
                //this.Controls.Add(btn);
                //Console.WriteLine(i);
            }
        }

        void MostrarBotones()
        {
            CrearBotones();
            for (int i=0; i<Botones.Count;i++)
            {
                this.Controls.Add(Botones.ElementAt(i));
                Console.WriteLine(i);
            }
        }

        private void registrarHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarHabitacion registrar = new RegistrarHabitacion();
            registrar.ShowDialog();
        }

        private void ListaHabitaciones_Activated(object sender, EventArgs e)
        {
            MostrarBotones();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reservar reservar = new Reservar();
            //reservar.ShowDialog();
        }

        private void editarHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.ShowDialog();
        }
    }
}