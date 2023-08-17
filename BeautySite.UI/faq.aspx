<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faq.aspx.cs" Inherits="BeautySite.UI.faq" %>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Perguntas Frequentes</title>
    <link rel="stylesheet" href="resource/css/reset.css">
    <link rel="stylesheet" href="resource/css/faq.css">

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
                    <li><a href="https://www.instagram.com/beautysite_insta" alt="" target="_blank"><img
                                src="resource/img/icons beauty/instagram.png" alt=""> </a> </li>
                    <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank"><img
                                src="resource/img/icons beauty/linkedin.png" alt=""> </a> </li>
                    <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank"><img
                                src="resource/img/icons beauty/facebook.png" alt=""> </a> </li>
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


    <section class="eventos wow animate__animated animate__bounce">
        <div class="site">
            <h2>Perguntas Frequentes</h2>
            <div>
                <!-- <div>
             <img src="img/servico1.png" id="imgEvento" alt="eventos">
                 </div> -->
                <div>
                    <button class="tituloEvento" id="evento1">O material é esterilizado?</button>
                    <div class="textoEvento">
                        <p>
                            Os profissionais são autônomos e responsáveis pela esterilização das ferramentas. O
                            atendimento às normas de biossegurança é um pré-requisito para atender pela Beauty e todos
                            os profissionais foram treinados de acordo com as regras vigentes.
                        </p>
                    </div>

                    <button class="tituloEvento" id="evento2">Não gostei do serviço realizado, com quem eu posso
                        falar?</button>
                    <div class="textoEvento">
                        <p>
                            Você pode fazer sua avaliação e bloquear um profissional através do seu aplicativo ou deixar
                            o
                            feedback através do nosso chat de atendimento.

                            Nosso chat está preparado para acolher qualquer situação que tenha ocorrido em seus
                            atendimentos, entre em contato conosco, e deixe seu feedback pois nosso setor de qualidade
                            vai investigar o ocorrido com a/o profissional, garantindo melhorias e um padrão de
                            excelência nos atendimentos da Beauty.
                    </div>

                    <button class="tituloEvento" id="evento3">Sou alérgica a um produto, como aviso a Beauty?</button>
                    <div class="textoEvento">
                        <p>
                            Você consegue colocar uma observação em seu pedido ao agenda-lo dentro do site, dessa forma,
                            a/o profissional que incluir seu pedido na agenda para o atendimento, poderá levar o
                            material necessário para te atender da melhor forma.
                        </p>
                    </div>

                    <button class="tituloEvento" id="evento4">Qual é a tolerância de atraso para clientes?</button>
                    <div class="textoEvento">
                        <p>
                            Como nossas profissionais possuem uma agenda de atendimentos para seguir, nós trabalhamos
                            com um tempo máximo de espera.
                            Existe uma tolerância de aguardo de até 15 minutos, ou seja, caso ocorra algum imprevisto ou
                            atraso, nossas profissionais podem esperar apenas esse prazo.
                            Se este tempo for ultrapassado, a/o profissional em questão é dispensada e o valor do
                            serviço é cobrado de forma integral, pois a/o profissional foi até o local, e separou um
                            tempo da agenda para realizar o serviço.
                        </p>
                    </div>

                    <button class="tituloEvento" id="evento5">Qual o traje para massagem?</button>
                    <div class="textoEvento">
                        <p>
                            O traje para massagem é traje de banho: Sunga para homem e biquíni ou maiô para mulheres.
                        </p>
                    </div>

                    <button class="tituloEvento" id="evento6">Qual a preparação para o serviço de escova?</button>
                    <div class="textoEvento">
                        <p>
                            Para realizar o atendimento de escova a cliente precisa estar com os cabelos lavados e
                            úmidos no momento do agendamento.
                            Não é possível lavar com a chegada do profissional pois o período de tolerância para início
                            do atendimento é de 15 minutos, portanto, a cliente precisa estar pronta para iniciar no
                            horário agendado no site.
                        </p>
                    </div>

                    <button class="tituloEvento" id="evento7">Como faço um agendamento?</button>
                    <div class="textoEvento">
                        <p>
                            Para efetuar um agendamento, escolha o serviço de sua preferência, selecione o dia, horário,
                            local de atendimento e os demais detalhes do pedido.
                            A disponibilidade de datas e horários disponíveis depende da quantidade de artistas no local
                            e região inserida.
                            O tempo de antecedência que consegue pedir depende de fatores: Local, data, hora e artista
                            disponível no local para a hora solicitada. Isso significa que pode conseguir solicitar com
                            antecedência de 15 minutos ou precisará de até 12 horas de antecedência.
                        </p>
                    </div>

                </div>


            </div>

        </div>
    </section>




    <footer>
        <div class="site">
            <div class="rodape">
                <div class="esq">
                    <img src="resource/img/logo_beauty_site_100x100.png" alt="logo beauty" class="logoF">
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
                        <li><a href="https://www.instagram.com/beautysite_insta" alt="" target="_blank"><img
                                    src="resource/img/icons beauty/instagram.png" alt=""> </a> </li>
                        <li><a href="https://www.linkedin.com/in/beautysite" alt="" target="_blank"><img
                                    src="resource/img/icons beauty/linkedin.png" alt=""> </a> </li>
                        <li><a href="https://pt-br.facebook.com/beautysite.facebook" alt="" target="_blank"><img
                                    src="resource/img/icons beauty/facebook.png" alt=""> </a> </li>
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
