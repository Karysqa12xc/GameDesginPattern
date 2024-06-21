using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace Chapter.State
{
    public class IdleState : IState
    {
        PlayerController _controller;

        public IdleState()
        {

        }
        public IdleState(PlayerController player)
        {
            _controller = player;
        }
        public void Enter()
        {
            Debug.Log("Idle Enter State");
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
            Debug.Log("Idle Exit State");
        }
    }
}

