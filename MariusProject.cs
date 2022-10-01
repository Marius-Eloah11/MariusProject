
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace Mariustest
{
    internal class Program
    
    {
        static void Main(string[] args)
        {

            //This first line opens Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Talja\\Downloads\\chromedriver_win32\\");

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            
            //Searches for the Login or sign in button and cliscks it
            IWebElement loginElement = driver.FindElement(By.ClassName("login"));
            loginElement.Click();

            //selects email text box, clears and allows text to be entered
            IWebElement emailElement = driver.FindElement(By.Id("email_create"));
            emailElement.Clear();
            emailElement.SendKeys("mariusbarca11@gmail.com");

            //submit button clicked on
            IWebElement submitElement = driver.FindElement(By.Id("SubmitCreate"));
            submitElement.Click();

            //timespan added for it not to give error
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //gender chosen
            IWebElement genderElement = driver.FindElement(By.Id("uniform-id_gender1"));
            genderElement.Click();

           


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //Firstname entered, clear to open space,
            IWebElement nameElement = driver.FindElement(By.Id("customer_firstname"));
            nameElement.Clear();
            nameElement.SendKeys("Marius");
            //surname entered,
            IWebElement surnameElement = driver.FindElement(By.Id("customer_lastname"));
            surnameElement.Clear();
            surnameElement.SendKeys("van der Merwe");

            IWebElement email2Element = driver.FindElement(By.Id("email"));
            email2Element.Clear();
            email2Element.SendKeys("mariusbarca11@gmail.com");

            IWebElement passwordElement = driver.FindElement(By.Id("passwd"));
            passwordElement.Clear();
            passwordElement.SendKeys("Mariusbarca11!");

            SelectElement birthdayElement = new SelectElement(driver.FindElement(By.Id("days")));

            //select by value
            birthdayElement.SelectByValue("1");


            SelectElement birthmonthElement = new SelectElement(driver.FindElement(By.Id("months")));

            //select by value
            birthmonthElement.SelectByValue("4");



            SelectElement birthyearElement = new SelectElement(driver.FindElement(By.Id("years")));

            //select by value
            birthyearElement.SelectByValue("1995");
            

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
            //copied the code above corrected id for the firstname to be filled in again
            IWebElement name2Element = driver.FindElement(By.Id("firstname"));
            name2Element.Clear();
            name2Element.SendKeys("Marius");

            //copied previous code for lastname
            IWebElement surname2Element = driver.FindElement(By.Id("lastname"));
            surname2Element.Clear();
            surname2Element.SendKeys("van der Merwe");
            

            IWebElement companyElement = driver.FindElement(By.Id("company"));
            companyElement.Clear();
            companyElement.SendKeys("Porcupine");

            IWebElement addressElement = driver.FindElement(By.Id("address1"));
            addressElement.Clear();
            addressElement.SendKeys("772 norman street");

            IWebElement cityElement = driver.FindElement(By.Id("city"));
            cityElement.Clear();
            cityElement.SendKeys("Pretoria");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //drop down needed to go back to upper codes to use same as previous drop down code
            SelectElement stateElement = new SelectElement(driver.FindElement(By.Id("years")));

            //select by value Alaska chosen
            stateElement.SelectByValue("2");

            IWebElement zipElement = driver.FindElement(By.Id("postcode"));
            zipElement.Clear();
            zipElement.SendKeys("0182");

            SelectElement countElement = new SelectElement(driver.FindElement(By.Id("id_country")));

            countElement.SelectByValue("21");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement phoneElement = driver.FindElement(By.Id("phone_mobile"));
            phoneElement.Clear();
            phoneElement.SendKeys("0797332784");

            IWebElement assignElement = driver.FindElement(By.Id("alias"));
            assignElement.Clear();
            assignElement.SendKeys("772 norman street");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement regElement = driver.FindElement(By.Id("submitAccount"));
            regElement.Click();

            //not sure why it does not want to continue after the last name to add address Ect. i tried to comment some code out it still did not work























        }
    }
}
