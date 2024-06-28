using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
namespace Pattern.Visitor
{
    public class Pickup : MonoBehaviour
    {
        public PowerUp powerUp;
        private Material changeColorPickUp;
        void Start()
        {
            changeColorPickUp = GetComponent<MeshRenderer>().material;
            if (powerUp.name.Equals("Engine"))
            {
                changeColorPickUp.color = Color.yellow;
            }
            if (powerUp.name.Equals("Weapon"))
            {
                changeColorPickUp.color = Color.cyan;
            }
            if (powerUp.name.Equals("Shield"))
            {
                changeColorPickUp.color = Color.blue;
            }

        }
        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<BikeController>())
            {
                other.GetComponent<BikeController>().Accept(powerUp);
                Destroy(gameObject);
            }
        }
    }

}
