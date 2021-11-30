<%@ Page Title="Apertura de Cursos" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="frmAperturaCursos.aspx.cs" Inherits="InterfazWeb.frmAperturaCursos" %>
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
            <h1>Materia y Horarios</h1>
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
        <div class="row mt-3 justify-content-end">
            <!--Columnas-->
            <div class="col-2">
                <asp:Label ID="lblPeriodo" runat="server" Text="Periodo">
                    <asp:RequiredFieldValidator 
                        ID="rfvcboPeriodo" 
                        runat="server" 
                        ErrorMessage="Seleccione un periodo."
                        Text="*"
                        ControlToValidate="cboPeriodo"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:DropDownList ID="cboPeriodo" runat="server" CssClass="form-control">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-2">
                <asp:Label ID="lblAnio" runat="server" Text="Año">
                    <asp:RequiredFieldValidator
                        ID="rfvtxtAnio"
                        runat="server"
                        ErrorMessage="Seleccione un Año."
                        Text="*"
                        ControlToValidate="txtAnio"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        <!--Cierre de la Fila-->
        </div>

        <!--Fila-->
        <div class="row mt-3">
            
            <!--Columnas-->
            <div class="col-2">
                <asp:Label ID="lblCodigoMateria" runat="server" Text="Cód. Materia" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCodigoMateria" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label ID="lblCreditos" runat="server" Text="Créditos" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCreditos" runat="server" ReadOnly="true" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            
            <div class="col-8">
                <asp:Label ID="lblNombreMateria" runat="server" Text="Nombre Materia">
                    <!--Los campos de la Materia son generados por el linkButton del gridView del modal.
                        Al validar que cualquiera de los campos que se autogeneran no esté vacío, se garantiza que el usuario tiene que seleccionar una materia.-->
                    <asp:RequiredFieldValidator
                        ID="rfvtxtNombreMateria"
                        runat="server"
                        ErrorMessage="Debe seleccionar una Materia."
                        Text="*"
                        ControlToValidate="txtNombreMateria"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>                
                <div class="input-group">
                    <!-- Cuadro que no se ve para cargar el codigo de la Materia -->
                    <asp:TextBox ID="txtIDMateriaSelecciada" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtNombreMateria" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>

                    <!-- Se necesita utilizar un control de HTML en vez de un botón de servidor.
                        Esto es debido a que el control de servidor hace PostBack y no se puede en este caso, se perdería el modal que queremos crear.-->
                    <input type="button" id="btnBuscarMateria" value="Buscar Materia" class="btn btn-outline-primary" data-bs-toggle="modal" data-bs-target="#materiasModal"/>
                </div>
                                                  
            </div>

        </div><!--Cierre Fila-->
                <!--Fila-->
        <div class="row mt-3 justify-content-around">
            <!--Columnas-->
            <div class="col-2">
                <asp:Label ID="lblGrupo" runat="server" CssClass="form-label" Text="Grupo">
                    <asp:RequiredFieldValidator
                        ID="rfvtxtGrupo"
                        runat="server"
                        ErrorMessage="Debe seleccionar un grupo."
                        Text="*"
                        ControlToValidate="txtGrupo"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox ID="txtGrupo" CssClass="form-control" runat="server" MaxLength="2" TextMode="Number"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label ID="lblCupo" runat="server" CssClass="form-label" Text="Cupo">
                    <asp:RequiredFieldValidator
                        ID="rfvtxtCupo"
                        runat="server"
                        ErrorMessage="Debe ingresar un cupo que no vaya a exceder la capacidad del aula."
                        Text="*"
                        ControlToValidate="txtCupo"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox ID="txtCupo" CssClass="form-control" runat="server" TextMode="Number" MaxLength="2"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label ID="lblCosto" runat="server" CssClass="form-label" Text="Costo">
                    <asp:RequiredFieldValidator
                        ID="rfvtxtCosto"
                        runat="server"
                        ErrorMessage="Debe ingresar un costo."
                        Text="*"
                        ControlToValidate="txtCosto"
                        ValidationGroup="1">
                    </asp:RequiredFieldValidator>
                </asp:Label>
                <asp:TextBox ID="txtCosto" CssClass="form-control" runat="server" MaxLength="6" TextMode="Number"></asp:TextBox>
            </div>
        <!--Cierre de la Fila-->
        </div>

    </div> <!--Cierre del contenedor-->

    <div class="container">
        <div class="card-header text-center mt-5">
            <h3>
                Horarios
            </h3>
            <p class="card-text text-center mt-4">
                Seleccione el horario con el que desea abrir la materia seleccionada. Presione siguiente para asignar horarios extra, profesor(a) y aula.
            </p>

            <!--Fila-->
            <div class="row mt-3 justify-content-center">
                <div class="col-4">
                    <asp:Label ID="lblDia" runat="server" Text="Día"></asp:Label>
                    <asp:DropDownList ID="cboDia" runat="server">
                        <asp:ListItem>L</asp:ListItem>
                        <asp:ListItem>K</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>J</asp:ListItem>
                        <asp:ListItem>V</asp:ListItem>
                        <asp:ListItem>S</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-4">
                    <asp:Label ID="lblHoraI" runat="server" Text="Hora Inicio">
                        <asp:RequiredFieldValidator
                            ID="rfvtxtHoraI"
                            runat="server"
                            ErrorMessage="Debe ingresar una Hora de Inicio."
                            Text="*"
                            ControlToValidate="txtHoraI"
                            ValidationGroup="1">
                        </asp:RequiredFieldValidator>
                        <!--El primer compare validator es que no sea menor a la hora minima-->
                        <asp:CompareValidator ID="cvtxtHoraI" runat="server"
                            ErrorMessage="Los cursos deben empezar mínimo a las 7:00 am y máximo a las 9:00pm."
                            ControlToValidate="txtHoraI"
                            ControlToCompare="txtHoraMin"
                            Display="Dynamic"
                            ValidationGroup="1"
                            Operator="GreaterThanEqual"
                            Text="*">
                        </asp:CompareValidator>
                        <!--El segundo compare validator funciona para compararlo con la hora de salida-->
                        <asp:CompareValidator ID="cvtxtHoraI2" runat="server"
                            ErrorMessage="Las horas de Inicio y Salida deben ser distintas y con mínimo 1 hora de diferencia."
                            ControlToValidate="txtHoraI"
                            ControlToCompare="txtHoraS"
                            Display="Dynamic"
                            ValidationGroup="1"
                            Operator="LessThan"
                            Text="*">
                        </asp:CompareValidator>
                        <!--El tercer compare validator funciona para compararlo con la hora max. de Inicio-->
                        <asp:CompareValidator ID="cvtxtHoraIMax" runat="server"
                            ErrorMessage="Los cursos no pueden iniciar después de las 9:00 pm."
                            ControlToValidate="txtHoraI"
                            ControlToCompare="txtHoraIMax"
                            Display="Dynamic"
                            ValidationGroup="1"
                            Operator="LessThanEqual"
                            Text="*">
                        </asp:CompareValidator>
                    </asp:Label>
                    <asp:TextBox ID="txtHoraMin" runat="server" ReadOnly="true" Visible="false" TextMode="Time"></asp:TextBox>
                    <asp:TextBox ID="txtHoraIMax" runat="server" ReadOnly="true" Visible="false" TextMode="Time"></asp:TextBox>
                    <asp:TextBox ID="txtHoraI" runat="server" TextMode="Time"></asp:TextBox>
                </div>
                <div class="col-4">
                    <asp:Label ID="lblHoraS" runat="server" Text="Hora Fin">
                            <asp:RequiredFieldValidator
                            ID="rfvtxtHoraS"
                            runat="server"
                            ErrorMessage="Debe indicar una hora de Salida."
                            Text="*"
                            ControlToValidate="txtHoraS"
                            ValidationGroup="1">
                        </asp:RequiredFieldValidator>
                        <!--El primer compare validator es que no sea mayor a la hora max.-->
                        <asp:CompareValidator ID="cvtxtHoraS" runat="server"
                            ErrorMessage="El curso no puede terminar después de las 10:00 pm."
                            ControlToValidate="txtHoraS"
                            ControlToCompare="txtHoraMax"
                            Display="Dynamic"
                            ValidationGroup="1"
                            Operator="LessThanEqual"
                            Text="*">
                        </asp:CompareValidator>
                        <!--El segundo compare validator funciona para compararlo con la hora de Inicio-->
                        <asp:CompareValidator ID="cvtxtHoraS2" runat="server"
                            ErrorMessage="La hora de salida debe ser mayor a la hora de entrada."
                            ControlToValidate="txtHoraS"
                            ControlToCompare="txtHoraI"
                            Display="Dynamic"
                            ValidationGroup="1"
                            Operator="GreaterThan"
                            Text="*">
                        </asp:CompareValidator>
                    </asp:Label>
                    <asp:TextBox ID="txtHoraMax" runat="server" ReadOnly="true" Visible="false" TextMode="Time"></asp:TextBox>
                    <asp:TextBox ID="txtHoraS" runat="server" TextMode="Time"></asp:TextBox>
                </div>
            <!--Cierre de fila-->
            </div>
        </div>
        <!--Botones-->
        <div class="row mt-5 justify-content-end">
            <div class="col-2">
                <asp:Button ID="btnCancelar" CssClass="form-control btn btn-dark" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>
            <div class="col-2">
                <asp:Button ID="btnGuardar" CssClass="form-control btn btn-primary" runat="server" Text="Siguiente" OnClick="btnGuardar_Click" />
            </div>
        </div>
        <asp:ValidationSummary ID="vsResumen" runat="server" ValidationGroup="1" 
            class="mt-3" Font-Italic="True" ForeColor="#CC0000" />
    </div>
    <!--Cierre del contenedor-->


        <!--Creación del Modal-->
            <%--buscar Materias
        Este es el modal de Bootstrap con el código dentro del frmAperturaCursos, ya que es un form bastante similar--%>
    <div class="modal fade" id="materiasModal" tabindex="-1" aria-labelledby="materiasModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-fullscreen"><!--Creo un modal fullscreen que parece otra pantalla-->
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
                                    <asp:Label ID="Label7" runat="server" Text="Label" class="col-form-label">Nombre de la Materia</asp:Label>
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
                                            <asp:LinkButton ID="lnkSeleccionar" runat="server" CommandArgument='<%# Eval("CodMateriaCarrera").ToString() %>' CommandName="Seleccionar" ToolTip="Seleccionar" OnCommand="lnkSeleccionar_Command">Seleccionar</asp:LinkButton>

                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="CodMateriaCarrera" HeaderText="Código Materia Carrera" Visible="False" />
                                    <asp:BoundField DataField="CodigoMateria" HeaderText="Código Materia" />
                                    <asp:BoundField DataField="NombreMateria" HeaderText="Nombre Materia" />
                                    <asp:BoundField DataField="CreditosMateria" HeaderText="Créditos" />
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
