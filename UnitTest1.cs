using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;


public class Tests
{
    ChromeDriver driver;
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("setup");
        driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        driver.Url="http://demoselsite.azurewebsites.net/webform1.aspx";
        Thread.Sleep(3000);

        driver.FindElement(By.Id("txtno1")).SendKeys("12");
        driver.FindElement(By.Id("txtno2")).SendKeys("4");

        IWebElement el = driver.FindElement(By.Id("cmbop"));
        SelectElement list = new SelectElement(el);

        list.SelectByValue("Multiply");
        Thread.Sleep(2000);

        driver.FindElement(By.Id("btnsrcvcalc")).Click();

        IWebElement res = driver.FindElement(By.Id("lblres"));

        string s = res.Text;

        Console.WriteLine(s);
        


        if(s.Equals("48")){
            Console.WriteLine("Pass");
        }
        
        else{
            Console.WriteLine("Fail");

        }



    }
}