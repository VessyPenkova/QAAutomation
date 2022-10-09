using OpenQA.Selenium.Appium.Android;

namespace AppiumMobileTests.Objects
{
    public class Screen2
    {
        private readonly AndroidDriver<AndroidElement> driver;

        public Screen2(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public AndroidElement TextBoxFirstNumber =>
                    driver.FindElementById("com.example.androidappsummator:id/editText1");
        public AndroidElement TextBoxSecondNumber =>
            driver.FindElementById("com.example.androidappsummator:id/editText2");
        public AndroidElement TextBoxResult =>
            driver.FindElementById("com.example.androidappsummator:id/editTextSum");
        public AndroidElement ButtonCalc =>
            driver.FindElementById("com.example.androidappsummator:id/buttonCalcSum");

        public void Calculate(string num1, string num2)
        {
            TextBoxFirstNumber.Clear();
            TextBoxFirstNumber.SendKeys(num1);

            TextBoxSecondNumber.Clear();
            TextBoxSecondNumber.SendKeys(num2);

            ButtonCalc.Click();
        }
    }
}
