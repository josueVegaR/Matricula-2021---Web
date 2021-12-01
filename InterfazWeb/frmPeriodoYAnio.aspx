<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmPeriodoYAnio.aspx.cs" Inherits="InterfazWeb.frmPeriodoYAnio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="container">
        <div class="card-header text-center">
            <h1>
                Periodo y Año
            </h1>
            <p class="card-text mt-3">
                Seleccione el Periodo, Año e Impuesto con el cuál desea abrir el proceso de Matrícula.
            </p>
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

        <div class="row mt-3 justify-content-center">
            <div class="col-2">
                <asp:Label ID="lblPeriodo" CssClass="form-label" runat="server" Text="Seleccione el Periodo"></asp:Label>
                <asp:DropDownList ID="cboPeriodo" CssClass="form-control" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-2">
                <asp:Label ID="lblAnio" CssClass="form-label" runat="server" Text="Ingrese el Año:">

                    <asp:RequiredFieldValidator ID="rfvtxtAnio" 
                        runat="server" 
                        ErrorMessage="El año es requerido."
                        Text="*"
                        ControlToValidate="txtAnio"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>

                    <asp:RangeValidator ID="rvtxtAnio" 
                        runat="server" 
                        ErrorMessage="El año no puede ser menor al año actual o mayor al 2022."
                        Text="*"
                        ControlToValidate="txtAnio"
                        ValidationGroup="1"
                        SetFocusOnError="True">
                    </asp:RangeValidator>


                </asp:Label>
                <asp:TextBox ID="txtAnio" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label ID="lblImpuesto" CssClass="form-label" runat="server" Text="IVA:">

                   <asp:RequiredFieldValidator ID="rfvtxtIVA" 
                        runat="server" 
                        ErrorMessage="El IVA es un valor requerido."
                        Text="*"
                        ControlToValidate="txtIVA"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>

                </asp:Label>
                <asp:TextBox ID="txtIVA" CssClass="form-control" runat="server" TextMode="Number" MaxLength="2"></asp:TextBox>
            </div>
        </div>

        <div class="row mt-3 justify-content-center">
            <div class="col-2">
                <asp:Button ID="btnCancelar" CssClass="form-control btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>
            <div class="col-2">
                <asp:Button ID="btnGuardar" CssClass="form-control btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" ValidationGroup="1"/>
            </div>
        </div>
        <asp:ValidationSummary ID="vsResumen" runat="server" ValidationGroup="1" class="mt-3" Font-Italic="True" ForeColor="#CC0000" />
    </div>

</asp:Content>
