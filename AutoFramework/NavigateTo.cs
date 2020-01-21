namespace AutoFramework
{
    using System.Threading;
    using AutoFramework.Pages;

    public static class NavigateTo
    {

        // we can navigate to the loginForm in two ways . So we will create 2 methods, each seperately
        public static void LoginFormScenarioThroughTestCases()
        {
            // Simply following the way to reach the login form, we will go and create object of the class that are being used in process to 
            // reach loginForm
            // Steps: From menu, go and click Test case element, then click the username field in login form using the script
            // once entered we will get a linkText which we can use/click to go to the login form page
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ucPost = new UsernameCasePost();

            menu.TestCases.Click();
            Thread.Sleep(2000); // we will wait for 2 seconds just to see the background activity
            tcPage.UsernameCase.Click();
            Thread.Sleep(2000); // we will wait for 2 seconds just to see the background activity
            ucPost.LoginFormLink.Click();
            Thread.Sleep(2000); // we will wait for 2 seconds just to see the background activity
        }

        public static void LoginFormScenarioThroughMenu()
        {
            // creating an object of both the class that we need to navigate
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            // using the reference variable of menu class we can go and click the test scenerio and further from there loginFormScenario
            menu.TestScenarios.Click();
            Thread.Sleep(2000); // we will wait for 2 seconds just to see the background activity
            tsPage.LoginFormScenario.Click();
            Thread.Sleep(2000); // we will wait for 2 seconds just to see the background activity
        }
    }
}
