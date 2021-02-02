using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDI
{
    public class DiContainer
    {
        private readonly Dictionary<Type, IRegistration> _registrations 
            = new Dictionary<Type, IRegistration>();

        private readonly RegistrationFactory _registrationFactory
            = new RegistrationFactory();
        
        public void Register<T>(LifeStrategyEnum lifeStrategy)
        {
            _registrations.Add(typeof(T), _registrationFactory.CreateRegistration<T>(lifeStrategy));
        }
        
        public void Register<TInterface, T>(LifeStrategyEnum lifeStrategy)
            where T : TInterface
        {
            _registrations.Add(typeof(TInterface), _registrationFactory.CreateRegistration<T>(lifeStrategy));
        }

        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }
        
        public object Resolve(Type resolveType)
        {
            if (!_registrations.ContainsKey(resolveType))
                throw new ApplicationException($"No registration of type {resolveType} found to resolve");
            var registration = _registrations[resolveType];
            foreach (var constructor in registration.ActualType.GetConstructors())
            {
                var constructorParameters = constructor.GetParameters();
                if (!constructorParameters.All(x => _registrations.ContainsKey(x.ParameterType)))
                    continue;
                var resolvedParameters = new List<object>();
                foreach (var parameter in constructor.GetParameters())
                {
                    resolvedParameters.Add(Resolve(parameter.ParameterType));
                }

                return registration.CreateType(resolvedParameters.ToArray());
            }
            throw new ApplicationException($"No applicable constructor of type {resolveType} found to resolve");
        }
    }
}