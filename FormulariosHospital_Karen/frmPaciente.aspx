<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPaciente.aspx.cs" Inherits="FormulariosHospital_Karen.frmPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  
      <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="css/estilos.css" rel="stylesheet" />
    <link href="css/frmPaciente.css" rel="stylesheet" />
</head>
<body>

    <div class="container">
      <form id="form1" runat="server">

          <h1 class="formulario"> Pacientes</h1>

        <asp:Label ID="LabelPaicientePaciente" CssClass="font-weight-normal" runat="server" Text="Identificacion Paciente "></asp:Label><br />
        <asp:TextBox ID="TextBoxPacientePaciente" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="LabelMensajePaciente" runat="server" Text=""></asp:Label> <br />


        <asp:Label ID="LabelDocumentoPaciente"   runat="server" Text="Documento Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxDocumentoPaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelNombrePaceinte"  runat="server" Text="Nombre Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxNombrePaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelDireccionPaciente"  runat="server" Text="Direccion"></asp:Label><br />
        <asp:TextBox ID="TextBoxDireccionPaciente" runat="server"   ></asp:TextBox><br />

         <asp:Label ID="LabelTelefonoPaciente"  runat="server" Text="Telefono Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxTelefonoPaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelCelularPaciente"  runat="server" Text="Celular Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxCelularPaciente" runat="server"   ></asp:TextBox><br />
     
     
           
        <asp:Label ID="LabelActivoPaciente"   runat="server" Text="Activo"></asp:Label><br />
        <asp:TextBox ID="TextBoxActivoPaciente" runat="server" CssClass="mb-4" ></asp:TextBox><br />

        <asp:Button ID="ButtonGuardarPaciente" CssClass="btn btn-info" runat="server" Text="Guardar" OnClick="ButtonGuardarPaciente_Click"  />
        <asp:Button ID="ButtonLimpiarPaciente" CssClass="btn btn-info" runat="server" Text="Limpiar" OnClick="ButtonLimpiarPaciente_Click1"   />
    </form>
        </div>

    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
