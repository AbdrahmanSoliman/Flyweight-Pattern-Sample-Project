using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject> {}

public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable() 
    {
        gEvent.Register(this);    
    }

    private void OnDisable() 
    {
        gEvent.UnRegister(this);    
    }

    public void OnEventOccurs(GameObject gameObject)
    {
        response.Invoke(gameObject);
    }
}
