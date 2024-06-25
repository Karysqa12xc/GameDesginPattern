using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace Chapter.Observer
{
    public class BikeController : Subject
    {
        public bool IsTurnOn { get; private set; }

        public float CurrentHealth
        {
            get
            {
                return health;
            }
        }
        private bool _isEngineOn;
        private HUDController _hudController;
        private CameraController _cameraController;
        [SerializeField]
        private float health = 0; 
        void Awake()
        {
            _hudController = gameObject.AddComponent<HUDController>();
            _cameraController = (CameraController) FindObjectOfType(typeof(CameraController));
   
        }
        void Start()
        {
            StartEngine();
        }
        void OnEnable()
        {
            if(_hudController){
                Attach(_hudController);
            }
            if(_cameraController){
                Attach(_cameraController);
            }
        }
        void OnDisable()
        {
            if(_hudController){
                Detach(_hudController);
            }
            if(_cameraController){
                Detach(_cameraController);
            }
        } 
        public void StartEngine()
        {
            _isEngineOn = true;
            NotifyObserver();
        }
        public void ToggleTurbo(){
            if(_isEngineOn){
                IsTurnOn = !IsTurnOn;
            }
            NotifyObserver();
        }
        public void TakeDame(float amount)
        {
            health -= amount;
            IsTurnOn = false;
            NotifyObserver();
            if(health < 0){
                Destroy(gameObject);
            }
        }
    }
}

