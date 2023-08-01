<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BeautySite.UI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="resource/css/reset.css"/>

    <link rel="stylesheet" href="resource/css/slick.css"/>
    <link rel="stylesheet" href="resource/css/slick-theme.css" />

    <link rel="stylesheet" href="resource/css/Login.css" />
    <title>Login</title>
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
                    <li><a href="index.aspx">Home</a></li>
                    <li><a href="quemsomos.aspx">Quem Somos</a></li>
                    <li><a href="servicos.aspx">Serviços</a></li>
                    <li><a href="faq.aspx">FAQ</a></li>
                </ul>
            </nav>
        </div>

    </header>
    <section>
        <form id="form1" runat="server">
            <div class="center">
                <ul>

                    <li>
                        <h1>Login</h1>
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome:" MaxLength="150" CssClass="CampoLogin" AutoCompleteType="Disabled">

                        </asp:TextBox>
                    </li>

                    <li>
                        <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha:" MaxLength="8" CssClass="CampoLogin" AutoCompleteType="Disabled">

                        </asp:TextBox>
                    </li>

                    <li>
                        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click1" CssClass="btnLogin" />
                    </li>

                    <li>
                        <asp:TextBox ID="lblMessage" runat="server" Text="" text-decoration="none" CssClass="lblLogin">

                        </asp:TextBox>
                    </li>
                    <li>
                        <p>Não tem cadastro ainda? </p>
                        <a href="Cadastro.aspx">Cadastre-se</a>
                    </li>
                </ul>
            </div>
        </form>
    </section>

    

</body>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.4/jquery.min.js"> </script>
    <%--jqueryMask--%>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.min.js"> </script>

    <script type="text/javascript" src="resource/scripts/jquery-3.6.3.min.js"></script>
    <script type="text/javascript" src="resource/scripts/slick.min.js"></script>

    <script src="resource/scripts/animacoes.js"></script>
</html>
