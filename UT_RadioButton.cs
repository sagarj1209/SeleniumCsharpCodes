using OpenQA.Selenium;

namespace MyNUnitProject;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;


using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Firefox;

public class UT_RadioButton
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
        // IWebDriver driver = new ChromeDriver();
        // driver.Manage.Maximize();
        driver.Url="https://demoselsite.azurewebsites.net/webform4.aspx";
        

        
         IList<IWebElement> elements = driver.FindElements(By.Name("RadioButtonList1"));

        foreach (var element in elements)
        {
            if(element.GetAttribute("value").Equals("C#")){
                element.Click();
                break;
            }
            
        }
        var result = driver.FindElement(By.Id("lblText")).Text;
        Console.WriteLine(result);
        if(result.Contains("C#")){
            Console.WriteLine("Passed");
        }
        else{
            Console.WriteLine("Not passed");
        }

        driver.Quit();

    }

    [Test]

    public void TestB() { 
    driver.Url="https://demoselsite.azurewebsites.net/webform4.aspx";
    //driver.Manage.Maximize();
    driver.FindElement(By.Id("CheckBox1")).Click();
    var result =  driver.FindElement(By.Id("Label1"));

    if(result != null){
        Console.WriteLine("Passed");
        }
        else{
            Console.WriteLine("Not passed");
        }

    driver.Quit();

    }
}
