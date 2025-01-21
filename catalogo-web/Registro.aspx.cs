﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace catalogo_web
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                UserNegocio userNegocio = new UserNegocio();
                EmailService emailService = new EmailService();
                
                user.Email = txtEmail.Text;
                user.Pass = txtPassword.Text;
                user.Id = userNegocio.insertarNuevo(user);
                Session.Add("user", user);  

                //emailService.armarCorreo(user.Email, "Bienvenido/a", "Hola te damos la bienvenida a la aplicacion.");
                //emailService.enviarEmail();
                Response.Redirect("Default.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}