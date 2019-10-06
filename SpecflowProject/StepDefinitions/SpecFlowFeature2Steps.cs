using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowProject.StepDefinitions
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 121)
            {
                Console.WriteLine("The test PASS");
            }
            else
            {
                Console.WriteLine("The test FAIL");
                throw new Exception("The value is different");
            }
        }
        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
           var details = table.CreateSet<EmployeeDetails>();
           foreach (var emp in details)
           {
               Console.WriteLine($"The detail of employee: {emp.Name}");
               Console.WriteLine("*************************************");
               Console.WriteLine(emp.Age);
               Console.WriteLine(emp.Email);
               Console.WriteLine(emp.Name);
               Console.WriteLine(emp.Phone);
            }

        }

    }
}
