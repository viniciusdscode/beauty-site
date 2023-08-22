<%@ Page Title="Manage Serviço" Language="C#" MasterPageFile="~/adm/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManageServico.aspx.cs" Inherits="BeautySite.UI.adm.ManageServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblMessage" runat="server" Text="Label">
        <header>
            <div class="Menu site">

            <a href="../index.aspx">
                <h1></h1>
            </a>
            <button class="abrirMenu"></button>
            <nav>
                <button class="fecharMenu"></button>
                <ul>
                    <li><a href="../index.aspx">Home</a></li>
                    <li><a href="ManageUser.aspx">Usuarios</a></li>
                    <li><a href="ManageServico.aspx">Adm Serviço</a></li>
                   <li><a href="../Login.aspx">Login</a></li>
                </ul>
            </nav>
        </div>

        </header>
        <div>
            <ul>
                <li>
                    <asp:TextBox ID="txtFiltro" runat="server" placeholder="Filtrar Serviço:" CssClass="barraPesquisa" AutoCompleteType="Disabled"></asp:TextBox>
                    <asp:Button ID="btnFiltro" runat="server" Text="Search" CssClass="btnPesquisa" OnClick="btnFiltro_Click" />
                    <asp:Label ID="lblFiltro" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <asp:TextBox ID="txtIdServico" runat="server" placeholder="Id" Width="90%" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                </li>

                <li>
                    <asp:TextBox ID="txtNomeServico" runat="server" placeholder="Serviço" Width="90%" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                    <asp:Label ID="lblNomeServico" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <asp:TextBox ID="txtDescricaoServico" runat="server" placeholder="Descrição" Width="90%" CssClass="txtBox"></asp:TextBox>

                </li>
                <li>
                    <br />
                    <asp:Label ID="lblDescricaoServico" runat="server" Text=""></asp:Label>
                </li>
                <li class="escolheImg">
                    <asp:FileUpload ID="fUp1" runat="server" Text="Selecione a Imagem" />
                    <asp:Label ID="lblfUp1" runat="server" Text=""></asp:Label>
                </li>
                <li class="libtnCrud">
                    <asp:Button ID="btnRecord" runat="server" Text="Cadastrar" CssClass="btnCrud" OnClick="btnRecord_Click" />

                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="btnCrud" OnClick="btnLimpar_Click" />

                    <asp:Button ID="btnDelete" runat="server" Text="Deletar" CssClass="btnCrud" OnClick="btnDelete_Click" OnClientClick="if(!confirm('Deseja mesmo eliminar este registro?'))return false" />
                </li>



            </ul>
        </div>

        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false" CssClass="gridView" OnSelectedIndexChanged="gv1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" HeaderText="Opção"></asp:CommandField>
                <asp:BoundField DataField="IdServico" HeaderText="Id" runat="server" />
                <asp:BoundField DataField="NomeServico" HeaderText="Serviço" runat="server" />
                <asp:BoundField DataField="DescricaoServico" HeaderText="Descrição" runat="server" />
                <asp:ImageField DataImageUrlField="UrlImgServico" HeaderText="Imagem" ControlStyle-Width="110" ControlStyle-Height="110"></asp:ImageField>

            </Columns>
        </asp:GridView>


    </asp:Label>


</asp:Content>
