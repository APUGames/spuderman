using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameCompletionTracker : MonoBehaviour {

    private GameObject playerObj = null;

    private void Start()
    {
        //If you want to find it by NAME. For t$$anonymous$$s you have to make sure you only have 1 object named "Player".
        if (playerObj == null)
            playerObj = GameObject.Find("Player_Test");
    }

    private void Update()
    {
        // Debug.Log("Player Position: X = " + playerObj.transform.position.x);
        // currently -6 - 8, 14 
        float effectiveLevelComplete = (playerObj.transform.position.x + 6) * (100 / 14);
        // Debug.Log("effectiveLevelComplete = " + effectiveLevelComplete);
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("level_completion", effectiveLevelComplete);
    }
}