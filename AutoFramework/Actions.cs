namespace AutoFramework
{
    using OpenQA.Selenium.Chrome;
    using Pages;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            // creating an instance of the ChromeDriver
            Driver.driver = new ChromeDriver();
            // Calling the baseURL using Navigate method of Driver Class
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);

            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        // we will call this method to fill the Login form using three parameters i.e. username, password, repeatPassword and then we 
        // will click on the login button
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();
            // clear the field first before sending keys to the textbox otherwise it will throw error and all the test case will not
            // work simultaneously
            loginScenario.UsernameField.Clear();
            // sending keys to the UseraName field using parameter username 
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            // sending keys to the Password field using parameter password
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            // sending keys to the RepeatPassword field using parameter repeatPassword
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            // After entering all the values to the text-box we will click on the login-button
            loginScenario.LoginButton.Click();
        }
    }
}
