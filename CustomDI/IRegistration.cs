using System;

namespace CustomDI
{
    public interface IRegistration
    {
        public Type ActualType { get; }
        public object CreateType(object[] args);
    }
}