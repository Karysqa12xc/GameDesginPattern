using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class StateManager : MonoBehaviour  
    {
        [SerializeField] IState _currentState;
        
        public void ChangeState(IState state)
        {
            if(_currentState != null && state.GetType() == _currentState.GetType()){
                return;
            }
            if (_currentState != null)
            {
                _currentState.Exit();
            }
            _currentState = state;
            if (_currentState != null)
            {
                _currentState.Enter();
            }
        }
        public void Update()
        {
            if (_currentState != null)
            {
                _currentState.Execute();
            }
        }
    }

}
