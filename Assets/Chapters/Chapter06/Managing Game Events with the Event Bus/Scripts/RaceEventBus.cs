using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
namespace Chapter.EventBus
{
    public class RaceEventBus : MonoBehaviour
    {
        private static readonly IDictionary<RaceEventType, UnityEvent> Events = 
        new Dictionary<RaceEventType, UnityEvent>();

        public static void Subscribe(RaceEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;
            if(Events.TryGetValue(eventType, out thisEvent)){
                thisEvent.AddListener(listener);
            }else{
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(eventType, thisEvent);
            }
        }
        public static void UnSubscribe(RaceEventType type, UnityAction listener)
        {
            UnityEvent thisEvent;
            if(Events.TryGetValue(type, out thisEvent)){
                thisEvent.RemoveListener(listener);
            }
        }
        public static void Publish(RaceEventType type)
        {
            UnityEvent thisEvent;
            if(Events.TryGetValue(type, out thisEvent)){
                thisEvent.Invoke();
            }
        }
        
    }
}

