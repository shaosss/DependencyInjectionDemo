using System;

namespace Problem
{
    public class BetterDataBase
    {
        public DemoObject GetObject()
        {
            Console.WriteLine("Getting the object faster");
            return new DemoObject();
        }
        
        public void SaveObject(DemoObject objectToSave)
        {
            objectToSave.NeedUpdate = false;
            Console.WriteLine("Saving the object faster");
        }
    }
}