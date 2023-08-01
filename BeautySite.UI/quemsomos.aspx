<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quemsomos.aspx.cs" Inherits="BeautySite.UI.quemsomos" %>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quem Somos</title>
    <link rel="stylesheet" href="resource/css/reset.css">
    <link rel="stylesheet" href="resource/css/slick.css">
    <link rel="stylesheet" href="resource/css/slick-theme.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="resource/css/quemsomos.css">
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
                        <img
                            src="resource/img/icons beauty/instagram.png" alt="">
                    </a></li>
                    <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank">
                        <img
                            src="resource/img/icons beauty/linkedin.png" alt="">
                    </a></li>
                    <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank">
                        <img
                            src="resource/img/icons beauty/facebook.png" alt="">
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
                    <%-- <li><a href="contato.php">Contato</a></li>--%>
                    <li><a href="faq.aspx">FAQ</a></li>
                    <li><a href="login.aspx">Login</a></li>

                </ul>
            </nav>
        </div>

    </header>


    <section class="bannerQs">
        <img src="resource/img/banner_black01.png" alt="Banner Quem Somos?">
    </section>

    <section class="textoQs">
        <div class="site">
            <p>
                A história da Beauty começou esse ano com a ambição de ajudar as pessoas a alcançarem uma melhor
                autoestima, se exergando cada vez mais bonitas, nosso foco também está em entregar qualidade de vida de
                maneira acessível. Estamos motivados pelo nosso propósito e não vamos parar até que possamos alcançar o
                maior número de pessoas possível.
            </p>
        </div>
    </section>

    <section class="cardQs">
        <div class="site">
            <div>
                <div>
                    <img src="resource/img/cardQs1.jpg" alt="Card 01">
                    <h3>Sempre Inovando</h3>
                    <p>
                        Estamos sempre procurando novas maneiras para melhorar a vida das pessoas com o máximo de
                        conforto.
                    </p>
                </div>

            </div>
            <div>
                <div>
                    <img src="resource/img/injecao-cosmetica-de-botox-na-testa.jpg" alt="Card 01">
                    <h3>Transparência e Honestidade</h3>
                    <p>
                        Estamos sempre buscando fazer a coisa certa e justa, sendo abertos e transparentes com nossos
                        parceiros e clientes.
                    </p>
                </div>
            </div>
            <div>
                <div>
                    <img src="resource/img/uma-linda-jovem-deita-se-na-mesa-da-esteticista-e-recebe-procedimentos.jpg"
                        alt="Card 01">
                    <h3>Boas Experiências</h3>
                    <p>
                        Em tudo que fazemos priorizamos as melhores experiências possiveis, promovendo sempre uma boa
                        comunidade
                    </p>
                </div>
            </div>
            <div>
                <div>
                    <img src="resource/img/cardQs1.jpg" alt="Card 01">
                    <h3>Melhoria Social</h3>
                    <p>
                        Acreditamos que a tecnologia pode e deve beneficiar a todos, sendo sustentável e acessível a
                        qualquer pessoa.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <section class="mosaico">
        <div class="site">
            <div class="textoCima">
                <p>
                    Nós oferecemos mais que seções de beleza. A Beauty tem o objetivo de te oferecer um futuro mais
                    bonito!
                </p>
            </div>
            <div class="imagensFinal">
                <img src="resource/img/mosaicoImagem1.jpg" alt="mosaicoImagem1">
                <img src="resource/img/mosaicoImagem2.jpg" alt="mosaicoImagem2">
            </div>
            <div class="textoBaixo">
                <p>
                    A Beauty é uma empresa brasileira que tem como meta mostar sua melhor versão de um jeito mais fácil e
                    simples.
                </p>
            </div>
        </div>
    </section>

    <footer>
        <div class="site">
            <div class="rodape">
                <div class="esq">
                    <img src="resource/img/royal_crown_set-05 .svg" alt="logo beauty" class="logoF">
                </div>

                <div class="centro">

                    <!-- <button class="toggle-btn">Links</button> -->
                    <ul>
                        <li><a href="index.aspx">Home</a></li>
                        <li><a href="quemsomos.aspx">Quem Somos</a></li>
                        <li><a href="servicos.aspx">Serviços</a></li>
                        <%-- <li><a href="contato.php">Contato</a></li>--%>
                        <li><a href="faq.aspx">FAQ</a></li>
                        <li><a href="login.aspx">Login</a></li>

                    </ul>

                </div>

                <div class="direita">


                    <ul class="redeSociaisFooter">
                        <li><a href="https://www.instagram.com/beautysite_insta" alt="" target="_blank">
                            <img
                                src="resource/img/icons beauty/instagram.png" alt="">
                        </a></li>
                        <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank">
                            <img
                                src="resource/img/icons beauty/linkedin.png" alt="">
                        </a></li>
                        <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank">
                            <img
                                src="resource/img/icons beauty/facebook.png" alt="">
                        </a></li>
                    </ul>

                </div>
            </div>
        </div>
    </footer>



</body>

<script type="text/javascript" src="resource/scripts/jquery-3.6.3.min.js"></script>
<script type="text/javascript" src="resource/scripts/slick.min.js"></script>

<script src="resource/scripts/animacoes.js"></script>

</html>
