using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Observer
{
    public abstract class Subject : MonoBehaviour
    {
        private readonly ArrayList _observer = new ArrayList();
        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }
        public void Detach(Observer observer){
            _observer.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (Observer observer in _observer){
                observer.Notify(this);
            }
        }
    }
}

