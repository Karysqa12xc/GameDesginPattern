using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace Chapter.State
{
    public class FlyingState : IState
    {
        PlayerController _controller;
        public FlyingState(PlayerController player)
        {
            _controller = player;
        }
        public void Enter()
        {
            Debug.Log("Flying Enter State");
            _controller.GetComponent<Rigidbody>().isKinematic = true;
            _controller.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void Execute()
        {
            Debug.Log("Flying Execute State");
            //? Flying state
            Vector3 _movement = new Vector3(0, 0, 0);
            if (Input.GetKey(KeyCode.UpArrow) ||
                Input.GetKey(KeyCode.DownArrow))
            {
                _movement = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
                _controller.Flying(_movement);
                return;
            }
            if (Input.GetKey(KeyCode.LeftArrow)
            || Input.GetKey(KeyCode.RightArrow))
            {
                _movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
                _controller.Flying(_movement);
                return;
            }
            if (Input.GetKey(KeyCode.W))
            {
                _movement = new Vector3(0, 1, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                _movement = new Vector3(0, -1, 0);
            }
            _controller.Flying(_movement);
        }

        public void Exit()
        {
            Debug.Log("Flying Exit State");
        }
    }

}
