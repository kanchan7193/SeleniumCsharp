using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Csharpsele
{
     public class login : webdriver
    {
        [Fact]
        public void LoginTestWrongDetails()
        {
            Driver.Navigate().GoToUrl("https://smartsale.info/");
            Driver.FindElement(By.Id("profileDropdown")).Click();
            Driver.FindElement(By.CssSelector(".dropdown-item")).Click();
            Driver.FindElement(By.Id("id_username")).SendKeys("kanchan");
            Driver.FindElement(By.Id("id_password")).SendKeys("test12345");
            Driver.FindElement(By.CssSelector(".btn.btn-outline-info")).Click();
           
            string expectedString ="Please enter a correct username and password. Note that both fields may be case-sensitive.";
            string actualString = Driver.FindElement(By.CssSelector(".alert.alert-block.alert-danger")).Text;
           
            Assert.Contains(expectedString,actualString);
        }

        [Fact]
        public void LoginTestRightDetails()
        {
            Driver.Navigate().GoToUrl("https://smartsale.info/");
            Driver.FindElement(By.Id("profileDropdown")).Click();
            Driver.FindElement(By.CssSelector(".dropdown-item")).Click();
            Driver.FindElement(By.Id("id_username")).SendKeys("kanchan1");
            Driver.FindElement(By.Id("id_password")).SendKeys("11");
            Driver.FindElement(By.CssSelector(".btn.btn-outline-info")).Click();          
            
            string expectedusername =Driver.FindElement(By.Id("profileDropdown")).Text;
            string actualString = "Welcome kanchan1";

            Assert.Contains(expectedusername,actualString);
        }


        

    }
}