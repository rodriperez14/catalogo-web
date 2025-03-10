﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace catalogo_web
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                imgAvatar.ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_640.png";
            
                if (!(Page is Login || Page is Registro || Page is Default || Page is Error))
                {
                    if (!Seguridad.sesionActiva(Session["user"]))
                        Response.Redirect("Login.aspx", false);
                    else
                    {
                        User user = (User)Session["user"];
                        lblUser.Text = user.Nombre;
                        if(string.IsNullOrEmpty(user.Nombre))
                            lblUser.Text = user.Email;
                        if(!string.IsNullOrEmpty(user.ImagenPerfil))
                            imgAvatar.ImageUrl = "~/Images/" + user.ImagenPerfil;
                    }
                }
                else if ((Page is Default || Page is Error) && Seguridad.sesionActiva(Session["user"]))
                {
                    User user = (User)Session["user"];
                    lblUser.Text = user.Nombre;
                    if (string.IsNullOrEmpty(user.Nombre))
                        lblUser.Text = user.Email;
                    if (!string.IsNullOrEmpty(user.ImagenPerfil))
                        imgAvatar.ImageUrl = "~/Images/" + user.ImagenPerfil;
                }

            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}