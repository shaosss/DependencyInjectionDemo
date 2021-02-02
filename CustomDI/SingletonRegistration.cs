using System;

namespace CustomDI
{
    public class SingletonRegistration<T> : IRegistration
    {
        public SingletonRegistration()
        {
            ActualType = typeof(T);
        }
        
        public Type ActualType { get; }

        private readonly object _creationLock = new object();

        private T _instance;
        private bool _instantiated;
        
        public object CreateType(object[] args)
        {
            if (!_instantiated)
            {
                lock (_creationLock)
                {
                    if (!_instantiated)
                    {
                        _instance = (T)Activator.CreateInstance(ActualType, args);
                        _instantiated = true;
                    }
                }
            }
            return _instance;
        }
    }
}