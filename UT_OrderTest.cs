using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;

public class UT_OrderTest
{
    ChromeDriver driver;
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("setup");
        driver = new ChromeDriver();
       

    }

    [Test, Order(1)]
    public void TestA() { 

        driver.Url="https://www.youtube.com/";
        Thread.Sleep(3000);

    }


    [Test, Order(2)]
    public void TestB() { 
         
        driver.Url="https://www.google.co.in/";
        Thread.Sleep(3000);
     }

    // [Test]
    // public void TestC() { /* ... */ }
}  