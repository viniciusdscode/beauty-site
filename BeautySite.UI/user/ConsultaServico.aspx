<%@ Page Title="Agendar" Language="C#" MasterPageFile="~/user/DefaultUser.Master" AutoEventWireup="true" CodeBehind="ConsultaServico.aspx.cs" Inherits="BeautySite.UI.user.ConsultaServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <ul>
            <li>
                <asp:TextBox ID="txtFiltro" runat="server" placeholder=" Filtrar Serviço:" CssClass="barraPesquisa" AutoCompleteType="Disabled"></asp:TextBox>
                <asp:Button ID="btnFiltro" runat="server" Text="Search" OnClick="btnFiltro_Click" CssClass="btnPesquisa" />

            </li>
            <li>
                <br />
                <asp:Label ID="lblFiltro" runat="server" Text=""></asp:Label>
            </li>
        </ul>
    </div>

    <asp:GridView ID="gv1" runat="server" CssClass="gridViewUser" AutoGenerateColumns="false">
        <Columns>

            <asp:ImageField DataImageUrlField="UrlImgServico" HeaderText="Imagem" ControlStyle-Width="9em" ControlStyle-Height="9em"></asp:ImageField>
            <asp:BoundField DataField="NomeServico" HeaderText="Serviço" runat="server" />
            <asp:BoundField DataField="DescricaoServico" HeaderText="Descrição" runat="server" />
            <asp:HyperLinkField NavigateUrl="https://pro.quaddro.co/beautysiteagendamento/servicos/" Text="Agendar" HeaderText="Op&#231;&#227;o"></asp:HyperLinkField>
        </Columns>
    </asp:GridView>

</asp:Content>
