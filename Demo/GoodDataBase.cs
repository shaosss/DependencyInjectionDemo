using System;

namespace Problem
{
    public class GoodDataBase
    {
        public DemoObject GetObject()
        {
            Console.WriteLine("Getting the object");
            return new DemoObject();
        }
        
        public void SaveObject(DemoObject objectToSave)
        {
            Console.WriteLine("Saving the object");
        }
    }
}