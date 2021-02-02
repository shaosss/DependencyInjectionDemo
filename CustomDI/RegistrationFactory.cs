using System;

namespace CustomDI
{
    internal class RegistrationFactory
    {
        public IRegistration CreateRegistration<T>(LifeStrategyEnum lifeStrategy)
        {
            switch (lifeStrategy)
            {
                case LifeStrategyEnum.Singleton:
                    return new SingletonRegistration<T>();
                case LifeStrategyEnum.Transient:
                    return new TransientRegistration(typeof(T));
            }

            throw new ApplicationException($"No such registration life strategy supported {lifeStrategy}");
        }
    }
}