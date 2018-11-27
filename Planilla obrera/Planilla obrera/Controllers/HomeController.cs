using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace Planilla_obrera.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-2OQBEMO;Initial Catalog=BD_Planillas;Integrated Security=True");

        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!model.Administrador)
            {
                
                SqlCommand cmd = new SqlCommand("spIniciarSesionObrero",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idObrero",System.Data.SqlDbType.Int).Value=int.Parse(model.Usuario);

                SqlParameter output = new SqlParameter();
                output.ParameterName = "@valorRetorno";
                output.SqlDbType = System.Data.SqlDbType.Int;
                output.Size = 50;
                output.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(output);

                conexion.Open();
                cmd.ExecuteNonQuery();

                string check = output.Value.ToString();

                if (check != "0")
                {
                    var modelUsuario = new UsuarioModel();
                    
                    modelUsuario.idObrero = model.Usuario.ToString();
                    return View("Empleado",modelUsuario);
                }
                else
                {
                    return View("Login");
                }

            }
            else
            {
                if(model.Usuario=="admin"&&model.Contrasena=="pass")
                {
                    return View("Bonos");
                }

                else
                {
                    return View("Login");
                }
            }
            

           
        }
        public ActionResult Bonos()
        {
            ViewBag.Message = "Bonos";
            return View("Bonos");
        }
        public ActionResult Usuarios()
        {
            ViewBag.Message = "Usuarios";
            return View("Empleados");
        }
    }
}