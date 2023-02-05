using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameCompletionTracker : MonoBehaviour {

    private GameObject playerObj = null;
    private Vector2 beginLoc;
    private Vector2 endLoc;
    private float levelLen;

    private void Start()
    {
        //If you want to find it by NAME. For t$$anonymous$$s you have to make sure you only have 1 object named "Player".
        if (playerObj == null) {
            playerObj = GameObject.Find("Player_Test");
        }
        // init total scene length
        beginLoc = GameObject.Find("SceneBeginLoc").transform.position;
        endLoc = GameObject.Find("SceneEndLoc").transform.position;
        levelLen = Vector2.Distance(beginLoc, endLoc);
    }

    private void Update()
    {
        Debug.Log("levelLen = " + levelLen);
        // calculate distance between begin and end
        float currentDist = Vector2.Distance(playerObj.transform.position, endLoc);
        // compare player distance to total distance, invert, map between 0 - 100
        float effectiveLevelComplete = (1 - Mathf.InverseLerp(0, levelLen, currentDist)) * 100; 
        // update FMOD param
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("level_completion", effectiveLevelComplete);
    }
}