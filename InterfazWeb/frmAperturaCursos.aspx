<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmAperturaCursos.aspx.cs" Inherits="InterfazWeb.frmAperturaCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <%-- Script de jQuery --%>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" integrity="sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=" 
        crossorigin="anonymous"></script>
    <script src="JS/Funciones.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <%-- Contenido de la página. Funcionará como un asistente. --%>

    <div class="container">
        <div class="card-header text-center">
            <h1>Materia y Horario</h1>
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
                Session["_mensaje"] = null;
            } %>
        <!--El If abre y cierra llaves en tags diferentes.-->
        
               <!--Fila-->
        <div class="row mt-3">
            
            <!--Columnas-->
            <div class="col-2">
                <asp:Label ID="lblCodigoMateria" runat="server" Text="Cód. Materia" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCodigoMateria" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label ID="lblCreditos" runat="server" Text="Créditos" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCreditos" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
            </div>
            <!--Se debe agregar un control de validación al cliente-->
            <div class="col-8">
                <asp:Label ID="lblNombreMateria" runat="server" Text="Nombre Materia">
                    <%-- Field Validator para el campo del nombre de la materia --%>
                    <asp:RequiredFieldValidator 
                        ID="rfvtxtNombreMateria" 
                        runat="server" 
                        ErrorMessage="Debe seleccionar una Materia."
                        text="*"
                        ControlToValidate="txtNombreMateria"
                        validationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>                
                <div class="input-group">
                    <%-- Cuadro que no se ve para cargar el codigo de la Materia --%>
                    <asp:TextBox ID="txtIDMateriaSelecciada" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtNombreMateria" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>

                    <%-- Se necesita utilizar un control de HTML en vez de un botón de servidor.
                        Esto es debido a que el control de servidor hace PostBack y no se puede en este caso, se perdería el modal que queremos crear.--%>
                    <input type="button" id="btnBuscarMateria" value="Buscar Materia" class="btn btn-outline-primary" data-bs-toggle="modal" data-bs-target="#materiasModal"/>
                </div>
                                                  
            </div>

        </div><!--Cierre Fila-->
        

        <!--Horario-->



    </div> <!--Cierre del contenedor-->

        <!--Creación del Modal-->
            <%--buscar Materias
        Este es el modal de Bootstrap con el código dentro del frmAperturaCursos, ya que es un form bastante similar--%>
    <div class="modal fade" id="materiasModal" tabindex="-1" aria-labelledby="materiasModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="materiasModalLabel">Buscar Materia</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <%-- Fila --%>
                    <div class="row ">
                        <%-- Columna --%>
                        <div class="col">

                            <%-- Fila --%>
                            <div class="row mt-3">
                                <div class="col-auto">
                                    <asp:Label ID="Label7" runat="server" Text="Label" class="col-form-label">Nombre Materia</asp:Label>
                                </div>
                                <div class="col-auto">
                                    <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                                </div>
                                <div class="col-auto">
                                    <asp:Button ID="btnBuscar" runat="server" class="btn btn-primary" Text="Buscar" OnClick="btnBuscar_Click" /> 
                                </div>
                            </div>
                            <br />

                            <br />
                            <asp:GridView ID="GrdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" EmptyDataText="No existen registros" ForeColor="#333333" GridLines="None" Width="100%" PagerSettings-PageButtonCount="10" OnPageIndexChanging="GrdLista_PageIndexChanging">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodMateriaCarrera").ToString() %>' CommandName="Seleccionar" ToolTip="Seleccionar">Seleccionar</asp:LinkButton>

                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                                    <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                                    <asp:BoundField DataField="Creditos" HeaderText="Créditos" />
                                    <asp:BoundField DataField="NombreCarrera" HeaderText="Carrera" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />

                                <PagerSettings PageButtonCount="10"></PagerSettings>

                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
