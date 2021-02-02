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
            var dataBase = new GoodDataBase();
            var businessLogic = new BusinessLogic(dataBase);
            
            //act
            businessLogic.DoSomeActions();
            
            //assert
            var testObject = dataBase.GetObject();
            Assert.IsTrue(testObject.NeedUpdate);
        }
    }
}