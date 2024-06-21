using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class MovingState : IState
    {
        PlayerController _controller;

        public MovingState(PlayerController player)
        {
            _controller = player;

        }
        public void Enter()
        {
            Debug.Log("Moving Enter State");
            _controller.GetComponent<Rigidbody>().isKinematic = false;
            _controller.GetComponent<MeshRenderer>().material.color = Color.white;
        }

        public void Execute()
        {
            if (Input.GetAxisRaw("Horizontal") != 0
                || Input.GetAxisRaw("Vertical") != 0)
            {
                //? Moving object
                Vector3 _movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
                _controller.Moving(_movement);
                return;
            }
        }

        public void Exit()
        {
            Debug.Log("Moving Exit State");
        }

    }
}

