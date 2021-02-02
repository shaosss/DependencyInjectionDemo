using Moq;
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
            DemoObject testObject = new DemoObject();
            var dataBase = new Mock<IDataBase>();
            dataBase.Setup(x => x.GetObject())
                .Returns(testObject);
            var businessLogic = new BusinessLogic(dataBase.Object);
            
            //act
            businessLogic.DoSomeActions();
            
            //assert
            Assert.IsTrue(testObject.NeedUpdate);
            dataBase.Verify(x => x.GetObject(), Times.Once);
            dataBase.Verify(x => x.SaveObject(testObject), Times.Once);
        }
    }
}