﻿namespace DesignPatterns.Observer;

public interface ISubject
{
    public void RegisterObserver(IObserver o);
    public void RemoveObserver(IObserver o);
    public void NotifyObservers();
}