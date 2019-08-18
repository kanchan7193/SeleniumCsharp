using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace seleniumcsharp
{
    
     public class login : IClassFixture<webdriver>
    {
    webdriver w;

    public login(webdriver Driver)
    {
        this.w = Driver;
    }


       [Theory]
       [InlineData("kanchan1", "gyujhjjj","Welcome kanchan1")]
        public void LoginTestWrongDetails(string username,string password,string expectedstring)
        {
            smartlogin(username,password);  
            string expectedusername = w.Driver.FindElement(By.CssSelector("#profileDropdown")).Text;           
            Assert.Contains(expectedstring,expectedusername);
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