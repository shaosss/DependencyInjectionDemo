namespace Problem
{
    public interface IDataBase
    {
        DemoObject GetObject();
        
        void SaveObject(DemoObject objectToSave);
    }
}