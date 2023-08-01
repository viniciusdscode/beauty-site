<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="BeautySite.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="resource/css/reset.css" />
    <link rel="stylesheet" href="resource/css/slick.css" />
    <link rel="stylesheet" href="resource/css/slick-theme.css" />
    <link rel="stylesheet" href="resource/css/Login.css" />
    <title>Cadastro</title>
</head>
<body>
    <header>

        <div class="barra-contato">
            <div class="site">
                <div class="ctt ">

                    <h3>(11)94895-0569</h3>
                    <h3>contato@beautysite.com.br</h3>
                </div>

                <ul class="redeSociais ">
                    <li><a href="https://www.instagram.com/beautysite_insta" alt="" target="_blank">
                        <img src="resource/img/icons beauty/instagram.png" alt="" />
                    </a></li>
                    <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank">
                        <img src="resource/img/icons beauty/linkedin.png" alt="" />
                    </a></li>
                    <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank">
                        <img src="resource/img/icons beauty/facebook.png" alt="" />
                    </a></li>
                </ul>
            </div>

        </div>
        <div class="Menu site">

            <a href="index.aspx">
                <h1></h1>
            </a>
            <button class="abrirMenu"></button>
            <nav>
                <button class="fecharMenu"></button>
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="quemsomos.html">Quem Somos</a></li>
                    <li><a href="servicos.html">Serviços</a></li>
                    <li><a href="contato.php">Contato</a></li>
                    <li><a href="faq.html">FAQ</a></li>
                    <li><a href="Login.aspx">Login</a></li>
                </ul>
            </nav>
        </div>

    </header>

    <form id="form1" runat="server">
        <asp:Label ID="lblMessage" runat="server" Text="Manage User">
            <div class="center">
                <ul>
                    <li>
                        <h1>Cadastrar</h1>
                        <asp:TextBox ID="txtIdUsuario" runat="server" placeholder="" Width="0%" CssClass="CampoId"></asp:TextBox>
                    </li>

                    <li>
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" Width="90%" MaxLength="150" CssClass="CampoLogin"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                    </li>

                    <li>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="90%" MaxLength="150" CssClass="CampoLogin"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                    </li>

                    <li>
                        <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" Width="90%" MaxLength="8" CssClass="CampoLogin"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblSenha" runat="server" Text=""></asp:Label>
                    </li>

                    <li>
                        <asp:TextBox ID="txtTel" runat="server" placeholder="Telefone" Width="90%" onkeypress="$(this).mask('(00)00000-0000')" CssClass="CampoLogin"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblTel" runat="server" Text=""></asp:Label>
                    </li>

                    <li>
                        <asp:Button ID="btnRecord" runat="server" Text="Cadastrar" OnClick="btnRecord_Click" CssClass="btnLogin" />
                    </li>
                </ul>
            </div>
        </asp:Label>
    </form>
    

</body>

    <script type="text/javascript" src="resource/scripts/jquery-3.6.3.min.js"></script>
    <%--jquery--%>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.4/jquery.min.js" > </script>

    <%--jqueryMask--%>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js" > </script>

    <script type="text/javascript" src="resource/scripts/slick.min.js"></script>
    

    <script src="resource/scripts/animacoes.js"></script>


</html>
