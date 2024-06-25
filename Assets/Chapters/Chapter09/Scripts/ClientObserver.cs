using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Observer
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeController _bikeController;
        // Start is called before the first frame update
        void Start()
        {
            _bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
        }
        void OnGUI()
        {
            if(GUILayout.Button("Damage Bike")){
                if(_bikeController){
                    _bikeController.TakeDame(15.0f);
                }
            }
            if(GUILayout.Button("Toggle Turbo")){
                if(_bikeController){
                    _bikeController.ToggleTurbo();
                }
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

