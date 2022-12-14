using AppiumMobileTests.Objects;

namespace AppiumMobileTests.Tests
{
    public class Test3 : BaseTest3
    {
        [Test]
        public void Test_ContactBook_SearchByFirstName()
        {
            var form = new Screen3(driver);
            form.ConnectToAPI();

            var input = "Steve";
            form.SearchContact(input);

            Thread.Sleep(1000);

            var firstName = form.ElementFirstName.First().Text;
            Assert.AreEqual(input, firstName);

            var lastName = form.ElementLastName.First().Text;
            Assert.AreEqual("Jobs", lastName);
        }

        [Test]
        public void Test_ContactBook_SearchByLetter()
        {
            var window = new Screen3(driver);
            window.ConnectToAPI();

            var input = "s";
            window.SearchContact(input);

            Thread.Sleep(1000);

            var contactsFound = window.ElementContactsCount.Text;
            var count = window.ElementFirstName.Count;
            var contactsCount = "Contacts found: " + count;

            Assert.AreEqual(contactsCount, contactsFound);

            var firstName = window.ElementFirstName.Last().Text;
            Assert.AreEqual("Albert", firstName);

            var lastName = window.ElementLastName.Last().Text;
            Assert.AreEqual("Einstein", lastName);
        }
    }
}