using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;

public class LogOut
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
    
    public void TestA() { 

        driver.Url="https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        Thread.Sleep(3000);
        
        
        driver.FindElement(By.Name("username")).SendKeys("Admin");
        driver.FindElement(By.Name("password")).SendKeys("admin123");
        Thread.Sleep(3000);

         driver.FindElement(By.XPath("//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Click();
         Thread.Sleep(3000);

        // driver.FindElement(By.XPath("//*contains(@class='oxd-userdropdown')"));
         //*[@id="app"]/div[1]/div[1]/header/div[1]/div[2]/ul/li
        driver.FindElement(By.ClassName("oxd-main-menu-item")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div")).Click();



        //  driver.FindElement(By.ClassName("oxd-userdropdown")).Click();
        //  Thread.Sleep(2000);
        //  driver.FindElement(By.LinkText("Logout")).Click();
        //  Thread.Sleep(2000);




         driver.Quit();
    }
}