using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace testSample;

public class Tests
{
    public void Test1()
    {
        string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        IWebDriver driver = new ChromeDriver(path + @"/drivers/");

        driver.Url = "https://azure.microsoft.com/en-us/services/devops/";
        driver.FindElement(By.ClassName("arrow-link devops-signin")).Click();
        driver.FindElement(By.Name("loginfmt")).SendKeys("t-bpadaliya@microsoft.com");
        driver.FindElement(By.Id("idSIButton9")).Click();
        //var timeout = 10000; // in milliseconds
        //var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
        //wait.Until(c => c.FindElement(By.Id("idBtn_Back")).Displayed);
        //driver.FindElement(By.Id("idBtn_Back")).Click();

        //driver.FindElement(By.Id("__bolt-ms-vss-test-web-test-hub-group-link")).Click();

        //bool visible = driver.FindElement(By.ClassName("bolt-header-title")).Displayed;
        //Assert.That(visible, Is.True);

        driver.Quit();
    }
}

