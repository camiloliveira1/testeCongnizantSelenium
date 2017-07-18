using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeCongnizantSelenium
{
    class TelaResultados : AbreBrowser
    {
        public void cincoPrimeirosAnuncios()
        {
            for (int i = 1; i < 7; i++)
            {
                if (i == 3)
                {
                    i++;
                }
                IList<IWebElement> listResultTitle = driver.FindElements(By.XPath("//div[@class = 'section_OLXad-list ']/ul/li[" + i + "]/a[@class = 'OLXad-list-link']//div[@class = 'OLXad-list-line-1 mb5px']"));
                IList<IWebElement> listResultValor = driver.FindElements(By.XPath("//div[@class = 'section_OLXad-list ']/ul/li[" + i + "]/a[@class = 'OLXad-list-link']//div[@class = 'col-3']"));

                IWebElement elementTitle = listResultTitle[0];
                IWebElement elementValor = listResultValor[0];

                System.Threading.Thread.Sleep(3000);

                Console.WriteLine("Anuncio: " + elementTitle.Text.ToString() + " Valor: " + elementValor.Text.ToString());

            }
        }
        public void bttProximaPagina()
        {

            IList<IWebElement> listResultTitle = driver.FindElements(By.XPath("//div[@class = 'module_pagination']/ul/li/a[@title = '2']"));

        }
        public void clickPrimeiroAnuncio()
        {
            IList<IWebElement> listResultTitle = driver.FindElements(By.XPath("//div[@class = 'section_OLXad-list ']/ul/li[1]/a[@class = 'OLXad-list-link']//div[@class = 'OLXad-list-line-1 mb5px']"));
            listResultTitle[0].Click();
        }

        public void printAnuncio()
        {
            ITakesScreenshot printTela = driver as ITakesScreenshot;
            Screenshot print = printTela.GetScreenshot();
            print.SaveAsFile("c:/testOLX.png", ScreenshotImageFormat.Png);
        }

    }
}

