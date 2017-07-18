using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System;
namespace testeCongnizantSelenium
{

    class ClassTest
    {
        AbreBrowser browser = new AbreBrowser();
        PaginaInicialOLX paginaInicial = new PaginaInicialOLX();
        TelaPesquisa telaPesquisa = new TelaPesquisa();
        TelaResultados telaResultados = new TelaResultados();
        ClassTest teste = new ClassTest();

        //Ordem dos testes
        public void Main()
        {
            teste.testeExibirAnuncioValor();
            teste.testePaginacaoPrint();
        }

        public void testeExibirAnuncioValor()
        {
            //Abrir Site
            browser.abreBrowser("http://olx.com.br");
            //Após abrir site da OLX, clicar no estado
            paginaInicial.clickEstado();
            //Digitar 'Carro' na pesquisa
            telaPesquisa.pesquisaTxt("Carro");
            //Clicar em pesquisar
            telaPesquisa.clickLupaPesquisar();
            //Chama método para exibir no console os 5 primeiro anuncios e seus valores
            telaResultados.cincoPrimeirosAnuncios();

        }

        public void testePaginacaoPrint()
        {

            //Abrir Site
            browser.abreBrowser("http://olx.com.br");
            //Após abrir site da OLX, clicar no estado
            paginaInicial.clickEstado();
            //Digitar 'Carro' na pesquisa
            telaPesquisa.pesquisaTxt("Carro");
            //Clicar em pesquisar
            telaPesquisa.clickLupaPesquisar();
            //Exibe resultados da página 2
            telaResultados.bttProximaPagina();
            //Clique no primeiro anuncio
            telaResultados.clickPrimeiroAnuncio();
            //Print anuncio
            telaResultados.printAnuncio();

        }


    }
}

