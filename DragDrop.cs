using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;



public class DragDrop
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
    //[Parallelizable]
    public void TestA() { 
    //     driver.Url="https://jqueryui.com/droppable/";
    //     Actions act = new Actions(driver);
    //    // IWebElement frame = driver.FindElement(By.XPath("//*[@id='content']/iframe"));
    //     driver.SwitchTo().Frame(0);
    //     IWebElement src = driver.FindElement(By.XPath("//*[@id='draggable']"));
    //     IWebElement desti = driver.FindElement(By.XPath("//*[@id='droppable']"));
    //     act.DragAndDrop(src,desti).Build().Perform();

    // }

    //  driver.Url = "http://demos.telerik.com/kendo-ui/dragdrop/events";
    //         Actions act = new Actions(driver);
    //         IWebElement ele = driver.FindElement(By.Id("draggable"));
            

    //         act.ContextClick(ele)
    //             .Build()
    //             .Perform();

    //         Thread.Sleep(5000);


    // driver.Url = "http://demos.telerik.com/kendo-ui/dragdrop/events";
    //         Actions act = new Actions(driver);
    //         IWebElement src = driver.FindElement(By.Id("draggable"));
    //         IWebElement tar = driver.FindElement(By.Id("droptarget"));

    //         act.DragAndDrop(src,tar)
    //             .Build()
    //             .Perform();

    //         Thread.Sleep(4000);

    driver.Url = "http://demos.telerik.com/kendo-ui/sortable/index";
            Actions act = new Actions(driver);
            IWebElement ele = driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[12]"));
            IWebElement tar = driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[2]/span"));
                act.ClickAndHold(ele)
                .MoveToElement(tar,0,30)
                .Release()
                .Build()
                .Perform();

            Thread.Sleep(10000);
        }
}