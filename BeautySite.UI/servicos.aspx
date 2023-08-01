<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicos.aspx.cs" Inherits="BeautySite.UI.servicos" %>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Beauty-Serviços</title>
    <link rel="stylesheet" href="resource/css/reset.css">
    <link href="resource/css/lity.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="resource/css/servicos.css">
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

    <section class="sessao">
        <div class="site">
            <h2 class="divTitulos">Serviços que você encontra aqui &#128150 </h2>

            <div class="divBaseS">

                <div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner04.jpg" alt="massagem 1200x600"
                            data-lity="massagem">
                            <img src="resource/img/carrossel/beautysite_banner04.jpg" alt=""></a>
                        <h2>Massagem</h2>
                        <p>Nossos melhores terapeutas corporais a sua disposição</p>

                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner01.jpg" alt="manicure 1200x600"
                            data-lity="manicure">
                            <img src="resource/img/carrossel/beautysite_banner01.jpg" alt=""></a>
                        <h2>Unhas</h2>
                        <p>Manicure e Pedicure devidamente capacitados</p>
                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner07.jpg" alt="podologa 1200x600"
                            data-lity="massagem">
                            <img src="resource/img/carrossel/beautysite_banner07.jpg" alt=""></a>
                        <h2>Podóloga</h2>
                        <p>Cuidados essenciais para seus pés</p>
                    </div>
                </div>
                <div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner02.jpg" alt="cabelos 1200x600" data-lity="cabelos">
                            <img
                                src="resource/img/carrossel/beautysite_banner02.jpg" alt=""></a>
                        <h2>Cabelos</h2>
                        <p>Hair stylish com os mais variados serviços para seus cabelos</p>
                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner06.jpg" alt="barbeiro 1200x600"
                            data-lity="barbeiro">
                            <img src="resource/img/carrossel/beautysite_banner06.jpg" alt=""></a>
                        <h2>Barbeiro</h2>
                        <p>Cabelo, Barba e Bigode do jeito que você quer</p>
                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner09.jpg" alt="cilios 1200x600" data-lity="cilios">
                            <img
                                src="resource/img/carrossel/beautysite_banner09.jpg" alt=""></a>
                        <h2>Cílios</h2>
                        <p>Tenha cílios lindos e duradouros para realçar a sua beleza</p>
                    </div>
                </div>
                <div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner10.jpg" alt="depilacao 1200x600"
                            data-lity="depilacao">
                            <img src="resource/img/carrossel/beautysite_banner10.jpg" alt=""></a>
                        <h2>Depilação</h2>
                        <p>As melhores depiladoras para o cuidado de todo o seu corpo</p>
                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner08.jpg" alt="depil masc 1200x600"
                            data-lity="massagem">
                            <img src="resource/img/carrossel/beautysite_banner08.jpg" alt=""></a>
                        <h2>Depilação Masculina</h2>
                        <p>Especialistas em depilação masculina</p>
                    </div>
                    <div>
                        <a href="resource/img/carrossel/beautysite_banner04.jpg" alt="massagem 1200x600"
                            data-lity="massagem">
                            <img src="resource/img/carrossel/beautysite_banner04.jpg" alt=""></a>
                        <h2>Estética</h2>
                        <p>Limpeza de pele, esfoliação e outros procedimentos para você</p>
                    </div>
                </div>
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

<script src="resource/scripts/jquery-3.6.3.min.js"></script>
<script src="resource/scripts/slick.min.js"></script>
<script src="resource/scripts/lity.min.js"></script>

<script src="resource/scripts/animacoes.js"></script>

</html>
