using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pattern.Visitor
{
    public class ClientVisitor : MonoBehaviour
    {
        public PowerUp enginePowerUp;
        public PowerUp shieldPowerUp;
        public PowerUp weaponPowerUp;
        private BikeController _bikeController;
        [SerializeField]
        private Material changeColor;
        // Start is called before the first frame update
        void Start()
        {
            _bikeController = gameObject.AddComponent<BikeController>();
            changeColor = GetComponent<MeshRenderer>().material;
            changeColor.color = Color.red;
        }
        void OnGUI()
        {
            if(GUILayout.Button("PowerUp Shield")){
                _bikeController.Accept(shieldPowerUp);
            }
            if(GUILayout.Button("PowerUp Engine")){
                _bikeController.Accept(enginePowerUp);
            }
            if(GUILayout.Button("PowerUp Weapon")){
                _bikeController.Accept(weaponPowerUp);
            }
        }
    }
}

