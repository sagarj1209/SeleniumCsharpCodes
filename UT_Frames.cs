using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;

public class UT_Frames
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
        driver.Url="https://demoqa.com/alerts";
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        // driver.SwitchTo().Frame("frame1");
        //  res = driver.FindElement(By.varId("sampleHeading")).Text;
        // Console.WriteLine(res);
        // driver.SwitchTo().DefaultContent();
        
        // driver.FindElement(By.Id("item-1")).Click();
        driver.FindElement(By.Id("confirmButton")).Click();
        Thread.Sleep(2000);
        
        Utility.CaptureScreen(driver,"ss1");
        driver.SwitchTo().Alert().Accept();
        var res = driver.FindElement(By.Id("confirmResult")).Text;
        Console.WriteLine(res);


        driver.FindElement(By.Id("confirmButton")).Click();
        driver.SwitchTo().Alert().Dismiss();
        var res1 = driver.FindElement(By.Id("confirmResult")).Text;
        Console.WriteLine(res1);


        driver.Quit();
    }
}
