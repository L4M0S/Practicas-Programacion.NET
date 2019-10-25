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
    public partial class Form1 : Form
    {
        conexion conector=new conexion();
        public Form1()
        {
            InitializeComponent();
            if(conector.abrir()) MessageBox.Show("abierta");
            else MessageBox.Show("no abierta");
        }
    }
}
