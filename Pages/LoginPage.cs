using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNunitAutomationFramework.Pages
{
    public class LoginPage :BasePage
    {
        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");



        public LoginPage(IWebDriver driver) : base(driver) { }



        public override void WaitForPageToLoad(string path)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
        }

        public override void ClickElement(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void Login(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(usernameInput).SendKeys(username);
            driver.FindElement(passwordInput).SendKeys(password);
            driver.FindElement(loginButton).Click();
            
        }

        public void loginbutton()
        {
            ClickElement(loginButton);
        }

    }
}
