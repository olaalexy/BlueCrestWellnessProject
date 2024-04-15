using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            throw new PendingStepException();
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be logged in to my account")]
        public void ThenIShouldBeLoggedInToMyAccount()
        {
            throw new PendingStepException();
        }

        [When(@"I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            throw new PendingStepException();
        }
    }
}
