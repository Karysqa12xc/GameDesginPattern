using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Strategy
{
    public class ClientStrategy : MonoBehaviour
    {
        private GameObject _drone;
        private List<IManeuverBehaviour> _component 
            = new List<IManeuverBehaviour>();
        public void SpawnDrone()
        {
            _drone = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _drone.AddComponent<Drone>();
            _drone.transform.position = Random.insideUnitSphere * 10;
            ApplyRandomStrategies();
        }

        private void ApplyRandomStrategies()
        {
            _component.Add(_drone.AddComponent<WeavingManeuver>());
            _component.Add(_drone.AddComponent<BoppingManeuver>());
            _component.Add(_drone.AddComponent<FallBackManeuver>());
            int index = Random.Range(0, _component.Count);
            _drone.GetComponent<Drone>().ApplyStrategy(_component[index]);

        }
        void OnGUI()
        {
            if(GUILayout.Button("Spawn Drone")){
                SpawnDrone();
            }
        }
    }
}

