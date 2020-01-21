/*using System.Threading;
using AutoFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;*/

namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    public class EntryPoint
    {
        // IAlert alert;
        static void Main()
        {

        }

        /*[SetUp]
        public void intialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            // calling NavigateTo class LoginFormScenarioThroughMenu() to go to the login form 
            NavigateTo.LoginFormScenarioThroughMenu();
            
            // Calling the FillLoginForm of Action class using paramaeter username, password, and repeatPassword
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.repeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            
            // we use Assert class AreEqual() to compare the expected values and actual values
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);
            
            //  To click pn the OK button of the alert
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }*/
    }
}


