using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace seleniumcsharp
{
     public class register : IClassFixture<webdriver>
    {

        webdriver w;

       public register(webdriver Driver)
       {
        this.w = Driver;
      }


        [Fact(Skip="Don want it now")]
        public void SecondTest()
        {
            w.Driver.Navigate().GoToUrl("https://www.google.com"); 
            IWebElement searchbox=w.Driver.FindElement(By.Name("q"));
            searchbox.Clear();
            searchbox.SendKeys("kamalesh");
            searchbox.SendKeys(Keys.Enter);
            Assert.True(true);
        }

        [Fact]
        public void RegisterTest()
        {
            
            w.Driver.Navigate().GoToUrl("https://smartsale.info/register/"); 
            IWebElement username = w.Driver.FindElement(By.Name("username"));
            IWebElement email = w.Driver.FindElement(By.Name("email"));
            IWebElement password1 = w.Driver.FindElement(By.Name("password1"));
            IWebElement password2 = w.Driver.FindElement(By.Name("password2"));
            IWebElement signup = w.Driver.FindElement(By.CssSelector(".btn.btn-outline-info"));

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