using System;

namespace CustomDI
{
    public class TransientRegistration : IRegistration
    {
        public TransientRegistration(Type actualType)
        {
            ActualType = actualType;
        }
        
        public Type ActualType { get; }
        public object CreateType(object[] args)
        {
            return Activator.CreateInstance(ActualType, args);
        }
    }
}