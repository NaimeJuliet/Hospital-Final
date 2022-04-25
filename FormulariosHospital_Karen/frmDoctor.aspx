<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDoctor.aspx.cs" Inherits="FormulariosHospital_Karen.frmDoctor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="css/estilos.css" rel="stylesheet" />
    <link href="css/frmDoctor.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
      <form id="form1" runat="server">

          <h1 class="formulaio">Doctor</h1>

         <asp:Label ID="LabelIdMedicoMedico" runat="server" Text="Identificacion Medico "></asp:Label><br />
        <asp:TextBox ID="TextBoxIdMedicoMedico" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="LabelMensajeMedico" runat="server" Text=""></asp:Label>


        <asp:Label ID="LabelNombreMedico"   runat="server" Text="Nombre Medico"></asp:Label><br />
        <asp:TextBox ID="TextBoxNombreMedico" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelEspecialidadMedico"  runat="server" Text="Especialidad Medico"></asp:Label><br />
        <asp:TextBox ID="TextBoxEspecialidadMedico" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelTelefonoMedico"  runat="server" Text="Telefono"></asp:Label><br />
        <asp:TextBox ID="TextBoxTelefonoMedico" runat="server"   ></asp:TextBox><br />
     
           
        <asp:Label ID="LabelActivoMedico"   runat="server" Text="Activo"></asp:Label><br />
        <asp:TextBox ID="TextBoxActivoMedico" runat="server" CssClass="mb-4" ></asp:TextBox><br />
        
        <asp:Button ID="ButtonGuardarMedico" CssClass="btn btn-info" runat="server" Text="Guardar" OnClick="ButtonGuardarMedico_Click" />
        <asp:Button ID="ButtonConsultarMedico" CssClass="btn btn-info" runat="server" Text="Consultar" OnClick="ButtonConsultarMedico_Click"  />
        <asp:Button ID="ButtonLimpiarMedico" CssClass="btn btn-info" runat="server" Text="Limpiar" OnClick="ButtonLimpiarMedico_Click1"  />
    </form>
        </div>
     <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
