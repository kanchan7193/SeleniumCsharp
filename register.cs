using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Csharpsele
{
     public class register : webdriver
    {
        [Fact(Skip="Don want it now")]
        public void SecondTest()
        {
            Driver.Navigate().GoToUrl("https://www.google.com"); 
            IWebElement wb=Driver.FindElement(By.Name("q"));
            wb.Clear();
            wb.SendKeys("kamalesh");
            wb.SendKeys(Keys.Enter);
            Assert.True(true);
        }

        [Fact]
        public void RegisterTest()
        {
            
            Driver.Navigate().GoToUrl("https://smartsale.info/register/"); 
            IWebElement username = Driver.FindElement(By.Name("username"));
            IWebElement email = Driver.FindElement(By.Name("email"));
            IWebElement password1 = Driver.FindElement(By.Name("password1"));
            IWebElement password2 = Driver.FindElement(By.Name("password2"));
            IWebElement signup = Driver.FindElement(By.CssSelector(".btn.btn-outline-info"));

            username.Clear();
            username.SendKeys("Kamalesh2");
            email.SendKeys("kamlesh910@gmail.com");
            password1.SendKeys("mybabu");
            password2.SendKeys("mybabu");
            signup.Click();

            /* IWebElement alert = Driver.FindElement(By.CssSelector(".div.alert.alert-success"));
            Assert.Contains(alert.Text,"Account created successfully for Kamalesh2!");*/
    
        }
    }
}

/*# url https://smartsale.info/register/
#webelement name username
#webelement name email
#webelement name password1
#webelement name password2
#webelement class btn btn-outline-info */