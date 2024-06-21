using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Chapter.Singleton
{
    public class GameManger : Singleton<GameManger>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;
        // Start is called before the first frame update
        void Start()
        {
            // TODO: 
            // - Load Player save
            // - If no save, redirect player to registration scene
            // - Call backend and get daily challenge and rewards
            _sessionStartTime = DateTime.Now;
            Debug.Log("Game session start @: " + DateTime.Now);
        }
        void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;
            TimeSpan timeDifferent = _sessionEndTime.Subtract(_sessionStartTime);

            Debug.Log("Game session ended @: " + DateTime.Now);

            Debug.Log("Game session lasted: " + timeDifferent);
        }

        void OnGUI()
        {
            if (GUILayout.Button("Next Scene"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }
}
