using NUnit.Framework;
using Problem;

namespace DemoTests
{
    public class Tests
    {

        [Test]
        public void BusinessLogic_DoSomeActions_ActionsDone()
        {
            //arrange
            var businessLogic = new BusinessLogic();
            
            //act
            businessLogic.DoSomeActions();
            
            //assert
            //??? how to validate? 
        }
    }
}