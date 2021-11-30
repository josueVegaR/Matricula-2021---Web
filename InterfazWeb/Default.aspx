<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterfazWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="card-header text-center">
        <h1>
            Sistema de Matrícula en línea
        </h1>
        <h3 style="font-weight: lighter; color: #808080">
            <i class="material-icons" >school</i>Universidad Tecnológica Centroamericana
        </h3>
    </div>
    <!--Se muestra una alerta al cliente si el session storage tiene algo-->
        <!--Se inserta un código C#-->
        <%if (Session["_mensaje"] != null)
          { %>
            
            <!--Acá se mezcla código HTML, dentro de código C#.-->
            <div class="alert alert-warning alert-dismissible fade show mt-3" role="alert">
                <%=Session["_mensaje"] %> <!--Aquí se evalúa la expresión de la Sesión.-->
                <!--Lleva un igual y evalúa expresiones-->

                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
            
        <%
                //Session["_mensaje"] = null;
          } %>
        <!--El If abre y cierra llaves en tags diferentes.-->
        <br />

    <div class="container justify-content-start">
        <h3>
            Instrucciones
        </h3>
        <p>
            1. Seleccione el periodo y año actual antes de realizar la gestión Matrícula.
        </p>
        <p>
            - <a href="frmPeriodoYAnio.aspx">Seleccionar Periodo y Año</a>
        </p>
        <p>
            2. Una vez realizado el paso anterior, proceda a seleccionar una opción del Menú para matrícula en línea, o mantenimientos relacionados.
        </p>
    </div>
</asp:Content>
