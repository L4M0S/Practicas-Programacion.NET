using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MasterPage1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        conexion conector = new conexion();

        public DataTable usuarios = new DataTable();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            usuarios = conector.cargarDatos("select * from usuarios;");
            System.Diagnostics.Debug.WriteLine(usuarios.Rows.Count);
            //System.Diagnostics.Debug.WriteLine(usuarios.Rows[0].Cells[0].Text);
        }

        protected void B_Login_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= usuarios.Rows.Count - 1; i++)
            {
                //if (usuarios.Rows[i - 1].Cells[0].Text == TB_UserLogin.Text)
                if (usuarios)
                {
                    System.Diagnostics.Debug.WriteLine("Sesion iniciada");
                    Session["nombre"] = TB_UserLogin.Text;
                    Response.Redirect("WebForm2.aspx");
                    return;
                }
            }
            System.Diagnostics.Debug.WriteLine("Usuario no existe");
            return;
        }


        protected void B_Register_Click(object sender, EventArgs e)
        {

        }
    }
}