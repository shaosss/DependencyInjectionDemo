using System;

namespace Problem
{
    public class BusinessLogic
    {
        private readonly GoodDataBase _dataBase;

        public BusinessLogic(GoodDataBase dataBase)
        {
            _dataBase = dataBase;
        }
        
        public void DoSomeActions()
        {
            var someObject = _dataBase.GetObject();
            
            Console.WriteLine("Doing some action on object");
            someObject.NeedUpdate = true;
            
            _dataBase.SaveObject(someObject);
        }
    }
}