using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public interface IState
    {
        void Enter();

        void Execute();
        
        void Exit();
    }
}

