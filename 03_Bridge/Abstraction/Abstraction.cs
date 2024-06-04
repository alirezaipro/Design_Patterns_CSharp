﻿using _03_Bridge.Implementor;

namespace _03_Bridge.Abstraction;

public abstract class Abstraction
{
    private Implementor.Implementor _implementor;

    public virtual void Function()
    {
        _implementor = new ConcreteImplementor();
        
        _implementor.Implementation();
    }
}

public class RefinedAbstraction : Abstraction
{
}