<%@ Page Title="Direção" Language="C#" MasterPageFile="~/adm/DefaultAdm.Master" AutoEventWireup="true" CodeBehind="Direcao.aspx.cs" Inherits="BeautySite.UI.adm.Direcao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <link rel="stylesheet" href="../resource/css/slick.css" />
        <link rel="stylesheet" href="../resource/css/slick-theme.css" />
        <link rel="stylesheet" href="../resource/css/direcao.css" />
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
                        <img src="../resource/img/icons beauty/instagram.png" alt="" />
                    </a></li>
                    <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank">
                        <img src="../resource/img/icons beauty/linkedin.png" alt="" />
                    </a></li>
                    <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank">
                        <img src="../resource/img/icons beauty/facebook.png" alt="" />
                    </a></li>
                </ul>
            </div>

        </div>
        <div class="Menu site">

            <a href="../index.aspx">
                <h1></h1>
            </a>
            <button class="abrirMenu"></button>
            <nav>
                <button class="fecharMenu"></button>
                <ul>
                    <li><a href="../index.aspx">Home</a></li>
                    <li><a href="../quemsomos.aspx">Quem Somos</a></li>
                    <li><a href="../servicos.aspx">Serviços</a></li>
                    <li><a href="../faq.aspx">FAQ</a></li>
                   <li><a href="../Login.aspx">Login</a></li>
                </ul>
            </nav>
        </div>

    </header>

  
        <section class="center">
            <div class="divBtn">
                <a href="ManageUser.aspx" class="btnLogin">MANAGE USER</a>
            </div>

            <div class="divBtn">
                <a href="ManageServico.aspx" class="btnLogin">MANAGE SERVICO</a>
            </div>
        </section>

    </body>

    </html>

</asp:Content>
