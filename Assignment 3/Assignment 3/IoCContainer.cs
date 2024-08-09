namespace Assignment_3;

using System;
using System.Collections.Generic;

public class IoCContainer
{
    private readonly Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

    public void Register<TService, TImplementation>()
    {
        _registrations[typeof(TService)] = typeof(TImplementation);
    }

    public TService Resolve<TService>()
    {
        return (TService)Resolve(typeof(TService));
    }

    private object Resolve(Type serviceType)
    {
        if (!_registrations.ContainsKey(serviceType))
        {
            throw new Exception($"service of type {serviceType.Name} not registered.");
        }

        var implementationType = _registrations[serviceType];
        var constructor = implementationType.GetConstructors()[0];
        var parameterTypes = constructor.GetParameters();
        var parameters = new List<object>();

        foreach (var parameterType in parameterTypes)
        {
            parameters.Add(Resolve(parameterType.ParameterType));
        }

        return Activator.CreateInstance(implementationType, parameters.ToArray());
    }
}