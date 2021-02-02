using System;

namespace Problem
{
    public class BusinessLogic
    {
        private readonly IDataBase _dataBase;

        public BusinessLogic(IDataBase dataBase)
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