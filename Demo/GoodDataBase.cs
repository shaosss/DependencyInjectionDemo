using System;

namespace Problem
{
    public class GoodDataBase : IDataBase
    {
        public DemoObject GetObject()
        {
            Console.WriteLine("Getting the object");
            return new DemoObject();
        }
        
        public void SaveObject(DemoObject objectToSave)
        {
            objectToSave.NeedUpdate = false;
            Console.WriteLine("Saving the object");
        }
    }
}