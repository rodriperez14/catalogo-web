﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="catalogo_web.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validacion {
            color: red;
            font-size: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-4">
            <h2>Crea tu perfil de Usuario</h2>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" MaxLength="25" />
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Este campo es requerido." ControlToValidate="txtNombre" runat="server" />
                <asp:RegularExpressionValidator CssClass="validacion" ErrorMessage="Solo formato letras." ControlToValidate="txtNombre" 
                    ValidationExpression="^[a-zA-Z]+$" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" MaxLength="40"/>
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Este campo es requerido." ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator CssClass="validacion" ErrorMessage="Solo formato email." ControlToValidate="txtEmail"
                    ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                    runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Password</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtPassword" TextMode="Password" MaxLength="25" />
                <asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Este campo es requerido." ControlToValidate="txtPassword" runat="server" />
            </div>
            <asp:Button Text="Registrarse" CssClass="btn btn-primary" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" />
            <a href="/">Cancelar</a>

        </div>
    </div>
</asp:Content>
