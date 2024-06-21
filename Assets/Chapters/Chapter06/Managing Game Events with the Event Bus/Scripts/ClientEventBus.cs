using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.EventBus
{
    public class ClientEventBus : MonoBehaviour
    {
        private bool _isButtonEnabled;
        // Start is called before the first frame update
        void Start()
        {
            gameObject.AddComponent<HUDController>();
            gameObject.AddComponent<CountdownTimer>();
            gameObject.AddComponent<BikeController>();
            _isButtonEnabled = true;
        }
        void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.STOP, Restart);
        }
        void OnDisable()
        {
            RaceEventBus.UnSubscribe(RaceEventType.STOP, Restart);
        }
        private void Restart()
        {
            _isButtonEnabled = true;
        }
        void OnGUI()
        {
            if(_isButtonEnabled){
                if(GUILayout.Button("Start Countdown")){
                    _isButtonEnabled = false;
                    RaceEventBus.Publish(RaceEventType.COUNTDOWN);
                }
            }
        }
    }
}

