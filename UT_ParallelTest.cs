using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;

public class UT_ParallelTest
{
    ChromeDriver driver;
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("setup");
        driver = new ChromeDriver();
       driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

    }

    [Test]
    [Parallelizable]
    public void TestA() { 

        driver.Url="https://www.youtube.com/";
        // Thread.Sleep(2000);
        // driver.FindElement(By.Id("search")).Click();
        // driver.FindElement(By.Id("search")).SendKeys("selenium");
        
        
        
        // Thread.Sleep(5000);
        
        // driver.FindElement(By.ClassName("style-scope ytd-searchbox")).Click();
    }


    [Test]
    [Parallelizable]
    public void TestB() { 
         
        // Thread.Sleep(3000);
        driver.Url="https://www.google.co.in/";
        // driver.FindElement(By.Name("q")).SendKeys("search in google");
     }

    // [Test]
    // public void TestC() { /* ... */ }
}  