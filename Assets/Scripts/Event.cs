using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52 )]
public class Event : ScriptableObject
{
    private List<EventListener> _observers = new List<EventListener>();

    public void Register(EventListener observer)
    {
        _observers.Add(observer);
    }

    public void UnRegister(EventListener observer)
    {
        _observers.Remove(observer);
    }

    public void Occurred(GameObject gameObject)
    {
        for(int i = 0; i < _observers.Count; i++)
        {
            _observers[i].OnEventOccurs(gameObject);
        }
    }
}
