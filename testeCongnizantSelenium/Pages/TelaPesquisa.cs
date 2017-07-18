using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeCongnizantSelenium
{
    class TelaPesquisa : AbreBrowser
    {
        public void pesquisaTxt(string value)
        {
            IWebElement searchProduto = driver.FindElement(By.Id("searchtext"));
            searchProduto.SendKeys(value);
        }

        public void clickLupaPesquisar()
        {
            IWebElement searchBtt = driver.FindElement(By.Id("searchbutton"));
            searchBtt.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }
    }
}
