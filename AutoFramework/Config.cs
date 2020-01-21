namespace AutoFramework
{
    // since we have only one config file in the project so we will make it static
    // we will store all the data that we are going to need for our tests in it
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        // this is the url that we are going to use in the project
        // we call it baseURL because this is the IRL for the main page of the web-site and we can use this URL to manipulate the URL
        // and go straight to where we want to go if that is what we need
        public static string BaseURL = "http://testing.todorvachev.com";


        // we are going to test our login form with valid and invalid credentials, so we will create a nested class and call it Credentials
        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "example@example.com";
                public static string Username = "Username";
                public static string Password = "password123!";
                public static string repeatPassword = "password123!";
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }

                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }

        public static class TestMessages
        {

        }

        public static class AlertsTexts
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
        }
    }
    
}

