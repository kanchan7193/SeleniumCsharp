using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;


namespace Csharpsele
{
    public class webdriver : IDisposable
{
    private const string ChromeDriverDirectory = ("C:/javaproject/seleniumCsharp/");
    IWebDriver driver;    
    public IWebDriver Driver { get => driver; set => driver = value; }
    public void Dispose()
    {
        Driver.Dispose();
    }
    public webdriver()
    {
        Driver = new ChromeDriver(ChromeDriverDirectory);       
    }   
      
    }
}
