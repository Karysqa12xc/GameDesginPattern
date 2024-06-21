using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Singleton
{
    public class MoveCube : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void MovementCube(GameObject gameObject)
        {
            gameObject.transform.Translate(Vector3.up);
        }  
    }

}
