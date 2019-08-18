using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using OpenQA.Selenium.Support.UI;

namespace seleniumcsharp
{
    
     public class sale : IClassFixture<webdriver>
    {
    webdriver w;

    public sale(webdriver Driver)
    {
        this.w = Driver;
    }

       [Theory]
       [InlineData("dress", "57585", "Jump Suit","Mumbai","fashion-accessories")]
       [InlineData("Tesla", "78482472","Awesome car","Delhi","cars")]
        public void SaleItemTest(string item,string price,string desc,string city, string category)
        {
            smartlogin("kanchan1","536546");            
            string expectedusername = w.Driver.FindElement(By.CssSelector("#profileDropdown")).Text;
            string actualString = "Welcome kanchan1";
            Assert.Equal(expectedusername,actualString);

            w.Driver.FindElement(By.CssSelector(".btn.btn-success")).Click();
            w.Driver.FindElement(By.Name("title")).SendKeys(item);
            w.Driver.FindElement(By.Name("price")).SendKeys(price);
            w.Driver.FindElement(By.Name("description")).Clear();
            w.Driver.FindElement(By.Name("description")).SendKeys(desc);

            IWebElement cityOption=w.Driver.FindElement(By.Id("id_city"));
            var cityOptionElement = new SelectElement(cityOption);
            cityOptionElement.SelectByValue(city);
            
            IWebElement categoryOption=w.Driver.FindElement(By.Id("id_category"));
            var catoe= new SelectElement(categoryOption);
            catoe.SelectByValue(category);          

            w.Driver.FindElement(By.CssSelector(".btn.btn-outline-info")).Click();

            w.Driver.FindElement(By.Name("q")).SendKeys(item);
            w.Driver.FindElement(By.CssSelector(".btn.btn-outline-secondary")).Click();
            w.Driver.FindElement(By.PartialLinkText(item)).Click();
            w.Driver.FindElement(By.CssSelector(".btn.btn-danger.btn-sm.mt-1.mb-1")).Click();
            w.Driver.FindElement(By.CssSelector(".btn.btn-outline-danger")).Click();

            smartlogout();
           
        } 

              
        public void smartlogin(string username,string password){
            w.Driver.Navigate().GoToUrl("https://smartsale.info/");
            w.Driver.FindElement(By.Id("profileDropdown")).Click();
            w.Driver.FindElement(By.PartialLinkText("Login")).Click();
            w.Driver.FindElement(By.Id("id_username")).SendKeys(username);
            w.Driver.FindElement(By.Id("id_password")).SendKeys(password);
            w.Driver.FindElement(By.CssSelector(".btn.btn-outline-info")).Click();     
        }    

        public void smartlogout(){
            w.Driver.Navigate().GoToUrl("https://smartsale.info/");
            w.Driver.FindElement(By.Id("profileDropdown")).Click();
            w.Driver.FindElement(By.PartialLinkText("Logout")).Click();
        }   
    }
}