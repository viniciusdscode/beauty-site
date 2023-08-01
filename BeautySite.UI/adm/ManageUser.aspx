<%@ Page Title="Manage User" Language="C#" MasterPageFile="~/adm/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="BeautySite.UI.adm.ManageUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="lblMessage" runat="server" Text="Manage User">
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
                    <asp:TextBox ID="txtSearch" runat="server" placeholder="Procurar pelo Nome:" CssClass="barraPesquisa"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="Procurar" OnClick="btnSearch_Click" CssClass="btnPesquisa" />
                    <asp:Label ID="lblSearch" runat="server" Text=""></asp:Label>
                </li>

                <li>
                    <asp:TextBox ID="txtIdUsuario" runat="server" placeholder="Id" Width="90%" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                </li>

                <li>
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" Width="90%" MaxLength="150" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                </li>

                <li>
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="90%" MaxLength="150" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" Width="90%" MaxLength="8" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                    <asp:Label ID="lblSenha" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <asp:TextBox ID="txtTel" runat="server" placeholder="Telefone" Width="90%" onkeypress="$(this).mask('(00)00000-0000')" CssClass="txtBox"></asp:TextBox>
                </li>
                <li>
                    <br />
                    <asp:Label ID="lblTel" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <asp:DropDownList
                        ID="ddl1"
                        runat="server"
                        Height="22px"
                        AutoPostBack="false"
                        DataValueField="IdTipoUsuario"
                        DataTextField="DescricaoTipoUsuario"
                        CssClass="ddl">
                    </asp:DropDownList>
                </li>

                <li class="libtnCrud">
                    <asp:Button ID="btnRecord" runat="server" Text="Cadastrar" OnClick="btnRecord_Click" CssClass="btnCrud" />
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CssClass="btnCrud" />
                    <asp:Button ID="btnDelete" runat="server" Text="Deletar" OnClick="btnDelete_Click" CssClass="btnCrud" OnClientClick="if(!confirm('Deseja mesmo eliminar este registro?'))return false" />
                </li>


            </ul>
        </div>

        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false" CssClass="gridView" OnSelectedIndexChanged="gv1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" HeaderText="Opção"></asp:CommandField>
                <asp:BoundField DataField="IdUsuario" HeaderText="Código" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Senha" HeaderText="Senha" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="TipoUsuario_IdTipoUsuario" HeaderText="Permissão" />

            </Columns>

        </asp:GridView>


    </asp:Label>

</asp:Content>
