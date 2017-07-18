using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeCongnizantSelenium
{
    class PaginaInicialOLX : AbreBrowser
    {

        public void clickEstado()
        {
            IWebElement linkEstado = driver.FindElement(By.Id("label-icon-state-sp"));
            linkEstado.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

        }

    }
}
